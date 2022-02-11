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
        private bool WinningCheck = false;
        private bool WinningCheck = false;
        private int TotalDieRoll = 0;

        
        Random number = new Random();
        public void StartsGame()
        {
            Console.WriteLine("Your position is " + Position);
        }

        
        public void RandomNumber()
        {
            TotalDieRoll++;
            int CheckContinue = 0;
            int Number = number.Next(1, 7);
            Console.WriteLine("\nNumber on Dice " + Number);
            if (WinningCheck is false)
                CheckContinue = MovePlayer(Number);
            if (WinningCheck is false && CheckContinue == 1)
                Option(Number);
            StartsGame();
        }
        
        public void Option(int Number)
        {
            int OptionForPlay = number.Next(0, 3);
            switch (OptionForPlay)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("You Got A Ladder!!");
                    Console.WriteLine("Moves Ahead by " + Number);
                    Position += Number;
                    break;
                case 2:
                    Console.WriteLine("Oh No!! Snake Trap ");
                    Console.WriteLine("Moves Behind by " + Number);
                    Position -= Number;
                    break;
                default:
                    Console.WriteLine("Error!!");
                    break;
            }
        }
        private int Check(int displacement)
        {
            if (Position < 0)
            {
                Position = 0;
                return 0;
            }
            else if (Position > 100)
            {
                Position -= displacement;
                Console.WriteLine("Oops! Your Position Is More Than 100");
                Console.WriteLine("You are moved Behind to previous position");
                return 0;
            }
            else
                return 1;
        }
        private int MovePlayer(int displacement)
        {
            Position += displacement;
            if (Position == 100)
            {
                WinningCheck = true;
                return 0;
            }
            return Check(displacement);
        }
        
        public void TillWin()
        {
            while (Position < 100)
                RandomNumber();
            Console.WriteLine("You Won!!");


        }

        public void Win()
        {
            while (WinningCheck is false)
                RandomNumber();
            Console.WriteLine("Die was rolled " + TotalDieRoll + " times");

        }


    }

}
}
