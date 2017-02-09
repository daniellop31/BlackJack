using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGit
{
    static class Program
    {
        //TIPOS DE JUEGO
        public static int UN_JUGADOR = 0;
        public static int DOS_JUGADORES = 1;

        //IDENTIFICADOR DE CÓMO SE ESTÁ JUGANDO
        private static int tipoJuego = 1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Procesos.iniciarArreglo();
            Application.Run(new MenuPrincipal());
        }

        public static int TipoJuego
        {
            get
            {
                return tipoJuego;
            }

            set
            {
                tipoJuego = value;
            }
        }

    }
}
