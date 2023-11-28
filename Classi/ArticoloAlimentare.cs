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
        public ArticoloAlimentare(int _codice, string _descrizione, double _prezzoUnitario, int _annoScadenza) : base(_codice, _descrizione, _prezzoUnitario)
        {
            AnnoScadenza = _annoScadenza;
        }

        //metodi
        public override void Sconta(bool cartaFedelta)
        {
            double sconto;
            base.Sconta(cartaFedelta);

            if (AnnoScadenza == DateTime.Now.Year)
            {
                sconto = (PrezzoUnitario * 20) / 100;
                PrezzoUnitario -= sconto;
            }
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
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Anno di scadenza: {AnnoScadenza}";
        }
    }
}
