using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousStreamExample
{
    class Program
    {
        private static int ThreadId => Thread.CurrentThread.ManagedThreadId;

        static async Task Main(string[] args)
        {
            var producer = new Producer();
            
            Console.WriteLine($"({ThreadId})取得員工資料");

            await foreach (var employee in producer.GetEmployeeInfosAsync(20))
            {
                Console.WriteLine($"({ThreadId})開始接收資料: {employee.Id}");
            }

            Console.WriteLine($"({ThreadId})接收資料完畢");
        }
    }
}
