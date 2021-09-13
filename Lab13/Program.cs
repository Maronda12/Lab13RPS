using System;
using static Lab13.Player;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Papper Scissors!!");


            bool goOn = true;

            while (goOn == true)
            {

                //Human Player
                RPSApp RPSApp = new RPSApp();
                RPSApp.NewHumanPlayer();



                //gets opponent using method wrote
                Player Opponent = RPSApp.GetOpponent();

                //Human Player chooses rock,paper,scissors
                var humanThrow = RPSApp.HumanPlayer.GenerateRPS();

                //Opponents turn
                var opponentThrow = Opponent.GenerateRPS();



                Console.WriteLine($"You choose: {humanThrow} Computer choose: {opponentThrow}");

                if (humanThrow == Player.RPS.rock && opponentThrow == Player.RPS.rock)
                {
                    Console.WriteLine(" ITS A DRAW!!");

                }
                else if (humanThrow == Player.RPS.rock && opponentThrow == Player.RPS.paper)
                {
                    Console.WriteLine("Computer Wins!");
                }
                else if (humanThrow == Player.RPS.rock && opponentThrow == Player.RPS.scissors)
                {
                    Console.WriteLine("You Won!");
                }
                else if (humanThrow == Player.RPS.paper && opponentThrow == Player.RPS.rock)
                {
                    Console.WriteLine("You Won!");
                }
                else if (humanThrow == Player.RPS.paper && opponentThrow == Player.RPS.paper)
                {
                    Console.WriteLine(" ITS A DRAW!!");

                }
                else if (humanThrow == Player.RPS.paper && opponentThrow == Player.RPS.scissors)
                {
                    Console.WriteLine("Computer Wins!");
                }
                else if (humanThrow == Player.RPS.scissors && opponentThrow == Player.RPS.rock)
                {
                    Console.WriteLine("Computer Wins!");
                }
                else if (humanThrow == Player.RPS.scissors && opponentThrow == Player.RPS.paper)
                {
                    Console.WriteLine("You Won!");
                }
                else if (humanThrow == Player.RPS.scissors && opponentThrow == Player.RPS.scissors)
                {
                    Console.WriteLine("ITS A DRAW!!");

                }

                //Continue
                while (true)
                {
                    Console.WriteLine("Would you like to continue? yes/no");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        goOn = true;
                        break;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                        break;
                    }


                }
            }
        }
    }
}
