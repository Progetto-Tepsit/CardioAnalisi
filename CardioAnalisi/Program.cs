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
            int percmin = ClassCardioAnalisi.ClasseCardio.Battitimin(eta);
            int percmax = ClassCardioAnalisi.ClasseCardio.Battitimax(eta);
            Console.WriteLine($"devi tenere il livello dei tuoi battiti cardiaci tra {percmin} e {percmax}");
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.WriteLine("quanti battiti al minuto fai a riposo?");
            int battitiminuto = int.Parse(Console.ReadLine());
            if(ClassCardioAnalisi.ClasseCardio.Bradicardia(battitiminuto)==true)
            {
                Console.WriteLine("Sei bradichardico");
            }
            if(ClassCardioAnalisi.ClasseCardio.Normale(battitiminuto)==true)
            {
                Console.WriteLine("I tuoi battiti sono normali");
            }
            if(ClassCardioAnalisi.ClasseCardio.Tachicardia(battitiminuto)==true)
            {
                Console.WriteLine("Sei tachicardico");
            }
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.WriteLine("quanti chili pesi?");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("quanti minuti durano i tuoi allenamenti?");
            int durata = int.Parse(Console.ReadLine());
            Console.WriteLine("se sei un uomo inserisci 1, se sei donna 2");
            int genere = int.Parse(Console.ReadLine());
            if(genere==1)
            {
                double calorie = ClassCardioAnalisi.ClasseCardio.CalorieUomo(battitiminuto, peso, eta,durata);
                Console.WriteLine($"durante questa sessione di allenamento hai bruciato {calorie} kilo-calorie");
            }
            if(genere==2)
            {
                double calorie = ClassCardioAnalisi.ClasseCardio.CalorieDonna(battitiminuto, peso, eta, durata);
                Console.WriteLine($"durante questa sessione di allenamento hai bruciato {calorie} kilo-calorie");
            }
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.WriteLine("quanti chilometri hai percorso?");
            int chilometri = int.Parse(Console.ReadLine());
            Console.WriteLine("se stavi correndo inserisci 1, se stavi camminando 2");
            int modo = int.Parse(Console.ReadLine());
            if(modo==1)
            {
                double metodo = ClassCardioAnalisi.ClasseCardio.Corsa(chilometri, peso);
                Console.WriteLine($"la tua spesa energetica è pari a {metodo} joule");
            }
            if(genere==2)
            {
                double metodo = ClassCardioAnalisi.ClasseCardio.Camminata(chilometri, peso);
                Console.WriteLine($"la tua spesa energetica è pari a {metodo} joule");
            }
            Console.ReadLine();
        }
     
    }
}
