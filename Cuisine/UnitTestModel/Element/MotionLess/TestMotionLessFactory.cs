using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestModel.Element.MotionLess
{
    [TestClass]
    public class TestMotionLessFactory
    {
        [TestMethod]
        public void TestCreateChefDeCuisine()
        {
            var result = MotionLessFactory.createChefDeCuisine();
            Assert.IsInstanceOfType(result, typeof(ChefDeCuisine));
        }
    }
}
