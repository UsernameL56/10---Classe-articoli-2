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
            get { return Codice; }
            set { Codice = value; }
        }
        public string Descrizione
        {
            get { return Descrizione; }
            set { Descrizione = value; }
        }
        public double PrezzoUnitario
        {
            get { return PrezzoUnitario; }
            set { PrezzoUnitario = value; }
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
