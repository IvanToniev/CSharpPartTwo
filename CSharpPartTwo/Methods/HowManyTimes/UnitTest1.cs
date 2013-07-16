using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HowManyTimes;
using HowManyTimesDoesItAppear;
namespace HowManyTimes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            Assert.AreEqual(3,HowManyTimess.HowMany(4));
        }
    }
}
