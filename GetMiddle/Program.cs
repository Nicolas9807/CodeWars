using System;

namespace GetMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string res = GetMiddle(str);
            Console.WriteLine(res);
        }
        
        public static string GetMiddle(string s)
        { 
            if (string.IsNullOrEmpty(s) || s.Length == 0) 
                return "";
            if (s.Length %2 == 0) 
                return s.Substring((s.Length/2)-1, 2);
                   
            return s.Substring((s.Length / 2), 1); 
        }
    }
}