using System;

namespace SortDigitsInNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            uint numb = uint.Parse(Console.ReadLine());
            uint res = SortBytes(numb);
            Console.WriteLine(res);
        }
        
        public static uint SortBytes(uint number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            Array.Sort(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }
    }
}