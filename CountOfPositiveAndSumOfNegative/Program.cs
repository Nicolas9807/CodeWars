using System;

namespace CountOfPositiveAndSumOfNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
            Console.WriteLine("Hello World!");
            int[] res = CountPositivesSumNegatives(array);
            Console.WriteLine(string.Join(",", res));
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int count = 0;
            int sum = 0;
      
            if (input == null || input.Length == 0)
            {
                return new int[]{};
            }
      
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    count++;
                }
                if (input[i] < 0)
                {
                    sum += input[i];
                }
            }
            return new int[] {count, sum};
        }
    }
}