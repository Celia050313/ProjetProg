using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Map;

namespace TestProjetModel_2
{
    [TestClass]
    public class UnitTest1
    {
        private string a="1";
        private string b="1";
        private int test = 0;
        private int retest = 0;
        private int wd = Model.Map.getWidth();

        [TestMethod]

       // public void TestdeBase() => Assert.AreEqual(a, b);

        public void TestMapGetWidth() => Assert.AreEqual(a,wd);

        public void TestMethod1()
        {
            Assert.Fail();
        }

        public void TestMethod2()
        {
            Assert.Fail();
        }

        public void TestMethod3()
        {
            Assert.Fail();
        }

    }
}
