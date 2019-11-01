using System;
using System.Threading.Tasks;
using System.Reflection;

namespace AsyncUsing
{
    class Code1
    {
        public async Task Run()
        {
            await using(var x = new A()) {
                Console.WriteLine($"{this.GetType().Name}");
            }
        }
        class A
        {
            public ValueTask DisposeAsync()
            {
                Console.WriteLine($"{MethodBase.GetCurrentMethod().Name}");
                return default;
            }
        }
    }
}
