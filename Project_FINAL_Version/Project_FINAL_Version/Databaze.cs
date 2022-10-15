using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FINAL_Version
{
    internal class Databaze
    {
        /// <summary>
        /// Seznam pojištěných
        /// </summary>
        public List<Pojistenec> pojistenci;
        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
            pojistenci.Add(new Pojistenec("David", "Capka", 33, 123456789));
            pojistenci.Add(new Pojistenec("David", "Jancik", 27, 123456789));
        }
        /// <summary>
        /// Přidání nového pojištěnce
        /// </summary>
        public void PridatPojisteneho()
        {                                                           
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }

            Console.WriteLine("Zadejte příjmení:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu:");
            }

            Console.WriteLine("Zadejte telefonní číslo: ");
            int telefonniCislo;            
            while (!int.TryParse(Console.ReadLine(), out telefonniCislo))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

            Console.WriteLine("Zadejte věk: ");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

            pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telefonniCislo));
            Console.WriteLine();
            Console.WriteLine("Data byla uložena.Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Vyhledání pojištěného podle jména a příjmení
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného</param>
        /// <param name="prijmeni">Příjmení pojištěného</param>
        /// <returns>Vyhledaný pojištěnec</returns>
        public Pojistenec VyhledejPojisteneho(string jmeno,string prijmeni)
        {
            foreach (Pojistenec p in pojistenci)
            {
                if ((p.Jmeno==jmeno)&&(p.Prijmeni == prijmeni))
                {
                    return p;
                }
            }
            return null;            
        }        
        /// <summary>
        /// Vypsání všech pojištěných
        /// </summary>
        public void VypisPojistene()
        {            
            if (pojistenci.Count > 0)
                foreach (Pojistenec p in pojistenci)
                {
                    Console.WriteLine(p);                      
                }
            else
                Console.WriteLine("Nebyli nalezeni žádní pojištěnci.");
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
