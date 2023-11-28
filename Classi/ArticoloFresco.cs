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
            base.Sconta(cartaFedelta);
            double sconto = 10;
            for(int i = 0; i < 5 && i <_giornoConsumo; i++)
            {
                sconto -= 2*i;
            }
            sconto = (PrezzoUnitario * sconto) / 100;
            PrezzoUnitario -= sconto;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ArticoloFresco articolo2 = (ArticoloFresco)obj;
            return GiornoConsumo == articolo2.GiornoConsumo;
        }
        public override string ToString()
        {
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Anno di scadenza: {AnnoScadenza}, Giorni consumo: {GiornoConsumo}";
        }
    }
}
