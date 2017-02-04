﻿using System;
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
        private const int ESPACIO_NUMERO = 20;

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

        private Jugador jugadorGanador(Jugador j1, Jugador j2)
        {
            Jugador jugadorGanador = null;

            if (j1.contarPuntaje(j1.Cartas) >= 21)
            {
                jugadorGanador = j2;
            }
            else
            {
                if (j2.contarPuntaje(j2.Cartas) >= 21)
                {
                    jugadorGanador = j1;
                }
                else
                {
                    if(j1.contarPuntaje(j1.Cartas) == j2.contarPuntaje(j2.Cartas))
                    {
                        jugadorGanador = null;
                    }
                }
            }
            return jugadorGanador;
        }

        //TODO: Terminar los siguientes métodos, organizar los jugadores para que se instacien y poder manipularlos
        private void btnPedirCartaJ1_Click(object sender, EventArgs e)
        {
            Jugador1.Cartas.Add(Procesos.pedirCarta());
            for(int i = 2; i< Jugador1.Cartas.Count; i++)
            {
                PictureBox nuevo = new PictureBox();
                nuevo.Location = new Point(X_POSICION_J1+(i-2)*ESPACIO_NUMERO, Y_POSICION_J1);
                nuevo.Size = new Size(ANCHO_CARTA, ALTURA_CARTA);
                nuevo.Image = Jugador1.Cartas.ElementAt(i).Imagen;
                nuevo.Visible = true;
                Controls.Add(nuevo);
                nuevo.BringToFront();
            }


        }

        private void btnPedirCartaJ2_Click(object sender, EventArgs e)
        {
            Jugador2.Cartas.Add(Procesos.pedirCarta());
            for (int i = 2; i < Jugador2.Cartas.Count; i++)
            {
                PictureBox nuevo = new PictureBox();
                nuevo.Location = new Point(X_POSICION_J2 - (i - 2) * ESPACIO_NUMERO, Y_POSICION_J2);
                nuevo.Size = new Size(ANCHO_CARTA, ALTURA_CARTA);
                nuevo.Image = Jugador2.Cartas.ElementAt(i).Imagen;                                
                Controls.Add(nuevo);                                
            }
        }
    }
}
