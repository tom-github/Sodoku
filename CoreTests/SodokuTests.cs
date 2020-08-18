using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Core.Tests
{
    [TestClass()]
    public class SodokuTests
    {

        [TestMethod()]
        public void GenerateTest()
        {
            Sodoku sodoku = new Sodoku();

            ArrayList arrayList = new ArrayList();
            int sum = 0;

            while (arrayList.Count < 9)
            {
                int number = sodoku.Generate();

                if (!arrayList.Contains(number))
                    arrayList.Add(number);
            }

            foreach (int number in arrayList)
            {
                sum += number;
            }

            Assert.IsTrue(sum == 45);
        }

        [TestMethod()]
        public void SetTest()
        {
            Sodoku sodoku = new Sodoku();
            //sodoku.Set();

            Assert.IsTrue(true);
            
        }
    }
}