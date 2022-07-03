using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternMyExample
{
    internal class Tea : WakeUpBeverage
    {
        public override void AddCondiments()
            => AddLemon();

        public override void Brew()
            => AddTeaBag();

        public void AddLemon()
            => Console.WriteLine("Adding lemon.");

        public void AddTeaBag()
            => Console.WriteLine("Adding tea bag.");

    }
}
