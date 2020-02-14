using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti anni hai?");
            int eta = int.Parse(Console.ReadLine());
            int percmin = ClassLibraryCardioAnalisi.Class1.Battitimin(eta);
            int percmax = ClassLibraryCardioAnalisi.Class1.Battitimax(eta);
            Console.WriteLine($"devi tenere il livello dei tuoi battiti cardiaci tra {percmin} e {percmax}");
            Console.ReadLine();
            Console.WriteLine("quanti battiti al minuto fai a riposo?");
            int battitiminuto = int.Parse(Console.ReadLine());
            if(ClassLibraryCardioAnalisi.Class1.Bradicardia(battitiminuto)==true)
            {
                Console.WriteLine("Sei bradichardico");
            }
            if(ClassLibraryCardioAnalisi.Class1.Normale(battitiminuto)==true)
            {
                Console.WriteLine("I tuoi battiti sono normali");
            }
            if(ClassLibraryCardioAnalisi.Class1.Tachicardia(battitiminuto)==true)
            {
                Console.WriteLine("Sei tachicardico");
            }
        }
    }
}
