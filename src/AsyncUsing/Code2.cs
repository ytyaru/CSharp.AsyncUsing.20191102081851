using System;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AsyncUsing
{
    class Code2
    {
        public async Task Run()
        {
            await using(var x = new A()) {
                Console.WriteLine($"{this.GetType().Name}");
            }
        }
        class A
        {
            public MyAwaitable DisposeAsync()
            {
                Console.WriteLine($"{MethodBase.GetCurrentMethod().Name}");
                return default;
            }
        }
        struct MyAwaitable { public ValueTaskAwaiter GetAwaiter() => default; }
    }
}
