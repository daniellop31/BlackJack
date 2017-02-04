using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGit
{
    public partial class Tablero : Form
    {
        //CONSTANTES PARA LA CREACIÓN DE CARTAS EXTRA
        /// <summary>
        /// Anchura de las cartas
        /// </summary>
        private const int ANCHO_CARTA = 108;
        /// <summary>
        /// Altura de las cartas 
        /// </summary>
        private const int ALTURA_CARTA = 155;
        /// <summary>
        /// Posicion en X de la carta del jugador 1
        /// </summary>
        private const int X_POSICION_J1 = 12;
        /// <summary>
        /// Posicion en Y de la carta del jugador 1
        /// </summary>
        private const int Y_POSICION_J1 = 12;
        /// <summary>
        /// Posicion en X de la carta del jugador 2
        /// </summary>
        private const int X_POSICION_J2 = 666;
        /// <summary>
        /// Altura a la que esta la carta del jugador dos
        /// </summary>
        private const int Y_POSICION_J2 = 12;
        /// <summary>
        /// Espacio que hay entre cartas superpuestas
        /// </summary>
        private const int ESPACIO_NUMERO = 15;

        //INSTANCIAS DE JUGADOR, ESTOS SON LOS ENTES QUE INTERACTUAN
        private Jugador J1;
        private Jugador J2;

        internal Jugador Jugador1
        {
            get
            {
                return J1;
            }

            set
            {
                J1 = value;
            }
        }

        internal Jugador Jugador2
        {
            get
            {
                return J2;
            }

            set
            {
                J2 = value;
            }
        }

        public Tablero()
        {
            InitializeComponent();
        }

        //TODO: Terminar los siguientes métodos, organizar los jugadores para que se instacien y poder manipularlos
        private void btnPedirCartaJ1_Click(object sender, EventArgs e)
        {
            Jugador1.Cartas.Add(Procesos.pedirCarta());


        }

        private void btnPedirCartaJ2_Click(object sender, EventArgs e)
        {
            Jugador2.Cartas.Add(Procesos.pedirCarta());
        }
    }
}
