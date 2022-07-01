using System;

namespace TimeInMilliseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int res = Past(hour, minute, second);

            Console.WriteLine("Hello World!");
            Console.WriteLine("result = " + res);
        }
        public static int Past(int h, int m, int s)
        {
            int result = (h * 1 * 60 * 60 * 1000) + (m * 60 * 1000) + (s * 1000);
            return result;
        }
    }
}