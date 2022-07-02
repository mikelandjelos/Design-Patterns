using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciNiz
{
    internal class SortedArray
    {
        int[] arr;
        int n;
        private ISortStrategy<int> sorter;

        public SortedArray(int n, ISortStrategy<int> sorter = null) {
            this.sorter = sorter;
            this.n = n;
            arr = new int[n];
        }

        public void Randomize() { 
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rand.Next() % 100 - 50;
        }

        // write-only
        public ISortStrategy<int> Sorter {
            set { sorter = value; }
        }

        public void Sort() {
            sorter.Sort(arr, n);
        }

        public override string ToString()
        {
            string ret = "[ ";
            foreach (int i in arr)
                ret = ret + i.ToString() + " ";
            return ret + "]";
        }

    }
}
