using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGit
{
    class Carta
    {
        //ESTO ES UNA CARTA
        private string nombre;
        private int valor;
        private int codigo;

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
        }
    }
}

