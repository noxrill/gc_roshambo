using System;
using System.Collections.Generic;

namespace RPS
{
    public enum Roshambo
    {
        Rock,
        Paper,
        Scissors,
    }

    abstract class Player
    {
        public string name;
        public Roshambo choice;

        public virtual Roshambo GenRoshambo()
        {
            return Roshambo.Paper; /// Placeholder
        }

        class Rock : Player
        {
            public override Roshambo GenRoshambo()
            {
                return Roshambo.Rock;
            }

        }

        class RPS : Player
        {
            public override Roshambo GenRoshambo()
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 3);
                choice = (Roshambo)num;
                return choice;
            }



        }

        class HumanPlayer : Player
        {
            public override Roshambo GenRoshambo()
            {
                // Prompt the user for for an entry
                Console.WriteLine("Please enter R P S ");
                string input = Console.ReadLine().ToLower();
                if (input == "r")
                {
                    choice = Roshambo.Rock;
                    return Roshambo.Rock;
                }
                else if (input == "p")
                {
                    choice = Roshambo.Paper;
                    return Roshambo.Paper;
                }
                else
                {
                    choice = Roshambo.Scissors;
                    return Roshambo.Scissors;
                }
            }
        }
        class Program
        {
            static void Play(Player Left, Player Right)   /// Logic for PLAY 
            {
                if (Left.choice == Right.choice)
                {
                    Console.WriteLine("It's a tie!");
                }

                else if (Left.choice == Roshambo.Paper && Right.choice == Roshambo.Rock)
                {
                    Console.WriteLine("Paper beats rock! User win!");
                }

                else if (Left.choice == Roshambo.Paper && Right.choice == Roshambo.Scissors)
                {
                    Console.WriteLine("Scissors beats Paper, User loss :( ");
                }

                else if (Left.choice == Roshambo.Rock && Right.choice == Roshambo.Paper)
                {
                    Console.WriteLine("Paper beats rock, User Loss");
                }

                else if (Left.choice == Roshambo.Rock && Right.choice == Roshambo.Scissors)
                {
                    Console.WriteLine("Rock beats Scissors! User win!");
                }

                else if (Left.choice == Roshambo.Scissors && Right.choice == Roshambo.Paper)
                {
                    Console.WriteLine("Scissors beats paper! User win!");
                }
                else if (Left.choice == Roshambo.Scissors && Right.choice == Roshambo.Rock)
                {
                    Console.WriteLine("Rock beats Scissors, User loss");
                }
            }

            // How do I get selected choices to play? 
            public static void SetGame(string thisWhoPlay)
            {

                HumanPlayer player1 = new HumanPlayer();
                Rock rocky = new Rock();
                RPS Rudzki = new RPS();



                if (thisWhoPlay == "rocky")
                {
                    player1.GenRoshambo();
                    Play(player1, rocky);
                }
                else
                {
                    player1.GenRoshambo();
                    Play(player1, Rudzki);
                }

            }

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Rock Paper Scissors!");
                Console.WriteLine("Who do you wanna play?");
                Console.WriteLine("rocky or Rudzki");
                string whoplay = Console.ReadLine();
                SetGame(whoplay);








                Console.Read();

            }
        }
    }
}
