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
        private int dineroTotal;
        private int ganadas;
        private int tempGanadas;

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

        public int DineroTotal
        {
            get
            {
                return dineroTotal;
            }

            set
            {
                dineroTotal = value;
            }
        }

        public int Ganadas
        {
            get
            {
                return ganadas;
            }

            set
            {
                ganadas = value;
            }
        }

        public int TempGanadas
        {
            get
            {
                return tempGanadas;
            }

            set
            {
                tempGanadas = value;
            }
        }

        /// <summary>
        /// Crea una instancia de Jugador con nombre
        /// </summary>
        /// <param name="nombre">Nombre del jugador, Viene dado por la ventanda DatosDeJugador</param>
        public Jugador(string nombre)
        {
            this.dineroTotal = 500000;
            this.Nombre = nombre;
            this.ganadas = 0;
            this.tempGanadas = 0;
        }        
    }
}