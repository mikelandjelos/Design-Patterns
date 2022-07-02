using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternMyExample
{
    internal class RoundHole
    {

        private double radius;

        public RoundHole(double _radius = -1)
            => radius = _radius;

        public bool CanFit(RoundShape roundShape)
            => radius >= roundShape.Radius && 
            roundShape.Radius >= 0;

    }
}
