using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGit
{
    class Procesos
    {
        public static string[] codigoCartas = new string[13];

        public static void iniciarArreglo()
        {
            codigoCartas[0] = "A";
            codigoCartas[1] = "Uno";
            codigoCartas[2] = "Dos";
            codigoCartas[3] = "Tres";
            codigoCartas[4] = "Cuatro";
            codigoCartas[5] = "Cinco";
            codigoCartas[6] = "Seis";
            codigoCartas[7] = "Siete";
            codigoCartas[8] = "Ocho";
            codigoCartas[9] = "Nueve";
            codigoCartas[10] = "J";
            codigoCartas[11] = "Q";
            codigoCartas[12] = "K";
        }        
    }
}

