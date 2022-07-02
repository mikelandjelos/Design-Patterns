using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternMyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LoadBalancer.Instance.NewServer = "Server1";
            LoadBalancer.Instance.NewServer = "Server2";
            LoadBalancer.Instance.NewServer = "Server3";
            LoadBalancer.Instance.NewServer = "Server4";

            LoadBalancer instance1 = LoadBalancer.Instance;
            LoadBalancer instance2 = LoadBalancer.Instance;

            Console.WriteLine(LoadBalancer.Instance.RandomServer);
            Console.WriteLine((instance1 == instance2) 
                ? "same instance" : "different instances");

        }
    }
}
