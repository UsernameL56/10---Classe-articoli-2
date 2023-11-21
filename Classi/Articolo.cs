using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Articolo
    {
        //attributi
        protected int _codice;
        protected string _descrizione;
        protected double _prezzoUnitario;

        //metodi accessor
        public int Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public double PrezzoUnitario
        {
            get { return _prezzoUnitario; }
            set { _prezzoUnitario = value; }
        }

        //costruttore
        public Articolo(int _codice, string _descrizione, double _prezzoUnitario)
        {
            Codice = _codice;
            Descrizione = _descrizione;
            PrezzoUnitario = _prezzoUnitario;
        }

        //metodi
        public virtual void Sconta(bool cartaFedelta)
        {
            double sconto;
            if (cartaFedelta)
            {
                sconto = (PrezzoUnitario * 5) / 100;
                PrezzoUnitario -= sconto;
            }
        }
    }
}
