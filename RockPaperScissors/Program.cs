using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();

            string res = rps(p1, p2);
            Console.WriteLine("Result of battle - " + res);
        }
        
        public static string rps(string p1, string p2)
        {
            string result = "";
            if(p1 == p2 && (p1 == "paper" || p1 == "rock" || p1 == "scissors")) result = "Draw!";
            if((p1 == "scissors" && p2 == "paper") || (p1 == "rock" && p2 == "scissors") || (p1 == "paper" && p2 == "rock")) result = "Player 1 won!";
            if((p2 == "scissors" && p1 == "paper") || (p2 == "rock" && p1 == "scissors") || (p2 == "paper" && p1 == "rock")) result = "Player 2 won!";
            return result;
        }
    }
}