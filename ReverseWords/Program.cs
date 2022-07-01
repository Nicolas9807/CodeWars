using System;
using System.Linq;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sentence = Console.ReadLine();
            string res = ReverseWords(sentence);
            Console.WriteLine(res);
        }
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }
}