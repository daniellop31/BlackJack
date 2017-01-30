using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGit
{
    class Procesos
    {
        //Arrelgo para identificar cada carta
        private static string[] codigoCartas = new string[13];
        
        public static string[] CodigoCartas
        {
            get
            {
                return codigoCartas;
            }

            set
            {
                codigoCartas = value;
            }
        }

        /// <summary>
        /// Inicializa el arreglo de las cartas, es para invocarse
        /// Se invoca al iniciar el programa
        /// </summary>
        public static void iniciarArreglo()
        {
            CodigoCartas[0] = "A";
            CodigoCartas[1] = "Uno";
            CodigoCartas[2] = "Dos";
            CodigoCartas[3] = "Tres";
            CodigoCartas[4] = "Cuatro";
            CodigoCartas[5] = "Cinco";
            CodigoCartas[6] = "Seis";
            CodigoCartas[7] = "Siete";
            CodigoCartas[8] = "Ocho";
            CodigoCartas[9] = "Nueve";
            CodigoCartas[10] = "J";
            CodigoCartas[11] = "Q";
            CodigoCartas[12] = "K";
        }        

        /// <summary>
        /// Hará que solo se puedan escribir textos 
        /// </summary>
        /// <param name="e">Un evento KeyPress de un textbox</param>
        public static void validarTexto(KeyPressEventArgs e)
        {/*
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;*/
            e.Handled = !(Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// Hará que solo se puedan escribir numeros
        /// </summary>
        /// <param name="e">Evento de KeyPress de un textobox</param>
        public static void validarNumero(KeyPressEventArgs e)
        {/*
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;*/
            e.Handled = !(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar));
        }
    }
}

