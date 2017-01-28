using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGit
{
    class Jugador
    {
        private string nombre;
        private int apuesta;
        private List<Carta> cartas = new List<Carta>();
        private int puntaje;

        public Jugador(string nombre, int apuesta, List<Carta> cartas)
        {
            this.nombre = nombre;
        }
    }
}