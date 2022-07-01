using System;

namespace MaskCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string res = Maskify(str);
            Console.WriteLine(res);
        }
        
        public static string Maskify(string cc)
        {
            char[] arr = cc.ToCharArray();
            for (int i = 0; i < arr.Length - 4; i++)
            {
                arr[i] = '#';
            }

            return new string(arr);
        }
    }
}