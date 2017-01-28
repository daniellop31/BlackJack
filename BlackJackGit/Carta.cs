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

        public Carta(int codigo)
        {
            this.codigo = codigo;
            this.Nombre = Procesos.codigoCartas[codigo];
            if (codigo == 0)
                valor = 11;
            else if (codigo >= 1 && codigo <= 9)
                valor = codigo;
            else
                valor = 10;
        }
    }
}

