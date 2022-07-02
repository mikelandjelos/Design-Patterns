using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternMyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RoundShape roundShape = new RoundShape(5d);
            SquareShape squareShape1 = new SquareShape(50d);
            SquareShape squareShape2 = new SquareShape(3d);

            RoundHole roundHole = new RoundHole(5d);

            Console.WriteLine(roundHole.CanFit(roundShape));
            Console.WriteLine(roundHole.CanFit(
                new SquareToRoundAdapter(squareShape1)));
            Console.WriteLine(roundHole.CanFit(
                new SquareToRoundAdapter(squareShape2)));

        }
    }
}
