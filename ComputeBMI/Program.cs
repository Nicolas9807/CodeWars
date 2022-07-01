using System;

namespace ComputeBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            string res = Bmi(weight, height);
            Console.WriteLine("Your result of bmi = " + res.ToLower());
        }
        
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            if(bmi <= 18.5) return "Underweight";
            else if(bmi <= 25) return "Normal";
            else if(bmi <= 30) return "Overweight";
            else return "Obese";
        }
    }
}