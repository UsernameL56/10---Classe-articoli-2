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
            set 
            {
                if(_giornoConsumo>0 && _giornoConsumo <=5)
                    _giornoConsumo = value; 
            }
        }

        // costruttore
        public ArticoloFresco(int _codice, string _descrizione, double _prezzoUnitario, bool _cartaFedelta, int _annoScadenza, int _giornoConsumo) : base(_codice, _descrizione, _prezzoUnitario, _cartaFedelta, _annoScadenza)
        {
            GiornoConsumo = _giornoConsumo;
        }

        // metodi
        public override double Sconta(bool _cartaFedelta)
        {
            double ScontoBase = base.Sconta(_cartaFedelta);
            double sconto = 10;
            for(int i = 0; i < 5 && i <_giornoConsumo; i++)
            {
                sconto -= 2*i;
            }
            return ScontoBase - ((ScontoBase * sconto) / 100);
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
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Carta fedelta: {CartaFedelta}, Anno di scadenza: {AnnoScadenza}, Giorni consumo: {GiornoConsumo}";
        }
    }
}
