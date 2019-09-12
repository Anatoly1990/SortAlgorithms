using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace SortAlgorithms
{

    public class SortedItem:IComparable
    {
        public int Value { get; set; }
        public SortedItem(int value)
        {
            Value = value;
        }     

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            { return Value.CompareTo(item.Value); }
            else { throw new ArgumentException($"obj is not{nameof(SortedItem)}",nameof(obj)); }
        }
        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
    

    //public class VerticalProgressBar : ProgressBar
    //{
    //    protected override CreateParams CreateParams
    //    {
    //        get
    //        {
    //            CreateParams cp = base.CreateParams;
    //            cp.Style |= 0x04;
    //            return cp;
    //        }
    //    }
    //}


}
