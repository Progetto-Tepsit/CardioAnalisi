using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCardioAnalisi
{
    public class Class1
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
    }
}
