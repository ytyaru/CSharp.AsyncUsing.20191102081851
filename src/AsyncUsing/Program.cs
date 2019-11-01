using System;
using System.Threading.Tasks;

namespace AsyncUsing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new Code0().Run();
            await new Code1().Run();
            await new Code2().Run();
        }
    }
}
