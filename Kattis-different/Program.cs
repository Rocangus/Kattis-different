using System;

namespace Kattis_different
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            long output;
            while ((input = Console.ReadLine()) != null)
            {
                CalculateAbsoluteOfDifferenceBetweenInputNumbers(input, out output);
                Console.WriteLine(output);
            }
        } 

        public static void CalculateAbsoluteOfDifferenceBetweenInputNumbers(string input, out long output)
        {
            var split = input.Split();
            var i = long.Parse(split[0]);
            var n = long.Parse(split[1]);
            output = Math.Abs(i - n);
        }
    }
} 
