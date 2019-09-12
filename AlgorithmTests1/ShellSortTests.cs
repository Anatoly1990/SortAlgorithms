using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBase.Tests
{
    [TestClass()]
    public class ShellSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrenge
            var shell = new ShellSort<int>();
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            shell.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();//стадартная сортировка List
            //act
            shell.Sort();
            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], shell.Items[i]);
            }
        }
    }
}