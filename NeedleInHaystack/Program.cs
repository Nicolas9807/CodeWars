using System;

namespace NeedleInHaystack
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] stack = new[] { Console.ReadLine() };
            string result = FindNeedle(stack);
            Console.WriteLine("Hello World!");
            Console.WriteLine(result);
        }
        public static string FindNeedle(object[] haystack)
        {
            int index = Array.IndexOf(haystack, "needle");
            return "found the needle at position " + index;
        }
    }
}