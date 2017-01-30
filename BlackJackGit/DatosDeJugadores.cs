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
            if (txtNombreJ1.Text == "")
            {
                MessageBox.Show("El jugador #1 debe de tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreJ1Listo = true;
            }

            if(txtApuestaJ1.Text == "")
            {
                MessageBox.Show("El jugador #1 no ha definido su apuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                apuestaJ1Listo = true;
            }

            if(txtNombreJ2.Text == "")
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

            if (nombreJ1Listo && nombreJ2Listo && apuestaJ1Listo && apuestaJ2Listo)
            {
                //Si los campos estan llenos aqui se les da el nombre a los GroupBox del tablero
                //donde se pasa los nombres de los jugadores y sus apuestas
                //por ultimo se abre un formulario de tablero

                Tablero nuevoTablero = new Tablero();
                nuevoTablero.gbOpcionesJ1.Text = txtNombreJ1.Text;
                nuevoTablero.gbOpcionesJ2.Text = txtNombreJ2.Text;
                nuevoTablero.txtApuestaJ1.Text = txtApuestaJ1.Text;
                nuevoTablero.txtApuestaJ2.Text = txtApuestaJ2.Text;
                nuevoTablero.Show();
                Close();
            }
        }
    }
}
            Tablero nuevoTablero = new Tablero();
            nuevoTablero.gbOpcionesJ1.Text = txtNombreJ1.Text;
            nuevoTablero.gbOpcionesJ2.Text = txtNombreJ2.Text;
            nuevoTablero.txtApuestaJ1.Text = txtApuestaJ1.Text;
            nuevoTablero.txtApuestaJ2.Text = txtApuestaJ2.Text;
            nuevoTablero.Show();
            Close();            
        }

        /// <summary>
        /// Verifica que los campos estén llenados de manera correcta
        /// </summary>
        /// <returns>La validad de los campos</returns>
        private bool validar()
        {
            
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
