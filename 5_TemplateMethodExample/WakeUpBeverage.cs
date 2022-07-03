using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternMyExample
{
    internal abstract class WakeUpBeverage
    {

        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public void BoilWater()
            => Console.WriteLine("Boiling water.");

        public abstract void Brew();

        public void PourInCup()
            => Console.WriteLine("Pouring beverage into a cup.");

        public abstract void AddCondiments();

    }
}
