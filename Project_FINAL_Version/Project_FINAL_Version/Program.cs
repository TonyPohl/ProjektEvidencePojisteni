using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FINAL_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            int volbaMenu = '0';
            Databaze databaze = new Databaze();

            while (volbaMenu != '4')
            {
                Console.WriteLine("------------------------------\nEvidence pojištěných\n------------------------------");
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec\n");
                volbaMenu = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (volbaMenu)
                {
                    case '1':                        
                        databaze.PridatPojisteneho();                        
                        break;

                    case '2':                    
                        databaze.VypisPojistene();
                        break;

                    case '3':                                                                                
                        Console.WriteLine("Zadejte jméno pojištěného: ");
                        string jmeno;
                        while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
                        {
                            Console.WriteLine("Zadejte jméno znovu:");
                        }

                        Console.WriteLine("Zadejte příjmení: ");
                        string prijmeni;
                        while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
                        {
                            Console.WriteLine("Zadejte příjmení znovu:");
                        }
                        Console.WriteLine();
                        Pojistenec pojistenec = databaze.VyhledejPojisteneho(jmeno, prijmeni);
                        if (pojistenec != null)
                        {
                            Console.WriteLine(pojistenec);                                                          
                        }
                        else
                        {
                            Console.WriteLine("Pojištěnec se jménem {0} a prijmenim {1} nebyla nalezena!", jmeno, prijmeni);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou...");                                                                                
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '4':
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Neplatná volba, zadejte číslo v rozmezí 1 - 4");                        
                        break;
                        Console.Clear();
                }
            }                       
        }
    }
}
