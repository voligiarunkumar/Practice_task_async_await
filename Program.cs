using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Async_Await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task<int> result1 = Process1();
            Task<int> result2 = Process2();


            Console.WriteLine("After two  processes.");

            int val = await result1; // wait untile get the return value
            DisplayResult(val);

            val = await result2; // wait untile get the return value
            DisplayResult(val);

            Console.ReadKey();
        }

        static async Task<int> Process1()
        {
            Console.WriteLine("LongProcess 1 Started");

            await Task.Delay(4000);

            Console.WriteLine("LongProcess 1 Completed");

            return 10;
        }

        static async Task<int> Process2()
        {
            Console.WriteLine("LongProcess 2 Started");

            await Task.Delay(4000);

            Console.WriteLine("LongProcess 2 Completed");

            return 20;
        }

        static void DisplayResult(int val)
        {
            Console.WriteLine(val);
        }
    }
}
