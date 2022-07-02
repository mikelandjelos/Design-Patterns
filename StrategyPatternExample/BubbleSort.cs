using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciNiz
{
    internal class BubbleSort<T> : ISortStrategy<T>
        where T : IComparable<T>
    {
        public void Sort(T[] arr, int n)
        {
            Console.WriteLine("Sorting: Bubble");
            Bubblesort(arr, n);
        }
        private void Bubblesort(T[] arr, int n) 
        {
            while (true)
            {
                bool performedSwap = false;
                for (int currentItemIndex = 1; currentItemIndex < n; currentItemIndex++)
                {
                    int previousItemIndex = currentItemIndex - 1;
                    T previousItem = arr[previousItemIndex];
                    T currentItem = arr[currentItemIndex];
                    var comparison = previousItem.CompareTo(currentItem);
                    if (comparison > 0)
                    {
                        arr[previousItemIndex] = currentItem;
                        arr[currentItemIndex] = previousItem;
                        performedSwap = true;
                    }
                }
                if (!performedSwap)
                    break;
            }
        }
    }
}
