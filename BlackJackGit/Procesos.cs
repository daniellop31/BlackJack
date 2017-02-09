using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BlackJackGit
{
    class Procesos
    {
        //Arrelgo para identificar cada carta
        private static string[] codigoCartas = new string[13];
        
        public static string[] CodigoCartas
        {
            get
            {
                return codigoCartas;
            }

            set
            {
                codigoCartas = value;
            }
        }

        /// <summary>
        /// Inicializa el arreglo de las cartas, es para invocarse
        /// Se invoca al iniciar el programa
        /// </summary>
        public static void iniciarArreglo()
        {
            CodigoCartas[0] = "A";
            CodigoCartas[1] = "Uno";
            CodigoCartas[2] = "Dos";
            CodigoCartas[3] = "Tres";
            CodigoCartas[4] = "Cuatro";
            CodigoCartas[5] = "Cinco";
            CodigoCartas[6] = "Seis";
            CodigoCartas[7] = "Siete";
            CodigoCartas[8] = "Ocho";
            CodigoCartas[9] = "Nueve";
            CodigoCartas[10] = "J";
            CodigoCartas[11] = "Q";
            CodigoCartas[12] = "K";
        }        

        /// <summary>
        /// Hará que solo se puedan escribir textos 
        /// </summary>
        /// <param name="e">Un evento KeyPress de un textbox</param>
        public static void validarTexto(KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// Hará que solo se puedan escribir numeros
        /// </summary>
        /// <param name="e">Evento de KeyPress de un textobox</param>
        public static void validarNumero(KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// Crea una carta con un código aleatorio y la retorna
        /// </summary>
        /// <returns>Carta creada</returns>
        public static Carta pedirCarta()
        {
            Random r = new Random();
            return new Carta(r.Next(13));
        }

        /// <summary>
        /// Cuenta los puntos que hay en un arreglo de cartas
        /// </summary>
        /// <param name="cartas">Arreglo de cartas para contra el puntaje</param>
        /// <returns>Puntaje del arreglo de cartas</returns>
        public static int contarPuntaje(List<Carta> cartas)
        {
            int totalPuntos = 0;
            foreach (Carta c in cartas)
            {
                totalPuntos += c.Valor;
            }
            return totalPuntos;
        }

        /// <summary>
        /// Da las cartas iniciales a los jugadores
        /// </summary>
        /// <param name="nuevoTablero">Tablero en el que se ejecuta la acción</param>
        public static void cartasIniciales(Tablero nuevoTablero)
        {
            nuevoTablero.Jugador1.Cartas.Add(pedirCarta());
            nuevoTablero.Jugador1.Cartas.Add(pedirCarta());
            nuevoTablero.Jugador2.Cartas.Add(pedirCarta());
            nuevoTablero.Jugador2.Cartas.Add(pedirCarta());
            nuevoTablero.imgCarta1J1.Image = nuevoTablero.Jugador1.Cartas.ElementAt(0).Imagen;
            nuevoTablero.imgCarta2J1.Image = nuevoTablero.Jugador1.Cartas.ElementAt(1).Imagen;
            nuevoTablero.lbPuntageJ1.Text = "Puntaje: " + Convert.ToString(contarPuntaje(nuevoTablero.Jugador1.Cartas));
            nuevoTablero.imgCarta1J2.Image = nuevoTablero.Jugador2.Cartas.ElementAt(0).Imagen;
            nuevoTablero.imgCarta2J2.Image = nuevoTablero.Jugador2.Cartas.ElementAt(1).Imagen;
            nuevoTablero.lbPuntageJ2.Text = "Puntaje: " + Convert.ToString(contarPuntaje(nuevoTablero.Jugador2.Cartas));
        }
    }
}

