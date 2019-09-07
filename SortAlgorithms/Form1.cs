using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm;
using AlgorithmBase;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }
        ProgressBar pr;
        Label lb;
        AlgorithmBase<int> algorithm = new BubbleSort<int>();

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
        private void button1_Click(object sender, EventArgs e)
        {          
            var rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                pr = new VerticalProgressBar();
                pr.Location = new Point(10 + (25 * i), 5);
                pr.Size = new Size(20, 105);
                Controls.Add(pr);

                var value = rnd.Next(0, 100);
                algorithm.Items.Add(value);
                pr.Value = value;              
                //---------------
                lb = new Label();
                lb.Location = new Point(11 + (25 * i), 110);
                lb.Text = $"{value}";
                lb.Size = new Size(20, 13);
                Controls.Add(lb);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            algorithm.Sort();
            foreach (var item in algorithm.Items)
            {
                pr.Value = item;
                lb.Text = $"{item}";
            }
        }
    }
}
