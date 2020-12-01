using System;
using System.Threading.Tasks;

namespace AoC.TwentyTwenty
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, Advent of Code 2020!");

            await new One().Run();
        }
    }
}
