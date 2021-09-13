using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab13
{



    //Abstract Class
    public abstract class Player
    {


        //create a enumeration
        public enum RPS
        {
            rock,
            paper,
            scissors
        }

        //stores name property
        
        public string Name
        {
            get; set;
        }

        //Abstract Method
        public abstract RPS GenerateRPS();



        //3 Player Subclasses*


        //Always throws rock
        public class RockPlayer : Player
        {
            public override RPS GenerateRPS()
            {
                return RPS.rock;
                 
            }
        }

        //Picks & throws at random
        public class RandomPlayer : Player
        {
            public override RPS GenerateRPS()
            {
                var randomThrow = new Random();
                randomThrow.Next(0, 3);
                return (RPS)randomThrow.Next(0, 3);

            }
        }
        
        public class HumanPlayer : Player
        {

            //allow user to add name
            public HumanPlayer()
            {
                Console.WriteLine("Enter your name");
                Name = Console.ReadLine();
            }
            //user select & throw. 
            public override RPS GenerateRPS()
            {
                Console.WriteLine("Rock, Paper, or Scissors?");
                string input = Console.ReadLine().ToLower();


                if (input == "rock")
                {
                    return RPS.rock;
                }

                else if (input == "paper")
                {
                    return RPS.paper;
                }

                else if (input == "scissors")
                {
                    return RPS.scissors;
                }
 
                else
                {
                    Console.WriteLine("Invalid. Try again");
                    return GenerateRPS();
                }


            }
            
        }
    }
}