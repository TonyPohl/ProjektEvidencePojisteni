using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FINAL_Version
{
    internal class Pojistenec
    {
        /// <summary>
        /// Jmeno pojisteneho
        /// </summary>
        public string Jmeno { get;private set;}
        /// <summary>
        /// Prijmeni pojisteneho
        /// </summary>
        public string Prijmeni { get;private set; }
        /// <summary>
        /// Vek pojisteneho
        /// </summary>
        public int Vek { get; private set; }
        /// <summary>
        /// Telefon pojisteneho
        /// </summary>
        public int TelefonniCislo { get;private set; }

        public Pojistenec (string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        /// <summary>
        /// Vraci textovou reprezentaci pojisteneho
        /// </summary>
        /// <returns>Textova reprezentace, jmeno,prijmeni,vek,telefon</returns>
        public override string ToString()
        {
            return Jmeno.PadRight(13) + Prijmeni.PadRight(13) + Vek + "    " + TelefonniCislo;   
        }       
    }
}
