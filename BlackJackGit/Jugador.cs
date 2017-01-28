using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGit
{
    class Jugador
    {
        string nombre;
        int apuesta;
        List<Carta> cartas;

        public Jugador(string nombre, int apuesta, List<Carta> cartas)
        {
            this.nombre = nombre;
            this.apuesta = apuesta;
            this.cartas = cartas;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}

