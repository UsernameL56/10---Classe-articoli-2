using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class ArticoloFresco : ArticoloAlimentare
    {
        // attributi
        private int _giornoConsumo;

        // metodi accessor
        public int GiornoConsumo
        {
            get { return _giornoConsumo; }
            set { _giornoConsumo = value; }
        }

        // costruttore
        public ArticoloFresco(int _codice, string _descrizione, double _prezzoUnitario, int _annoScadenza, int _giornoConsumo) : base(_codice, _descrizione, _prezzoUnitario, _annoScadenza)
        {
            GiornoConsumo = _giornoConsumo;
        }

        // metodi
        public override void Sconta(bool cartaFedelta)
        {

        }
    }
}
