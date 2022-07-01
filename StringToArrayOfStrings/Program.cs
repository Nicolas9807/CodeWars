using System;

namespace StringToArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string line = Console.ReadLine();
            string[] res = StringToArray(line);
            Console.WriteLine(res);
        }
        
        public static string[] StringToArray(string str)
        {
            string[] strArrayOne = new string[] {""};
            strArrayOne = str.Split(' ');
            return strArrayOne;
        }
    }
}