using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class Game
    {
        public int PlayerPosition = 0;
        public const int Noplay = 0, Ladder = 1, Snakee = 2;

        Random random = new Random();
        public int initialPosition = 0;

        public void RollDie()
        {
            Random random = new Random();
            int Dicecount = random.Next(1, 6);
            Console.WriteLine("Dice Count is: " + Dicecount);
        }
        public void CheckOption()
        {
            int choice = random.Next(0, 3);
            switch (choice)
            {
                case Noplay:
                    PlayerPosition += 0;
                    Console.WriteLine("player is at same place");
                    break;
                case Ladder:
                    PlayerPosition += 0;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                case Snakee:
                    PlayerPosition -= 0;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                default:
                    Console.WriteLine("invalid data");
                    break;
            }
        }
    }
}
