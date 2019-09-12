using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {

        public List<T> Items { get; set; } = new List<T>();

        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }
        public AlgorithmBase() { }
        protected void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;                
            }
        }     
        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
