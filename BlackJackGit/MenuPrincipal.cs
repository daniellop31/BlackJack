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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnUnJugador_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            DatosDeJugadores formJ = new DatosDeJugadores();
            formJ.txtNombreJ2.Text = "PC";
            formJ.txtNombreJ2.Enabled = false;
            int apuestaj2 = r.Next(0, 100000);
            formJ.txtApuestaJ2.Text = apuestaj2.ToString("0,0");
            formJ.txtApuestaJ2.Enabled = false;
            formJ.Show();
        }

        private void btnDosJugadores_Click(object sender, EventArgs e)
        {
            DatosDeJugadores formJ = new DatosDeJugadores();
            formJ.Show();
        }
    }
}
