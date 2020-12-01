using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AoC.TwentyTwenty
{
    public class One
    {
        public async Task Run()
        {
            var lines = await File.ReadAllLinesAsync(@"one.txt");
            var numbers = new HashSet<int>(lines.Where(line => !string.IsNullOrWhiteSpace(line)).Select(line => int.Parse(line)));

            foreach(var number in numbers)
            {
                int compliment = 2020 - number;
                if(numbers.Contains(compliment)) {
                    Console.WriteLine(number * compliment);
                    break;
                }
            }

            foreach(var number in numbers)
            {
                int left = 2020 - number;

                foreach(var number2 in numbers)
                {
                    int compliment = left - number2;
                    if(numbers.Contains(compliment)) {
                        Console.WriteLine(number * number2 * compliment);
                        return;
                    }
                }
            }
            
        }
    }
}