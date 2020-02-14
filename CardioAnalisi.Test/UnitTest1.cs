using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardioAnalisi.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int risultatoaspettato = 140;
            int eta = 20;
            int risultato = ClassLibraryCardioAnalisi.Class1.Battitimin(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestMethod2()
        {
            int risultatoaspettato = 180;
            int eta = 20;
            int risultato = ClassLibraryCardioAnalisi.Class1.Battitimax(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestMethod3()
        {
            bool risultatoaspettato = true;
            int battiti = 75;
            bool risultato = ClassLibraryCardioAnalisi.Class1.Normale(battiti);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
    }
}
