using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmBase
{
   public class KoktailSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public KoktailSort(IEnumerable<T> items) { }
        public KoktailSort() { }
        public override void Sort()
        {
            var left = 0;
            var right = Items.Count()-1;
            int i, j;
            while (left<right)
            {
                for (i=left; i<right;i++)
                {
                    if (Items[i].CompareTo(Items[i+1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;
                for (j=right;j>left;j--) 
                {
                    if (Items[j].CompareTo(Items[j-1]) == -1)
                    {
                        Swap(j, j - 1);
                    }
                }
                left++;
            }                     
            
        }

    }
}
