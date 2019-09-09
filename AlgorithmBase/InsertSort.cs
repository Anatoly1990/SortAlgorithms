using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmBase
{
    public class InsertSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;
            int i, j;
            for (j = 0; j < count-1; j++)
            {
                for (i = 1; i < count-j; i++)
                {
                    var a = Items[i-1];
                    if (a.CompareTo(Items[i]) == 1)
                    {                      
                        //Items[i - 1] = Items[i];
                        //Items[i] = a;
                        Swap(i-1,i);
                    }                   
                }
            }
        }
    }
}
