using System;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            String result = Accum(str);
            Console.WriteLine(result);
        }
        
        public static String Accum(string s) 
        {
            string result = "";
            int count = 0;
            foreach(char c in s.ToUpper()) {
                //Console.WriteLine(c);  
                if (count != 0) result+="-";
                result += c + new String(char.ToLower(c), count);
                ++count;
            }
            return result;
        }
    }
}