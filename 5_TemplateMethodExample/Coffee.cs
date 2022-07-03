using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternMyExample
{
    internal class Coffee : WakeUpBeverage
    {
        public override void AddCondiments()
        {
            AddMilk();
            AddSugar();
        }

        public override void Brew()
            => AddCoffeeBeans();

        public void AddCoffeeBeans()
            => Console.WriteLine("Adding coffee beans.");

        public void AddSugar()
            => Console.WriteLine("Adding sugar.");

        public void AddMilk()
            => Console.WriteLine("Adding milk.");

    }
}
