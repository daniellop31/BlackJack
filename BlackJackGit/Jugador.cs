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
        private  List<Carta> cartas = new List<Carta>();
        private int puntaje;

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

        public int Apuesta
        {
            get
            {
                return apuesta;
            }

            set
            {
                apuesta = value;
            }
        }

        internal List<Carta> Cartas
        {
            get
            {
                return cartas;
            }

            set
            {
                cartas = value;
            }
        }

        public int Puntaje
        {
            get
            {
                return puntaje;
            }

            set
            {
                puntaje = value;
            }
        }

        /// <summary>
        /// Crea una instancia de Jugador con nombre
        /// </summary>
        /// <param name="nombre">Nombre del jugador, Viene dado por la ventanda DatosDeJugador</param>
        public Jugador(string nombre)
        {
            this.Nombre = nombre;
        }

        public int contarPuntaje(List<Carta> cartas)
        {
            int totalPuntos = 0;
            foreach(Carta c in cartas)
            {
                totalPuntos += c.Valor;
            }
            return totalPuntos;
        }
    }
}