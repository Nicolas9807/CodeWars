using System;

namespace ComplimentaryDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string res = MakeComplement(str);
            Console.WriteLine(string.Join("", res));
        }
        
        public static string MakeComplement(string dna)
        {
            char[] arr = dna.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'A')
                    arr[i] = 'T';
                else if (arr[i] == 'T')
                    arr[i] = 'A';
                else if (arr[i] == 'C')
                    arr[i] = 'G';
                else if (arr[i] == 'G')
                    arr[i] = 'C';
            }

            return new string(arr);
        }
    }
}