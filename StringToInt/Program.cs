using System;

namespace StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = StringToNumber(Console.ReadLine());
            Console.WriteLine("Hello World!");
            Console.WriteLine(res);
        }
        public static int StringToNumber(String str)
        {
            int result = Convert.ToInt32(str);
            return result;
        }
    }
}