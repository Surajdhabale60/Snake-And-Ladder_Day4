using System.Xml.Linq;

namespace SnakeandLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Initial Position is {0}", game.initialPosition);
        }
    }
}