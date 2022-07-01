using System;

namespace MultiplyEveryDigitInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = int.Parse(Console.ReadLine());
            int result = SquareDigits(number);
            Console.WriteLine(result);
        }
        
        public static int SquareDigits(int n)
        {
            string result = "";
            foreach (char c in n.ToString())
            {
                int digit = int.Parse(c.ToString());
                result += Math.Pow(digit, 2);
            }
            return int.Parse(result);
        }
    }
}