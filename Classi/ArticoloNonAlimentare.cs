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
            get { return Materiale; }
            set { _materiale = value; }
        }
        public bool Riciclabile
        {
            get { return _riciclabile; }
            set { _riciclabile = value;}
        }

        // costruttore
        public ArticoloNonAlimentare(int _codice, string _descrizione, double _prezzoUnitario, string _materiale, bool _riciclabile) :base(_codice, _descrizione, _prezzoUnitario)
        {
            Materiale = _materiale;
            Riciclabile = _riciclabile;
        }

        // metodi
        public override void Sconta(bool cartaFedelta)
        {
            double sconto;
            base.Sconta(cartaFedelta);
            if(Riciclabile) 
            {
                sconto = (PrezzoUnitario * 10) / 100;
                PrezzoUnitario -= sconto;
            }
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
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Materiale: {Materiale}, Riciclabile: {Riciclabile}";
        }

    }
}
