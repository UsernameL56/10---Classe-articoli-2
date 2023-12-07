using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Scontrino
    {
        // attributi
        public Articolo[] _articolo;
        public int indice;

        // costruttore
        public Scontrino()
        {
            _articolo = new Articolo[100];
        }

        public void Aggiunta(Articolo parametro)
        {
            _articolo[indice] = parametro;
            indice++;
        }
    }
}
