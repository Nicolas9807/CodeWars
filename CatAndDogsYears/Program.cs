using System;

namespace CatAndDogsYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int humans = int.Parse(Console.ReadLine());

            int[] result = humanYearsCatYearsDogYears(humans);
            
            Console.WriteLine(string.Join(" ", result));
        }
        
        public static int[] humanYearsCatYearsDogYears(int humanYears) {
            if(humanYears == 0) return new int[]{0,0,0};
            int catYears = 0, dogYears = 0;
    
            if(humanYears == 1)
            {
                catYears = 15;
                dogYears = 15;
            }
    
            else if(humanYears == 2)
            {
                catYears = 15 + 9;
                dogYears = 15 + 9;
            }
    
            else
            {
                catYears = 15 + 9 + (humanYears - 2) * 4;
                dogYears = 15 + 9 + (humanYears - 2) * 5;
            }
    
            return new int[]{humanYears,catYears,dogYears};
        }
    }
}