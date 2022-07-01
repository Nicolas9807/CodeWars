using System;

namespace ConvertMark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetGrade(a, b, c));
        }
        
        public static char GetGrade(int s1, int s2, int s3)
        {
            int avg = (s1 + s2 + s3) / 3;
            if(avg >= 60 && avg < 70) 
                return 'D';
            if(avg >= 70 && avg < 80) 
                return 'C';
            if(avg >= 80 && avg < 90) 
                return 'B';
            if(avg >= 90 && avg <= 100) 
                return 'A';
            return 'F';
        }
    }
}