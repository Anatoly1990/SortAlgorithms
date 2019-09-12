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
        public VerticalProgressBar progressbar { get; set; }
        public Label label { get; set; }
        public int Value { get; set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            var x = number * 22;
            progressbar = new VerticalProgressBar();
            progressbar.Location = new Point(10 +x, 5);
            progressbar.Size = new Size(20, 105);
            progressbar.Name = "ProgressBar" + number;
            progressbar.Value = Value;
            //items.Add(value);
            //---------------
            label = new Label();
            label.Size = new Size(20, 13);
            label.Location = new Point(11+x, 110);
            label.Name = "Label" + number;
            label.Text = Value.ToString();
        }
        public void SetPosition(int value)
        {
            Value = value;
            progressbar.Value = value;
            label.Text = Value.ToString();
        }
        public void SetColor(Color color)
        {
            progressbar.BackColor = color;
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
    

    public class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }


}
