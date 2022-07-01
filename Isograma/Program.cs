using System;
using System.Linq;

namespace Isograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string line = Console.ReadLine();
            bool result = IsIsogram(line);
            Console.WriteLine("result = " + result);
        }
        
        public static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count()==str.Length;
        }
        
    }
}