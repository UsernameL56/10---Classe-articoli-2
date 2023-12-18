using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class ArticoloAlimentare : Articolo
    {
        // attributi
        protected int _annoScadenza;

        //metodi accessor
        public int AnnoScadenza
        {
            get { return _annoScadenza; }
            set { _annoScadenza = value; }
        }

        //costruttore
        public ArticoloAlimentare(int _codice, string _descrizione, double _prezzoUnitario, bool _cartaFedelta, int _annoScadenza) : base(_codice, _descrizione, _prezzoUnitario, _cartaFedelta)
        {
            AnnoScadenza = _annoScadenza;
        }

        //metodi
        public override double Sconta(bool _cartaFedelta)
        {
            double ScontoBase = base.Sconta(_cartaFedelta);
            if (AnnoScadenza == DateTime.Now.Year)
            {
                return PrezzoUnitario - ((ScontoBase * 20) / 100);
            }
            return ScontoBase;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ArticoloAlimentare articolo2 = (ArticoloAlimentare)obj;
            return AnnoScadenza == articolo2.AnnoScadenza;
        }
        public override string ToString()
        {
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Carta fedelta: {CartaFedelta}, Anno di scadenza: {AnnoScadenza}";
        }
    }
}
