using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciNiz
{
    internal class QSort<T> : ISortStrategy<T>
        where T : IComparable<T>
    {

        public void Sort(T[] arr, int n) {
            Console.WriteLine("Sorting: QSort");
            QuickSort(arr, n);
        }

        private static void QuickSort(T[] list, int n)
        {
            QuickSortInternal(list, 0, n - 1);
        }

        private static void QuickSortInternal(T[] list, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int partition = PartitionInternal(list, left, right);

            QuickSortInternal(list, left, partition - 1);
            QuickSortInternal(list, partition + 1, right);
        }

        private static int PartitionInternal(T[] list, int left, int right)
        {
            T partition = list[right];

            // stack items smaller than partition from left to right
            int swapIndex = left;
            for (int i = left; i < right; i++)
            {
                T item = list[i];
                if (item.CompareTo(partition) <= 0)
                {
                    list[i] = list[swapIndex];
                    list[swapIndex] = item;

                    swapIndex++;
                }
            }

            // put the partition after all the smaller items
            list[right] = list[swapIndex];
            list[swapIndex] = partition;

            return right;
        }
    }
}
