using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmBase
{
    public class BubbleSort<T>:AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;
            int i, j;
            for (j = 0; j < count; j++)
            {
                for (i = 0; i < count - 1-j; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (a.CompareTo(b) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}
