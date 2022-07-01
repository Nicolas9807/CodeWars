using System;
using System.Linq;

namespace ObjectArrayToIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object[] x = new object[] { Console.ReadLine() };
            int res = SumMix(x);
            Console.WriteLine(res);
        }
        
        public static int SumMix(object[] x)
        {
            return x.Sum(Convert.ToInt32);
        }
    }
}