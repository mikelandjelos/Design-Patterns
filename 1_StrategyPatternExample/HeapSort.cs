using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Runtime.Versioning;
using System.Runtime.CompilerServices;

namespace DomaciNiz
{
    internal class HeapSort<T> : ISortStrategy<T>
        where T : IComparable<T>
    {
        public void Sort(T[] arr, int n) 
        {
			Console.WriteLine("Sorting: Heap");
			Heapsort(arr, n);
        }
		public void Heapsort(T[] arr, int n)
		{
			T iValue;

			for (int i = n / 2; i >= 0; i--)
			{
				adjust(arr, i, n - 1);
			}

			for (int i = n - 2; i >= 0; i--)
			{
				iValue = arr[i + 1];
				arr[i + 1] = arr[0];
				arr[0] = iValue;
				adjust(arr, 0, i);
			}
		}

		private void adjust(T[] arr, int i, int n)
		{
			T iPosition;
			int iChange;

			iPosition = arr[i];
			iChange = 2 * i;
			while (iChange <= n)
			{
				if (iChange < n && arr[iChange].CompareTo(arr[iChange + 1]) < 0)
				{
					iChange++;
				}
				if (iPosition.CompareTo(arr[iChange]) >= 0)
				{
					break;
				}
				arr[iChange / 2] = arr[iChange];
				iChange *= 2;
			}
			arr[iChange / 2] = iPosition;
		}
	}
}
