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
        public void StartsGame()
        {
            Console.WriteLine("Your position is " + Position);
        }

        
        public void RandomNumber()
        {
            int Number = number.Next(1, 7);
            Console.WriteLine("\nNumber on Dice " + Number);
            Position += Number;
            StartsGame();
            Option(Number);
            Console.ReadLine();
            StartsGame();
            
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
                    Console.WriteLine("Moves Ahead by " + Number);
                    Position += Number;
                    StartsGame();
                    break;

                case 2:
                    Console.WriteLine("Oh No!! Snake Trap ");
                    Console.WriteLine("Moves Behind by " + Number);
                    Position -= Number;
                    StartsGame();
                    break;

                default:
                    Console.WriteLine("Error!!");
                    break;
            }
        }
       
            public void TillWin()
        {
            while (Position < 100) ;
            RandomNumber();
            Console.WriteLine("\nCongratulations!! You Won!!");
        }
        public void TillWin1()
        {
            while (Position < 100)
                RandomNumber();
            Console.WriteLine("You Won!!");


        }

    }
}
