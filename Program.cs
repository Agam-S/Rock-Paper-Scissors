using System;

namespace Practice_RockPaperScissors
{
    class Program
    {
        public static int End()
        {   
            int round = 1;
            int Player = 0;
            int AI = 0;

            while (round != 4) {
            
            System.Console.WriteLine("Round " + round + " of 3" );

            string[] choices = new string[3] {"Rock", "Paper", "Scissors"};
            Random rnd = new Random();
            int n = rnd.Next(0, 3);

            System.Console.WriteLine($"Pick Rock, Paper or Scissors --");
            string input =  Console.ReadLine();

            System.Console.WriteLine($"Computer Chooses =====: " + choices[n]);

            if(input == "Paper" && choices[n] == "Scissors") {
                System.Console.WriteLine("Computer Wins this round !!");
                AI++;
            }

            if(input == "Rock" && choices[n] == "Scissors") {
                System.Console.WriteLine("Player Wins this round !!");
                Player++;
            }

            if(input == "Scissors" && choices[n] == "Scissors") {
                System.Console.WriteLine("This round is a Tie");
            }

            //===============================================================//

            if(input == "Paper" && choices[n] == "Paper") {
                System.Console.WriteLine("This round is a Tie");
            }

            if(input == "Rock" && choices[n] == "Paper") {
                System.Console.WriteLine("Computer Wins this round !!");
                AI++;
            }

            if(input == "Scissors" && choices[n] == "Paper") {
                System.Console.WriteLine("Player wins this round !!");
                Player++;
            }
            //====================================================================//
            if(input == "Paper" && choices[n] == "Rock") {
                System.Console.WriteLine("Player wins this round !!");
                Player++;
            }

            if(input == "Rock" && choices[n] == "Rock") {
                System.Console.WriteLine("This round is a Tie");
            }

            if(input == "Scissors" && choices[n] == "Rock") {
                System.Console.WriteLine("Computer Wins this round !!");
                AI++;

            }
            round++;
            }
            System.Console.WriteLine("Player has won: " + Player +  " many times !");
            System.Console.WriteLine("Computer has won: " + AI +  " many times !");

            if (Player > AI) {
                System.Console.WriteLine("Computer loses to you..... GG");
            }

            if (Player < AI) {
                System.Console.WriteLine("AHAHAHAHAHAHA... You LOST");
            }

            if (Player == AI) {
                System.Console.WriteLine("Game Tied... GG !");
            }
            return Player;
        }
            static void Main(string[] args) 
            {
            System.Console.WriteLine($"Hey Let's Play Rock Paper Scissors !!!");
            End();


            }
        
        }
    
}
