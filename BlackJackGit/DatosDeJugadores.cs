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
    public partial class DatosDeJugadores : Form
    {
        public DatosDeJugadores()
        {
            InitializeComponent();
        }

        bool nombreJ1Listo = false;
        bool nombreJ2Listo = false;
        bool apuestaJ1Listo = false;
        bool apuestaJ2Listo = false;

        private void btnHecho_Click(object sender, EventArgs e)
        {
            validar();
            if (nombreJ1Listo && nombreJ2Listo && apuestaJ1Listo && apuestaJ2Listo)
            {
                //Si los campos estan llenos aqui se les da el nombre a los GroupBox del tablero
                //donde se pasa los nombres de los jugadores y sus apuestas
                //por ultimo se abre un formulario de tablero

                Tablero nuevoTablero = new Tablero();
                //ESTA SECCION EDITA LOS CAMPOES VISIBLES
                nuevoTablero.gbOpcionesJ1.Text = txtNombreJ1.Text;
                nuevoTablero.gbOpcionesJ2.Text = txtNombreJ2.Text;
                nuevoTablero.txtApuestaJ1.Text = txtApuestaJ1.Text;
                nuevoTablero.txtApuestaJ2.Text = txtApuestaJ2.Text;

                //ESTA SECCIÓN EDITA LOS CAMPOES DE LOS OBJETOS JUGADOR
                nuevoTablero.Jugador1 = new Jugador(txtNombreJ1.Text);
                nuevoTablero.Jugador2 = new Jugador(txtNombreJ2.Text);
                nuevoTablero.Jugador1.Apuesta = Convert.ToInt32(txtApuestaJ1.Text);
                nuevoTablero.Jugador2.Apuesta = Convert.ToInt32(txtApuestaJ2.Text);

                //DA LAS CARTAS INICIALES A LOS JUGADORES
                nuevoTablero.Jugador1.Cartas.Add(Procesos.pedirCarta());
                nuevoTablero.Jugador1.Cartas.Add(Procesos.pedirCarta());
                nuevoTablero.Jugador2.Cartas.Add(Procesos.pedirCarta());
                nuevoTablero.Jugador2.Cartas.Add(Procesos.pedirCarta());
                nuevoTablero.imgCarta1J1.Image = nuevoTablero.Jugador1.Cartas.ElementAt(0).Imagen;
                nuevoTablero.imgCarta2J1.Image = nuevoTablero.Jugador1.Cartas.ElementAt(1).Imagen;
                nuevoTablero.imgCarta1J2.Image = nuevoTablero.Jugador2.Cartas.ElementAt(0).Imagen;
                nuevoTablero.imgCarta2J2.Image = nuevoTablero.Jugador2.Cartas.ElementAt(1).Imagen;


                nuevoTablero.Show();
                Close();
            }      
        }

        /// <summary>
        /// Verifica la validez de los campos
        /// </summary>
        private void validar()
        {
            if (txtNombreJ1.Text == "")
            {
                MessageBox.Show("El jugador #1 debe de tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreJ1Listo = true;
            }

            if (txtApuestaJ1.Text == "")
            {
                MessageBox.Show("El jugador #1 no ha definido su apuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                apuestaJ1Listo = true;
            }

            if (txtNombreJ2.Text == "")
            {
                MessageBox.Show("El jugador #2 debe de tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreJ2Listo = true;
            }

            if (txtApuestaJ2.Text == "")
            {
                MessageBox.Show("El jugador #2 no ha definido su apuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                apuestaJ2Listo = true;
            }
        }

        private void txtNombreJ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procesos.validarTexto(e);
        }

        private void txtApuestaJ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procesos.validarNumero(e);
        }

        private void txtNombreJ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procesos.validarTexto(e);
        }

        private void txtApuestaJ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Procesos.validarNumero(e);
        }
    }
}
