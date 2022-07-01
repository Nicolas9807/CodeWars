using System;

namespace TwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] array = new int[1, 5];
            
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());  
                }
            }
            
            int result = Result(array);
            Console.WriteLine(result);
        }
        
        public static int Result(int[,] array)
        {
            int res = 1, sum;
            for (int i = 0; i < array.GetLength(0); i++) {
                sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    sum += array[i, j];
                res *= sum;
            }
            return res;
        }
    }
}