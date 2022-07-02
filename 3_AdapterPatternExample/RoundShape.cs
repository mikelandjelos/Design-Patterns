using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternMyExample
{
    internal class RoundShape
    {

        private double radius;

        public RoundShape(double _radius = -1d)
            => radius = _radius;

        public virtual double Radius
        { get => radius; set => radius = value; }

    }
}
