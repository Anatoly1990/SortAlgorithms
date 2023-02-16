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
using System.Diagnostics;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        int size = 1000;
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }   

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var sw = new Stopwatch();
                var bubble = new BubbleSort<SortedItem>();
                bubble.Items.AddRange(items);
                sw.Start();
                bubble.Sort();
                sw.Stop();
                foreach (var i in bubble.Items)
                {
                    SetProperty(label4, i);
                }
                Action act = () => { label4.Text += $" | {sw.ElapsedMilliseconds} мс"; };
                label4.Invoke(act);
            }).ConfigureAwait(false);

            //----------------
            await Task.Run(() =>
            {
                var sw = new Stopwatch();
                var coctail = new KoktailSort<SortedItem>();
                coctail.Items.AddRange(items);
                sw.Restart();
                coctail.Sort();
                sw.Stop();
                foreach (var i in coctail.Items)
                {
                    SetProperty(label5, i);
                }
                Action act = () => { label5.Text += $" | {sw.ElapsedMilliseconds} мс"; };
                label5.Invoke(act);
            }).ConfigureAwait(false);

            //-----------------
            await Task.Run(() =>
            {
                var sw = new Stopwatch();
                var insert = new InsertSort<SortedItem>();
                insert.Items.AddRange(items);
                sw.Restart();
                insert.Sort();
                sw.Stop();
                foreach (var i in insert.Items)
                {
                    SetProperty(label6, i);
                }
                Action act = () => { label6.Text += $" | {sw.ElapsedMilliseconds} мс"; };
                label6.Invoke(act);
            }).ConfigureAwait(false);

            //----------------------
            await Task.Run(() =>
            {
                var sw = new Stopwatch();
                var shell = new ShellSort<SortedItem>();
                shell.Items.AddRange(items);
                sw.Restart();
                shell.Sort();
                sw.Stop();
                foreach (var i in shell.Items)
                {
                    SetProperty(label7, i);
                }

                Action act = () => { label7.Text += $" | {sw.ElapsedMilliseconds} мс"; };
                label7.Invoke(act);
            }).ConfigureAwait(false);
            //----------------------
            await Task.Run(() =>
            {
                var sw = new Stopwatch();
                var quick = new QuickSort<SortedItem>();
                quick.Items.AddRange(items);
                sw.Restart();
                quick.Sort();
                sw.Stop();
                foreach (var i in quick.Items)
                {
                    SetProperty(label13, i);
                }

                Action act = () => { label13.Text += $" | {sw.ElapsedMilliseconds} мс"; };
                label13.Invoke(act);
            }).ConfigureAwait(false);

            items.Clear();
        }      

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label13.Text = "";

            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                var val = rnd.Next(0, size);
                var item = new SortedItem(val);
                items.Add(item);
                SetProperty(label3, item);
            }
        }
        private void SetProperty(Label lb, SortedItem value)
        {
            Action addParam = () => {
                lb.Text += "  " + value;
                lb.Font = new Font("Tobota", 10, FontStyle.Bold);
            };

            lb.Invoke(addParam);        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label13.Text = "";

            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                var val = rnd.Next(0, size);
                var item = new SortedItem(val);
                items.Add(item);
                SetProperty(label3, item);
            }
        }
    }
}
