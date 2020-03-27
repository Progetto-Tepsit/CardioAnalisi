using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCardioAnalisi
{
    public class ClasseCardio
    {
        public static int Battitimin(int eta)
        {
            int battitimax = 220 - eta;
            int percmin = (battitimax * 70 / 100);
            return percmin;

        }
        public static int Battitimax(int eta)
        {
            int battitimax = 220 - eta;
            int percmax = (battitimax * 90 / 100);
            return percmax;
        }
        public static bool Bradicardia(int battitiminuto)
        {
            if (battitiminuto < 60)
            {
                return true;
            }
            else
                return false;
        }
        public static bool Normale(int battitiminuto)
        {
            if (battitiminuto >= 60 &&battitiminuto<=100)
            {
                return true;
            }
            else
                return false;
        }
        public static bool Tachicardia(int battitiminuto)
        {
            if (battitiminuto >100)
            {
                return true;
            }
            else
                return false;
        }
        public static double CalorieUomo(int frequenza, int peso, int eta, int durata)
        {
            double calorie = ((eta * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * durata / 4.184;
            calorie = Math.Round(calorie, 0);
            return calorie;
        }
        public static double CalorieDonna(int frequenza, int peso, int eta, int durata)
        {
            double calorie = ((eta * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184;
            calorie = Math.Round(calorie, 0);
            return calorie;
        }
        public static double Corsa(int spazio,int peso)
        {
            double energia = 0.9 * spazio * peso;
            energia = Math.Round(energia, 0);
            return energia;
        }
        public static double Camminata(int spazio, int peso)
        {
            double energia = 0.5 * spazio * peso;
            energia = Math.Round(energia, 0);
            return energia;
        }
        public static List<double> MediaBattiti(int misurazioni)
        {
            List<double> valori = new List<double>();
            int c = 0;
            while(c!=misurazioni)
            {
                Console.WriteLine($"inserisci il valore della {c + 1} misurazione");
                int valore = int.Parse(Console.ReadLine());
                valori.Add(valore);
                c++;
            }
            return valori;
        }
        public static int Variazione(int a, int b)
            {
         
                int variazione=a-b;
                variazione= Math.Abs(variazione);
                return variazione;
            }
        
        }
     
    }


