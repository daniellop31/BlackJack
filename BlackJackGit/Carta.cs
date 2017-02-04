using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BlackJackGit
{
    class Carta 
    {
        //CONSTANTES PARA LAS CARTAS
        public static Image A = global::BlackJackGit.Properties.Resources.ace_of_diamonds;
        public static Image UNO = global::BlackJackGit.Properties.Resources._1_of_diamonds;
        public static Image DOS = global::BlackJackGit.Properties.Resources._2_of_diamonds;
        public static Image TRES = global::BlackJackGit.Properties.Resources._3_of_diamonds;
        public static Image CUATRO = global::BlackJackGit.Properties.Resources._4_of_diamonds;
        public static Image CINCO = global::BlackJackGit.Properties.Resources._5_of_diamonds;
        public static Image SEIS = global::BlackJackGit.Properties.Resources._6_of_diamonds;
        public static Image SIETE = global::BlackJackGit.Properties.Resources._7_of_diamonds;
        public static Image OCHO = global::BlackJackGit.Properties.Resources._8_of_diamonds;
        public static Image NUEVE = global::BlackJackGit.Properties.Resources._9_of_diamonds;
        public static Image J = global::BlackJackGit.Properties.Resources.jack_of_diamonds;
        public static Image Q = global::BlackJackGit.Properties.Resources.queen_of_diamonds;
        public static Image K = global::BlackJackGit.Properties.Resources.king_of_diamonds;








        //ESTO ES UNA CARTA
        private string nombre;
        private int valor;
        private int codigo;
        private Image imagen;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public Image Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        /// <summary>
        /// Crea una carta
        /// </summary>
        /// <param name="codigo">Identificador de la carta</param>
        public Carta(int codigo)
        {
            Codigo = codigo;
            Nombre = Procesos.CodigoCartas[codigo];
            if (codigo == 0)
                Valor = 11;
            else if (codigo >= 1 && codigo <= 9)
                Valor = codigo;
            else
                Valor = 10;

            switch (Codigo)
            {
                case 0:
                    Imagen = A;
                    break;
                case 1:
                    Imagen = UNO;
                    break;
                case 2:
                    Imagen = DOS;
                    break;
                case 3:
                    Imagen = TRES;
                    break;
                case 4:
                    Imagen = CUATRO;
                    break;
                case 5:
                    Imagen = CINCO;
                    break;
                case 6:
                    Imagen = SEIS;
                    break;
                case 7:
                    Imagen = SIETE;
                    break;
                case 8:
                    Imagen = OCHO;
                    break;
                case 9:
                    Imagen = NUEVE;
                    break;
                case 10:
                    Imagen = J;
                    break;
                case 11:
                    Imagen = Q;
                    break;
                case 12:
                    Imagen = K;
                    break;
            }
        }
    }
}

