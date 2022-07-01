using System;

namespace ChangeNumberInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string result = FakeBin(str);
            Console.WriteLine(result);
        }
        public static string FakeBin(string x)
        {
            string str = "";
            foreach(char i in x)
            {
                if(i < '5')  str += '0';
                else str += '1';
            }
            return str;
        }
    }
}