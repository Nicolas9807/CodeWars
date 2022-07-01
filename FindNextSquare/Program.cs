using System;

namespace FindNextSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long numb = long.Parse(Console.ReadLine());
            long res = FindNextSquare(numb);
            Console.WriteLine(res);

        }

        public static long FindNextSquare(long num)
        {
            double sqrt = Math.Sqrt(num);

            if(sqrt % 1 == 0)
            {
                return (long)Math.Pow(sqrt + 1, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}