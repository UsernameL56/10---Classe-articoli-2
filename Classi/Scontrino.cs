using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Scontrino
    {
        // attributi
        public Articolo[] _articolo;
        public int indice;

        // metodi accessor

        public Articolo[] Articolo
        {
            get { return _articolo; }
            set { _articolo = value;}
        }

        // costruttore
        public Scontrino()
        {
            Articolo = new Articolo[100];
        }

        // metodi
        public void Aggiunta(Articolo parametro)
        {
            Articolo[indice] = parametro;
            indice++;
        }

        public string[] Stringa()
        {
            string[] temp = new string[100];
            for(int i = 0; i < indice; i++)
            {
                temp[i] += $"{i+1}. {Articolo[i].ToString()}";
            }
            return temp;
        }

        public double Totale(bool _cartaFedelta)
        {
            double totale = 0;
            for (int i = 0; i < indice; i++)
            {
                totale += Articolo[i].Sconta(_cartaFedelta);
            }
            return totale;
        }

        public void BubbleSort()
        {
            for(int i = 0; i < indice; i++)
            {
                for (int j = 0; j < indice; j++)
                {
                    if (Articolo[j].PrezzoUnitario > Articolo[j + 1].PrezzoUnitario)
                    {
                        Articolo[indice + 1] = Articolo[j];
                        Articolo[j] = Articolo[j + 1];
                        Articolo[j + 1] = Articolo[indice + 1];
                    }

                }
            }
            Stringa();
        }
        public int Ricerca(string descrizione)
        {
            for(int i = 0; i < indice; i++)
            {
                if (Articolo[i].Descrizione == descrizione)
                {
                    return i+1;
                    break;
                }
            }
            return -1;
        }
    }
}
