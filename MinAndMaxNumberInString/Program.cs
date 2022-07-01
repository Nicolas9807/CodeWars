using System;
using System.Linq;

namespace MinAndMaxNumberInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string res = HighAndLow(str);
            Console.WriteLine(res);
        }

        public static string HighAndLow(string numbers)
        {
            string[] str = numbers.Split(' ');
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);
            }

            int max = arr.Max();
            int min = arr.Min();
            string result = max + " " + min;
            return result;
        }
    }
}