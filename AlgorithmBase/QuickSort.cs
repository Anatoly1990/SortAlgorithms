using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmBase
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort(IComparable<T> items) { }
        public QuickSort() { }
        public override void Sort()
        {
            Qsort(0, Items.Count - 1);
        }
        private void Qsort(int left, int right)
        {
            if (left>=right)
            {
                return;
            }
            var pivot = Sorting(left, right);
            Qsort(left, pivot-1);
            Qsort(pivot+1, right);
        }
        private int Sorting(int left, int right)
        {
            var pointer = left;
            //опорный элемент находится по right - итератором
            for (int i = left; i <= right; i++)
            {
               
                if (Items[i].CompareTo(Items[right]) == -1)
                {
                    Swap(pointer,i);
                    pointer++;
                }
            }
            Swap(pointer, right);
            return pointer;
            
        }
    }
}
