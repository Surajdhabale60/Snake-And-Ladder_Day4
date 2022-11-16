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
        public const int Noplay = 0, Ladder = 1, Snake = 2;

        Random random = new Random();
        public int initialPosition = 0;

        public void RollDie()
        {
            Random random = new Random();
            int Diecount = random.Next(1, 6);
            Console.WriteLine("Die Count is: " + Diecount);
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
                case Snake:
                    PlayerPosition -= 0;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                default:
                    Console.WriteLine("invalid data");
                    break;
            }
        }
        public int RollDice()
        {
            int Dicecount = random.Next(1, 6);
            return Dicecount;

        }

        public void Position()
        {
            int choice = random.Next(0, 3);
            while (PlayerPosition <= 100)
            {
                switch (choice)
                {
                    case Noplay:
                        PlayerPosition += 0;
                        break;
                    case Ladder:
                        PlayerPosition += RollDice();
                        break;
                    case Snake:
                        PlayerPosition -= RollDice();
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("invalid data");
                        break;
                }
                Console.WriteLine(PlayerPosition);

            }

        }
    }
}
