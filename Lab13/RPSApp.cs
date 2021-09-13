using System;
using System.Linq;
using System.Collections.Generic;
using static Lab13.Player; // allows us to use info from player class

namespace Lab13
{
    public class RPSApp
    {
        public HumanPlayer HumanPlayer;

        public void NewHumanPlayer()
        {
            HumanPlayer = new HumanPlayer();
        }


        //human chooses rock or random

        public static Player GetOpponent()
        {
            Console.WriteLine("Please select either Rock or Random");

            string humanInput = Console.ReadLine().ToLower();

            if (humanInput == "rock")
            {
                return new RockPlayer();
            }
            else if (humanInput == "random")
            {
                return new RandomPlayer();
            }
            else
            {
                Console.WriteLine("Invalid entry, try again");
                return GetOpponent();
                
            }
        }
    }
}
