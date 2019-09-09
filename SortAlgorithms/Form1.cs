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
            var val = rnd.Next(0, 100);
            item = new SortedItem(val);
            items.Add(item);
            panel1.Controls.Add(item.progressbar);
            panel1.Controls.Add(item.label);
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
            ShowControls();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {          
        } 
        private void button3_Click(object sender, EventArgs e)
        {
            ShowControls();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ClearControls();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowControls();
        }
    }

    //---------------------
   
}
