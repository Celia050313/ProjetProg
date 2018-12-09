using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFactory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public void FactoryMotionLessLaveVaisselle()
        {
            MotionLessFactory factory = new MotionLessFactor();
            string input = "LaveVaisselle";
            bool test = false;

            object obj = factory.FactoryMethod(input);

            if (obj is LaveVaisselle)
            {
                test = true;
            }
            Assert.IsTrue(test);
        }
    }
}
