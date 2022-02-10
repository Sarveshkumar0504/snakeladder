using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Game");
            SnakeandLadder snake = new SnakeandLadder();
            snake.StartsGame();
            snake.RandomNumber();
            Console.ReadLine();
        }
    }
}
