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
    public class QuickSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrenge
            var quick = new QuickSort<int>();
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            quick.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();//стадартная сортировка List
            //act
            quick.Sort();
            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], quick.Items[i]);
            }
        }
    }
}