using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardioAnalisi.Test
{
    [TestClass]
    public class ClasseCardioTest
    {
        [DataTestMethod]
        [DataRow(20, 140)]
        [DataRow(30, 133)]
        public void TestBattitiMin(int eta, int risultatoaspettato)
        {
            int risultato = ClassCardioAnalisi.ClasseCardio.Battitimin(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        [DataTestMethod]
        [DataRow(20, 180)]
        [DataRow(30, 171)]
        public void TestBattitiMax(int eta, int risultatoaspettato)
        {
            int risultato = ClassCardioAnalisi.ClasseCardio.Battitimax(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        [DataTestMethod]
        [DataRow(75, true)]
        [DataRow(70, true)]
        [DataRow(95, true)]
        public void TestNormale(int battitiminuto, bool risultatoaspettato)
        {
            bool risposta = ClassCardioAnalisi.ClasseCardio.Normale(battitiminuto);
            Assert.AreEqual(risultatoaspettato, risposta);
        }
        [DataTestMethod]
        [DataRow(55, true)]
        [DataRow(59, true)]
        [DataRow(30, true)]
        public void TestBradicardico(int battitiminuto, bool risultatoaspettato)
        {
            bool risposta = ClassCardioAnalisi.ClasseCardio.Bradicardia(battitiminuto);
            Assert.AreEqual(risultatoaspettato, risposta);
        }
        [DataTestMethod]
        [DataRow(120, true)]
        [DataRow(150, true)]
        [DataRow(109, true)]
        public void TestTachicardico(int battitiminuto, bool risultatoaspettato)
        {
            bool risposta = ClassCardioAnalisi.ClasseCardio.Tachicardia(battitiminuto);
            Assert.AreEqual(risultatoaspettato, risposta);
        }
        [DataTestMethod]
        [DataRow(16, 100, 70, 10, 60)]
        public void TestCalorieUomo(int anni, int battitiriposo, int peso, int temp, double risultatoaspettato)
        {
            double risultato = ClassCardioAnalisi.ClasseCardio.CalorieUomo(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        [DataTestMethod]
        [DataRow(16, 100, 70, 10, 40)]
        public void TestCalorieDonna(int anni, int battitiriposo, int peso, int temp, double risultatoaspettato)
        {
            double risultato = ClassCardioAnalisi.ClasseCardio.CalorieDonna(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        [DataTestMethod]
        [DataRow(57, 6, 308)]
        public void TestCorsa(int peso, int spazio, double risultatoaspettato)
        {
            double risultato = ClassCardioAnalisi.ClasseCardio.Corsa(peso, spazio);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        [DataTestMethod]
        [DataRow(57, 6, 171)]
        public void TestCamminata(int peso, int spazio, double risultatoaspettato)
        {
            double risultato = ClassCardioAnalisi.ClasseCardio.Camminata(peso, spazio);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
    }
}
