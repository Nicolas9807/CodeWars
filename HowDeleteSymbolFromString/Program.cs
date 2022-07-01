using System;

namespace HowDeleteSymbolFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string line = Console.ReadLine();
            string result = RemoveExclamationMarks(line);
            Console.WriteLine(result);
        }
        
        public static string RemoveExclamationMarks(string s)
        {
            return string.Join("", s.Split('!'));
        }
    }
}