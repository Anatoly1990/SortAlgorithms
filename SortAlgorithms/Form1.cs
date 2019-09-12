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
        SortedItem item;
        public Form1()
        {
            InitializeComponent();
        }      
        public void ShowControls()
        {
            var rnd = new Random();           
            for (int i = 0; i < 24; i++)
            {
                var val = rnd.Next(0, 100);
                item = new SortedItem(val, items.Count);
                items.Add(item);
                panel1.Controls.Add(item.progressbar);
                panel1.Controls.Add(item.label);
            }            
        }
        public void ClearControls()
        {
            (item.progressbar as Control).Dispose();
            Controls.Remove(item.progressbar as Control);
            (item.label as Control).Dispose();
            Controls.Remove(item.label as Control);
        }
        //-----------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {            
            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwapEvent += Bubble_SwapEvent;
            bubble.Sort();
        }

        private void Bubble_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Value;
            //e.Item2.SetValue();
            panel1.Refresh();
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Blue);
            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControls();
        } 
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }

    //---------------------
   
}
