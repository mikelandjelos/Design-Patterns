using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedArray a = new SortedArray(20);

            // bubble
            a.Randomize();
            Console.WriteLine("Pre sortiranja: " + a);

            a.Sorter = new BubbleSort<int>();
            a.Sort();
            Console.WriteLine("Bubble: " + a);

            // heap
            a.Randomize();
            Console.WriteLine("Pre sortiranja: " + a);

            a.Sorter = new HeapSort<int>();
            a.Sort();
            Console.WriteLine("Heap: " + a);

            // qsort
            a.Randomize();
            Console.WriteLine("Pre sortiranja: " + a);

            a.Sorter = new QSort<int>();
            a.Sort();
            Console.WriteLine("Quick: " + a);


        }
    }
}
