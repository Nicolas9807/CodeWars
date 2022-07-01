using System;
using System.Linq;

namespace CompareValuesFromArrayAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
            int myPoints = int.Parse(Console.ReadLine());
            bool res = BetterThanAverage(arr, myPoints);
            Console.WriteLine(res);    
        }
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            double avgPoint = ClassPoints.Sum() / ClassPoints.Length;
            if(YourPoints > avgPoint) return true;
            else  return false;
        }
    }
}