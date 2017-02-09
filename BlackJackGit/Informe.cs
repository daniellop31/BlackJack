using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGit
{
    class Informe
    {
        private static Informe instance = new Informe();

        private Informe() { }

        public static Informe getInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
