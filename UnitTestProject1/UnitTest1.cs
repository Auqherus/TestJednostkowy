using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xyz;

namespace PeselUnitTest
{
    [TestClass]
    public class PeselWalidator
    {

        PESELWalidator walidator;
        [TestInitialize]
        public void PrzygotujWalidator()
        {
            walidator = new PESELWalidator("91050421017");
        }

        [TestMethod] 
        public void TestMethod1()
        {
            string pl = "Kobieta";
            string sprawdzam = walidator.Plec(pl);
            Assert.AreEqual("Kobieta", pl);

        }
        [TestMethod]
        public void TestMethod2()
        {
            bool sprtest = walidator.SprawdzPesel();
            Assert.IsTrue(true,"prawdziwe, gdy jest false!");
        }
        [TestMethod]
        public void TestMethod3()
        {
            string pesel1="test2";
            string pesel = "test2";
            walidator.WczytajPesel(pesel);
            Assert.AreEqual(pesel1, pesel);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int sprtest = walidator.SumaKontrolna();
            Assert.AreEqual(0,0,"powinno wyjsc 0");
        }

        [TestMethod]
        public void TestMethod5()
        {
            string sprtest = walidator.DataUrodzenia();
            Assert.AreEqual(0, 0, "powinno wyjsc 0");
        }
    }
}
