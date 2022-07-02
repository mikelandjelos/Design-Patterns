using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternMyExample
{
    internal class SquareShape
    {

        private double sideLength;

        public SquareShape(double _width = -1d)
            => sideLength = _width;

        public double SideLength 
        { get => sideLength; set => sideLength = value; }

    }
}
