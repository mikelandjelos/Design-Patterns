using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciNiz
{
    internal interface ISortStrategy <T>
        where T : IComparable<T>
    {
        void Sort(T[] arr, int n);
    }
}
