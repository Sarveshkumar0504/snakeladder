using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderGame
{
    internal class SnakeandLadder
    {
        private int Position = 0;

        
        Random number = new Random();
        Random number1 = new Random();


        public void StartsGame()
        {
            Console.WriteLine("Your position is " + Position);
        }


       
        public void RandomNumber()
        {
            int Number = number.Next(1, 7);
            Position += Number;
            StartsGame();
            Option(Number);
            Console.ReadLine();
        }

        
        public void Option(int Number)
        {
            int OptionForPlay = number.Next(0, 3);

            switch (OptionForPlay)
            {
                case 0:
                    Console.WriteLine("No Play");
                    Console.WriteLine("Your Position is same");
                    break;

                case 1:
                    Console.WriteLine("You Got A Ladder!!");
                    Position += Number;
                    StartsGame();
                    break;

                case 2:
                    Console.WriteLine("Oh No!! Snake Trap ");
                    Position -= Number;
                    StartsGame();
                    break;

                default:
                    Console.WriteLine("Error!!");
                    StartsGame();
                    break;
            }
           }
        }
    }
