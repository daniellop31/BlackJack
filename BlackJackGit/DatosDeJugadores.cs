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

        private void btnHecho_Click(object sender, EventArgs e)
        {
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
