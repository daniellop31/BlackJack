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
        private Random generador = new Random();




        public Tablero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            Carta a = new Carta(generador.Next(13));
            label1.Text = a.Nombre¨*/
            
            DialogResult result;
            result = MessageBox.Show("Desea jugar", "Jugar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Controls.Remove(pictureBox2);
                pictureBox2.Dispose();
            }
            
            
        }
    }
}
