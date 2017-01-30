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
    }
}
