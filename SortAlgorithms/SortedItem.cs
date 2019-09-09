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

    public class SortedItem
    {
        public VerticalProgressBar progressbar { get; set; }
        public Label label { get; set; }
        public int Value { get; set; }
        public SortedItem(int value)
        {
            Value = value;
            progressbar = new VerticalProgressBar();
            progressbar.Location = new Point(10 , 5);
            progressbar.Size = new Size(20, 105);
            //progressbar.Name = "ProgressBar";
            //Controls.Add(pr);
            progressbar.Value = Value;
            //items.Add(value);
            //---------------
            label = new Label();
            label.Size = new Size(20, 13);
            label.Location = new Point(11, 110);
            //label.Name = "Label" + number;
            label.Text = Value.ToString();

            //for (int i = 0; i < 20; i++)
            //{
            //    progressbar = new VerticalProgressBar();
            //    progressbar.Location = new Point(10 + (25 * i), 5);
            //    progressbar.Size = new Size(20, 105);
            //    //Controls.Add(pr);
            //    progressbar.Value = Value;
            //    //items.Add(value);
            //    //---------------
            //    label = new Label();
            //    label.Size = new Size(20, 13);
            //    label.Location = new Point(11 + (25 * i), 110);
            //    label.Text = Value.ToString();
            //    //Controls.Add(lb);
            //}
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
