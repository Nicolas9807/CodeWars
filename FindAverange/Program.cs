using System;
using System.Linq;

namespace FindAverange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToDouble);
            double res = FindAverage(arr);
            Console.WriteLine(res);
        }
        public static double FindAverage(double[] array)
        {
            if(array == null || array.Length == 0){
                return 0;
            }

            return array.Sum() / array.Length;
        }
    }
}