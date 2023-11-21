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
            set { Materiale = value; }
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

    }
}
