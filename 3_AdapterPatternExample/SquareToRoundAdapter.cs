using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternMyExample
{
    internal class SquareToRoundAdapter : RoundShape
    {

        private SquareShape squareShape;

        public SquareToRoundAdapter(SquareShape _squareShape)
        {
            squareShape = (_squareShape == null) ?
                new SquareShape() : _squareShape;
        }

        /// <summary>
        /// Radius of square's excircle.
        /// </summary>
        public override double Radius
        {
            get => squareShape.SideLength * Math.Sqrt(2d) / 2d;
        }

    }
}
