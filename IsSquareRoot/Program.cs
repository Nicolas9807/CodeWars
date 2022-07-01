using System;

namespace IsSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int[] res = SquareOrSquareRoot(arr);
            Console.WriteLine(String.Join(" ", res));
        }
       
        public static int[] SquareOrSquareRoot(int[] array)
        {
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = Convert.ToDouble(array[i]);
            }
            for(int i = 0; i < array.Length; i++)
            {
                double res = Math.Sqrt(arr[i]);
                if (res % 1 == 0)
                    arr[i] = Math.Sqrt(arr[i]);
                else
                    arr[i] = Math.Pow(arr[i], 2);
            }

            int[] final = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                final[i] = Convert.ToInt32(arr[i]);
            }
            return final;
        }
    }
}