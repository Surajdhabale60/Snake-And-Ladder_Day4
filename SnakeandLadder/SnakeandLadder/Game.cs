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
            int Diecount = random.Next(1, 6);
            Console.WriteLine("Die Count is:" + Diecount);
        }
    }
    
}
