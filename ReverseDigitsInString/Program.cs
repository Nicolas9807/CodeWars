using System;

namespace ReverseDigitsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = int.Parse(Console.ReadLine());
            int res = DescendingOrder(number);
            Console.WriteLine(res);
        }
        
        public static int DescendingOrder(int num)
        {
            char[] str = num.ToString().ToCharArray();
            Array.Sort(str);
            Array.Reverse(str);

            int result = int.Parse(new string(str));

            return result;
        }
    }
}