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
using System.CodeDom;
using System.Reflection;
using System.Collections;
using System.Collections.Concurrent;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        ArrayList l1 = new ArrayList() 
        {
            new BubbleSort<SortedItem>(),
            new KoktailSort<SortedItem>(),
            new InsertSort<SortedItem>(),
            new ShellSort<SortedItem>(),
            new QuickSort<SortedItem>(),
        };

        IList<Label> labels = new List<Label>();
       
        int size = 100;
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();

            labels = new List<Label>() { label4 , label5, label6, label7, label13};
            
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            //Parallel.ForEach(l1.ToArray(),(item)=>
            //{
            //    var index = l1.IndexOf(item);
            //    Type ty = item.GetType();
            //    object x = Activator.CreateInstance(ty);
            //    var items1 = ty.GetMethods();
            //    var setItems = ty.GetMethod("set_Items");
            //    var getItems = ty.GetMethod("get_Items");
            //    var sort = ty.GetMethod("Sort");
            //    setItems.Invoke(x,new object[] { items });

            //    var sw = new Stopwatch();
            //    sw.Start();
            //    sort.Invoke(x, new object[] { });
            //    sw.Stop();

            //    var getRef = getItems.Invoke(x,new object[] { }) as List<SortedItem>;
            //    var label = labels[index];
            //    Action act = () => {
            //        label.Text = GetValues(getRef)+ $" | {sw.ElapsedMilliseconds} мс";
            //        label.Font = new Font("Tobota", 10, FontStyle.Bold);
            //    };
            //    label.Invoke(act);
            //});


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
                label4.Invoke((MethodInvoker)(() => { label4.Text += $" | {sw.ElapsedMilliseconds} мс"; }));
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
                label5.Invoke((MethodInvoker)(() => { { label5.Text += $" | {sw.ElapsedMilliseconds} мс"; } }));
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
                label6.Invoke((MethodInvoker)(() => { label6.Text += $" | {sw.ElapsedMilliseconds} мс"; }));
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

                label7.Invoke((MethodInvoker)(() => { label7.Text += $" | {sw.ElapsedMilliseconds} мс"; }));
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

                label13.Invoke((MethodInvoker)(() => { label13.Text += $" | {sw.ElapsedMilliseconds} мс"; }));
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

        private string GetValues(List<SortedItem> items)
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (var item in items)
            {
                sb.Append(item.Value + "  ");
            };
            return sb.ToString();
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
