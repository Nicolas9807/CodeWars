using System;
using System.Linq;

namespace TotalAmountOfPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            string[] arr = new string[] { str };
            int res = TotalPoints(arr);
            Console.WriteLine(res);
        }
        
        public static int TotalPoints(string[] games)
        {
            int result = 0;
            foreach (string game in games) {
                if (game[0] > game[2])
                    result += 3;
                else if (game[0] == game[2])
                    result += 1;            
            }
            return result;
        }
    }
}