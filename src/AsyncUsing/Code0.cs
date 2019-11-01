using System;
using System.Threading.Tasks;

namespace AsyncUsing
{
    class Code0
    {
        public async Task Run()
        {
            await using(var x = new A()) {
                Console.WriteLine("Code0");
            }
        }
        struct A
        {
            // Enumerable必須
            public A GetAsyncEnumerator() => this;
         
            // Enumerator必須
            public int Current => 0;
            public ValueTask<bool> MoveNextAsync()
            {
                Console.WriteLine("MoveNextAsync");
                return new ValueTask<bool>(false);
            }
         
            // 未実装なら呼ばれない
            public ValueTask DisposeAsync()
            {
                Console.WriteLine("DisposeAsync");
                return default;
            }
        }
    }
}
