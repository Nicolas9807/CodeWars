using System;
using System.Text;

namespace AppendSheeps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int count = int.Parse(Console.ReadLine());
            string res = CountSheep(count);
            Console.WriteLine(res);
        }
        
        public static string CountSheep(int n)
        {
            StringBuilder sheepBuilder = new StringBuilder();
            string append =" sheep...";
            for (int i = 1; i <= n; i++)
            {
                sheepBuilder.Append(i).Append(append);
            }
            return sheepBuilder.ToString();
        }
    }
}