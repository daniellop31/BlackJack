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
        //INDICA SI ESTA ES LA ULTIMA RONDA, SE USA CUANDO EL JUGADOR PASA
        private bool ultimaRonda = false;
        private static Random n = new Random();

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

        /// <summary>
        /// El metodo determina el jugador ganador
        /// </summary>
        /// <param name="j1">Primer jugador a comparar</param>
        /// <param name="j2">Segundo jugador a comparar</param>
        /// <returns>El jugador ganador</returns>
        private Jugador jugadorGanador(Jugador j1, Jugador j2)
        {
            Jugador jugadorGanador = null;
           
            if(Procesos.contarPuntaje(j1.Cartas) > 21)
            {
                jugadorGanador = j2;
            }
            else if (Procesos.contarPuntaje(j2.Cartas) > 21)
            {
                jugadorGanador = j1;
            }                         
            return jugadorGanador;
        }

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
                lbPuntageJ1.Text = "Puntaje: " + Procesos.contarPuntaje(Jugador1.Cartas);
            }
            btnPasarJ1.Enabled = false;
            btnPedirCartaJ1.Enabled = false;

            //SI ESTAN JUGANDO DOS PERSONAS DA PASO A LA SEGUNDA
            if (Program.TipoJuego == Program.DOS_JUGADORES)
            {
                btnPasarJ2.Enabled = true;
                btnPedirCartaJ2.Enabled = true;                
            }else if (Program.TipoJuego == Program.UN_JUGADOR)//SI ES INDIVIDUAL GENERA LA JUGADA DEL PC
            {
                if (n.Next(2) == 0)
                {
                    btnPedirCartaJ2_Click(null, null);
                }
                else
                {
                    btnPasarJ2_Click(null, null);
                }
            }

            finJuego();
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
                nuevo.Image = Jugador2.Cartas.ElementAt(i).Imagen;
                nuevo.Visible = true;
                Controls.Add(nuevo);
                lbPuntageJ2.Text = "Puntaje: " + Procesos.contarPuntaje(Jugador2.Cartas);
            }
            btnPasarJ2.Enabled = false;
            btnPedirCartaJ2.Enabled = false;
            btnPasarJ1.Enabled = true;
            btnPedirCartaJ1.Enabled = true;
            finJuego();
        }

        /// <summary>
        /// Condiciones para que el juego finalice
        /// Se llama cada que hay posibilidad de que el juego termine
        /// </summary>
        public void finJuego()
        {
            if ((Procesos.contarPuntaje(Jugador1.Cartas) >= 21) || (Procesos.contarPuntaje(Jugador2.Cartas) >= 21) || ultimaRonda == true)
            {
                btnPasarJ1.Enabled = false;
                btnPedirCartaJ1.Enabled = false;
                btnPasarJ2.Enabled = false;
                btnPedirCartaJ2.Enabled = false;

                DialogResult resultado;

                if (jugadorGanador(Jugador1, Jugador2) != null)
                {
                    resultado = MessageBox.Show("El jugador ganador es " + jugadorGanador(Jugador1, Jugador2).Nombre + "\nComenzar un juego nuevo ?", "Fin del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    resultado = MessageBox.Show("Hay un empate entre ambos jugadores \nComenzar un juego nuevo ?", "Fin del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }

                if (resultado == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    limpiarTablero();
                }
            }
        }

        /// <summary>
        /// Inici
        /// </summary>
        public void limpiarTablero()
        {
            Controls.Clear();
            Jugador1.Cartas.Clear();
            Jugador2.Cartas.Clear();
            InitializeComponent();
            btnApostarJ1.Enabled = true;
            btnApostarJ2.Enabled = false;
            btnPasarJ1.Enabled = false;
            btnPasarJ2.Enabled = false;
            btnPedirCartaJ1.Enabled = false;
            btnPedirCartaJ2.Enabled = false;
            txtApuestaJ1.Enabled = true;
            txtApuestaJ2.Enabled = true;
            lbDineroJ1.Text = "Dinero: " + Jugador1.DineroTotal;
            lbDineroJ2.Text = "Dinero: " + Jugador2.DineroTotal;
        }

        private void btnApostarJ1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtApuestaJ1.Text)<=100000 && txtApuestaJ1.Text != "" &&
                Convert.ToInt32(txtApuestaJ1.Text) <= Jugador1.DineroTotal)
            {                
                Jugador1.Apuesta = Convert.ToInt32(txtApuestaJ1.Text);
                Jugador1.DineroTotal -= Convert.ToInt32(txtApuestaJ1.Text);
                lbDineroJ1.Text = "Dinero: " + Jugador1.DineroTotal;

                if (Program.TipoJuego == Program.DOS_JUGADORES)//SI LA PARTIDA ES DE DOS JUGADORES
                {
                    txtApuestaJ2.Enabled = true;
                    btnApostarJ2.Enabled = true;
                    btnApostarJ1.Enabled = false;
                    txtApuestaJ1.Enabled = false;
                }else  if(Program.TipoJuego == Program.UN_JUGADOR)
                {
                    int apuesta;
                    do
                    {
                        apuesta = n.Next(1,100001);
                    } while (apuesta>Jugador2.DineroTotal);

                    Jugador2.Apuesta = apuesta;                   
                    Jugador2.DineroTotal -= Jugador2.Apuesta;
                    lbDineroJ2.Text = "Dinero: " + Jugador2.DineroTotal;

                    Procesos.cartasIniciales(this);
                    //HABILITA LAS OPCIONES DE JUEGO
                    btnPasarJ1.Enabled = true;
                    btnPasarJ2.Enabled = true;
                    btnPedirCartaJ1.Enabled = true;
                    btnPedirCartaJ2.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Apuesta inválida", "Haga una apuesta válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnApostarJ2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtApuestaJ2.Text) <= 100000 && txtApuestaJ2.Text != "" &&
                Convert.ToInt32(txtApuestaJ2.Text) <= Jugador2.DineroTotal)
            {
                btnApostarJ2.Enabled = false;
                txtApuestaJ2.Enabled = false;
                Jugador2.Apuesta = Convert.ToInt32(txtApuestaJ1.Text);
                Jugador2.DineroTotal -= Convert.ToInt32(txtApuestaJ2.Text);
                lbDineroJ2.Text = "Dinero: " + Jugador2.DineroTotal;

                Procesos.cartasIniciales(this);
                //HABILITA LAS OPCIONES DE JUEGO
                btnPasarJ1.Enabled = true;
                btnPasarJ2.Enabled = true;
                btnPedirCartaJ1.Enabled = true;
                btnPedirCartaJ2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese una apuesta válida", "Apuesta Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApuestaJ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procesos.validarNumero(e);
        }

        private void txtApuestaJ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procesos.validarNumero(e);
        }

        private void btnPasarJ1_Click(object sender, EventArgs e)
        {
            ultimaRonda = true;
            if (Program.TipoJuego == Program.DOS_JUGADORES)//SI SON DOS JUGADORES DA PASO AL SEGUNDO
            {
                btnPasarJ2.Enabled = true;
                btnPedirCartaJ2.Enabled = true;
                btnPasarJ1.Enabled = false;
                btnPedirCartaJ1.Enabled = false;
            }else if (Program.TipoJuego == Program.UN_JUGADOR)//PASO AL PC
            {
                if (n.Next(2) == 0)
                {
                    btnPedirCartaJ2_Click(null,null);
                }
                else
                {
                    btnPasarJ2_Click(null, null);
                }
            }

        }

        private void btnPasarJ2_Click(object sender, EventArgs e)
        {
            ultimaRonda = true;
            btnPasarJ2.Enabled = false;
            btnPedirCartaJ2.Enabled = false;
            btnPasarJ1.Enabled = true;
            btnPedirCartaJ1.Enabled = true;
        }
    }
}