using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternMyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WakeUpBeverage beverage = new Coffee();

            Console.WriteLine("Preparing coffee:\n");
            beverage.PrepareBeverage();

            beverage = new Tea();

            Console.WriteLine("\nPreparing tea:\n");
            beverage.PrepareBeverage();

        }
    }
}
