using System;

namespace RentalCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int day = int.Parse(Console.ReadLine());
            int price = RentalCarCost(day);
            Console.WriteLine("price = " + price);
        }
        
        public static int RentalCarCost(int d)
        {
            int dailyRent = 40;
            int sdiscount = 20;
            int bdiscount = 50;
        
            int price = 0;
        
            price = d * dailyRent;
        
            if ( d >= 3 && d <7)
                price = price - sdiscount;
          
            if (d >= 7)
                price = price - bdiscount;  
        
            return price;
        }
    }
}