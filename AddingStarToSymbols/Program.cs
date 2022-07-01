using System;

namespace AddingStarToSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] arr = new[] { Console.ReadLine() };
            string res = TwoSort(arr);
            Console.WriteLine(res);
        }
        
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            char[] word = s[0].ToCharArray();
            return string.Join("***", word);
        }  
    }
}