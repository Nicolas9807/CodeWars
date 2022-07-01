using System;
using System.Linq;

namespace JadenCase
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string res = ToJadenCase(str);
            Console.WriteLine(res);
        }
        
        public static string ToJadenCase(this string phrase)
        {
            char[] a = phrase.ToLower().ToCharArray();

            for (int i = 0; i < a.Count(); i++ )
            {
                a[i] = i == 0 || a[i-1] == ' ' ? char.ToUpper(a[i]) : a[i];
            }

            return new string(a);
        }
    }
}