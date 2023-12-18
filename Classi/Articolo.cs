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
        protected bool _cartaFedelta;

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
        public bool CartaFedelta
        {
            get { return _cartaFedelta; }
            set { _cartaFedelta = value;}
        }

        //costruttore
        public Articolo()
        {
            Codice += 1;
            Descrizione = string.Empty;
            PrezzoUnitario = 0;
            CartaFedelta = false;
        }
        public Articolo(int _codice, string _descrizione, double _prezzoUnitario, bool _cartaFedelta)
        {
            Codice = _codice;
            Descrizione = _descrizione;
            PrezzoUnitario = _prezzoUnitario;
            CartaFedelta = _cartaFedelta;
        }

        //metodi
        public virtual double Sconta(bool _cartaFedelta)
        {
            if (_cartaFedelta)
            {
                return PrezzoUnitario - ((PrezzoUnitario * 5) / 100);
            }
            return PrezzoUnitario;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType()) 
                return false;

            Articolo articolo2 = (Articolo)obj;
            return Codice == articolo2.Codice;
        }

        public override string ToString()
        {
            return $"Codice: {Codice}, Descrizione: {Descrizione}, Prezzo Unitario: {PrezzoUnitario}, Carta fedelta: {CartaFedelta}";
        }
    }
}
