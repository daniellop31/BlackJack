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
        private const int ANCHO_CARTA = 108;
        private const int ALTURA_CARTA = 155;
        private const int X_POSICION_J1 = 12;
        private const int Y_POSICION_J1 = 12;
        private const int X_POSICION_J2 = 666;
        private const int Y_POSICION_J2 = 12;        

        public Tablero()
        {
            InitializeComponent();
        }
    }
}
