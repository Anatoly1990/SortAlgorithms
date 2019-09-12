using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm;
using AlgorithmBase;
using SortAlgorithms;

namespace SortAlgorithms

{

    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }   

        private void button2_Click(object sender, EventArgs e)
        {           
            var rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                var val = rnd.Next(0, 100);
                var item = new SortedItem(val);
                items.Add(item);
                SetProperty(label3, item);
            }
            Thread.Sleep(500);
            //---------------
            var bubble = new BubbleSort<SortedItem>();
            bubble.Items.AddRange(items);
            bubble.Sort();
            foreach (var i in bubble.Items)
            {
                SetProperty(label4, i);
            }
            Thread.Sleep(500);
            //----------------
            var coctail = new KoktailSort<SortedItem>();
            coctail.Items.AddRange(items);
            coctail.Sort();
            foreach (var i in coctail.Items)
            {
                SetProperty(label5, i);
            }
            Thread.Sleep(500);
            coctail.Items.Clear();
            //-----------------
            var insert = new InsertSort<SortedItem>();
            insert.Items.AddRange(items);
            insert.Sort();
            foreach (var i in insert.Items)
            {
                SetProperty(label6, i);
            }
            Thread.Sleep(500);
            //----------------------
            var shell = new ShellSort<SortedItem>();
            shell.Items.AddRange(items);
            shell.Sort();
            foreach (var i in shell.Items)
            {
                SetProperty(label7, i);
            }           
            Thread.Sleep(500);
            //----------------------
            items.Clear();

        }      

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }
        private void SetProperty(Label lb, SortedItem value)
        {
            lb.Text += "  " + value;
            lb.Font = new Font("Tobota", 10, FontStyle.Bold);          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }
    }
}
