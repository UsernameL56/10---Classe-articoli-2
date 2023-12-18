using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class ArticoloNonAlimentare : Articolo
    {
        private string _materiale;
        private bool _riciclabile;

        // metodi accessor
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public bool Riciclabile
        {
            get { return _riciclabile; }
            set { _riciclabile = value;}
        }

        // costruttore
        public ArticoloNonAlimentare(int _codice, string _descrizione, double _prezzoUnitario, bool _cartaFedelta, string _materiale, bool _riciclabile) :base(_codice, _descrizione, _prezzoUnitario, _cartaFedelta)
        {
            Materiale = _materiale;
            Riciclabile = _riciclabile;
        }

        // metodi
        public override double Sconta(bool _cartaFedelta)
        {
            double ScontoBase = base.Sconta(_cartaFedelta);
            if(Riciclabile) 
            {
                return PrezzoUnitario - ((ScontoBase * 10) / 100);
            }
            return ScontoBase;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ArticoloNonAlimentare articolo2 = (ArticoloNonAlimentare)obj;
            return Materiale == articolo2.Materiale;
        }
        public override string ToString()
        {
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Carta fedelta: {CartaFedelta}, Materiale: {Materiale}, Riciclabile: {Riciclabile}";
        }

    }
}
