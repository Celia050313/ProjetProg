using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestModel.Element.Motion
{
    [TestClass]
    public class TestMotionFactory
    {
        [TestMethod]
        public void TestCreateAssiette()
        {
            var result = MotionFactory.createAssiette();
            Assert.IsInstanceOfType(result, typeof(Assiette));
        }

        [TestMethod]
        public void TestCreateCasserole()
        {
            var result = MotionFactory.createCasserole();
            Assert.IsInstanceOfType(result, typeof(Casserole));
        }

        [TestMethod]
        public void TestCreateCommis()
        {
            var result = MotionFactory.createCommis();
            Assert.IsInstanceOfType(result, typeof(Commis));
        }

        [TestMethod]
        public void TestCreateCorbeille()
        {
            var result = MotionFactory.createCorbeille();
            Assert.IsInstanceOfType(result, typeof(Corbeille));
        }

        [TestMethod]
        public void TestCreateCouverts()
        {
            var result = MotionFactory.createCouverts();
            Assert.IsInstanceOfType(result, typeof(Couverts));
        }

        [TestMethod]
        public void TestCreateCuisinier()
        {
            var result = MotionFactory.createCasserole();
            Assert.IsInstanceOfType(result, typeof(Cuisinier));
        }

        [TestMethod]
        public void TestCreateNappe()
        {
            var result = MotionFactory.createNappe();
            Assert.IsInstanceOfType(result, typeof(Nappe));
        }

        [TestMethod]
        public void TestCreatePlongeur()
        {
            var result = MotionFactory.createPlongeur();
            Assert.IsInstanceOfType(result, typeof(Plongeur));
        }

        [TestMethod]
        public void TestCreateServiette()
        {
            var result = MotionFactory.createServiette();
            Assert.IsInstanceOfType(result, typeof(Serviette));
        }

        [TestMethod]
        public void TestCreateUstensil()
        {
            var result = MotionFactory.createUstensil();
            Assert.IsInstanceOfType(result, typeof(Ustensil));
        }

        [TestMethod]
        public void TestCreateVerre()
        {
            var result = MotionFactory.createVerre();
            Assert.IsInstanceOfType(result, typeof(Verre));
        }
    }
}
