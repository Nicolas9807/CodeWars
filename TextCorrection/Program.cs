using System;

namespace TextCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string line = Console.ReadLine();
            string res = Correct(line);
            Console.WriteLine(res);
        }
        
        public static string Correct(string text)
        {
            char[] arr = text.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '0')
                    arr[i] = 'O';
                if (arr[i] == '5')
                    arr[i] = 'S';
                if (arr[i] == '1')
                    arr[i] = 'I';
            }

            return string.Join("", arr);
        }
    }
}