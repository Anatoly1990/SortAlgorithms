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
        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwapEvent;
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
                SwapEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
            }
        }     
        public virtual void Sort() { Items.Sort(); } 
        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this , new Tuple<T, T>(a,b));
            return a.CompareTo(b);
        }
    }
}
