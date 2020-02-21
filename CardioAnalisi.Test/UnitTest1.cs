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
            int risultato = ClassCardioAnalisi.ClasseCardio.Battitimin(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestMethod2()
        {
            int risultatoaspettato = 180;
            int eta = 20;
            int risultato = ClassCardioAnalisi.ClasseCardio.Battitimax(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestMethod3()
        {
            bool risultatoaspettato = true;
            int battiti = 75;
            bool risultato = ClassCardioAnalisi.ClasseCardio.Normale(battiti);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestMethod4()
        {
            double risultatoaspettato = 60;
            int anni = 16;
            int battitiriposo = 100;
            int peso = 70;
            int temp = 10;
            double risultato = ClassCardioAnalisi.ClasseCardio.CalorieUomo(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
    }
}
