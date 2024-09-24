using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerCaso
{
    public class Carta
    {
        private string cara; //cara de la carta
        private string palo; //palo de la carta

        public Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta; // inicializa 
            palo = paloCarta; //inicializa

        }

        public override string ToString()
        {
            return cara + " de " + palo;
        }

    }
}
