using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreamExample
{
    class EmployeeInfo 
    {
        public int Id { get; set; }
    }

    class Producer
    {
        public async IAsyncEnumerable<EmployeeInfo> GetEmployeeInfosAsync(int count)
        {
            for (int i = 0; i < count; i++)
            {
                await Task.Delay(500);
                yield return new EmployeeInfo(){Id = i +1};
            }
        }
    }
}
