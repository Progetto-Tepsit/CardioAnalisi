using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardioAnalisi.Test
{
    [TestClass]
    public class UnitTest1
    {
        public void TestBattitimin()
        {
            int risultatoaspettato = 140;
            int eta = 20;
            int risultato = ClassCardioAnalisi.ClasseCardio.Battitimin(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestBattitimax()
        {
            int risultatoaspettato = 180;
            int eta = 20;
            int risultato = ClassCardioAnalisi.ClasseCardio.Battitimax(eta);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestNormale()
        {
            bool risultatoaspettato = true;
            int battiti = 75;
            bool risultato = ClassCardioAnalisi.ClasseCardio.Normale(battiti);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestBradicardico()
        {
            bool risultatoaspettato = true;
            int battiti = 55;
            bool risultato = ClassCardioAnalisi.ClasseCardio.Bradicardia(battiti);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestTachicardico()
        {
            bool risultatoaspettato = true;
            int battiti = 120;
            bool risultato = ClassCardioAnalisi.ClasseCardio.Tachicardia(battiti);
            Assert.AreEqual(risultatoaspettato, risultato);
        } 
        public void TestCalorieUomo()
        {
            double risultatoaspettato = 60;
            int anni = 16;
            int battitiriposo = 100;
            int peso = 70;
            int temp = 10;
            double risultato = ClassCardioAnalisi.ClasseCardio.CalorieUomo(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestCalorieDonna()
        {
            double risultatoaspettato = 40;
            int anni = 16;
            int battitiriposo = 100;
            int peso = 70;
            int temp = 10;
            double risultato = ClassCardioAnalisi.ClasseCardio.CalorieDonna(battitiriposo, peso, anni, temp);
            Assert.AreEqual(risultatoaspettato, risultato);
        }

        public void TestCorsa()
        {
            double risultatoaspettato = 308;
            int peso = 57;
            int spazio = 6;
            double risultato = ClassCardioAnalisi.ClasseCardio.Corsa(peso, spazio);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
        public void TestCamminata()
        {
            double risultatoaspettato = 171;
            int peso = 57;
            int spazio = 6;
            double risultato = ClassCardioAnalisi.ClasseCardio.Camminata(peso, spazio);
            Assert.AreEqual(risultatoaspettato, risultato);
        }
    }
}
