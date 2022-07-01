using System;

namespace FindShortestWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string line = Console.ReadLine();
            int result = FindShort(line);
            Console.WriteLine("result: " + result);
        }
        
        public static int FindShort(string s)
        {
            string[] strArr = s.Split(' ');
            int max = int.MaxValue;

            foreach (string item in strArr)
            {
                if (item.Length < max)
                {
                    max = item.Length;
                }
            }
            return max;
        }
    }
}