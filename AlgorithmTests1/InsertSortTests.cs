﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBase.Tests
{
    [TestClass()]
    public class InsertSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrenge
            var insert = new InsertSort<int>();
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            insert.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();//стадартная сортировка List
            //act
            insert.Sort();
            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], insert.Items[i]);
            }
        }
    }
}