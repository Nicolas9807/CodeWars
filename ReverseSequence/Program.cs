using System;

namespace ReverseSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            int[] res = ReverseSeq(n);
            Console.WriteLine(string.Join(",", res));
        }
        
        public static int[] ReverseSeq(int n)
        {
            int[] arr = new int[n];
            for (int i = n; i > 0; i--){
                arr[n-i] = i; 
            }
            return arr;
        }
    }
}