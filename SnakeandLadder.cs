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
            Console.WriteLine("Game Starts Now");
            Console.WriteLine("You are position is " + Position);
            Console.WriteLine("You are position is " + Position);
        }

        public void RandomNumber()
        {
            int Number = number.Next(1, 7);
            Position += Number;
            StartsGame();
            Console.ReadLine();
        }



    }
}
