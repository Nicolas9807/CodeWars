using System;

namespace PreviousMultiplyToThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numb = int.Parse(Console.ReadLine());
            string res = PreviousMultipleOfThree(numb).ToString();
            Console.WriteLine(res);
        }
        
        public static int? PreviousMultipleOfThree(int n)
        {
            string arr = n.ToString();

            for (int i = 0; i < n.ToString().Length; i++)
            {
                if (int.Parse(arr) % 3 == 0)
                    return int.Parse(arr);
                arr = arr.Remove(arr.Length - 1);
            }

            return null;
        }
    }
}