using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10___Classe_articoli_2
{
    public partial class Form1 : Form
    {
        Articolo articolo;
        Scontrino scontrino;
        int indice;
        public Form1()
        {
            InitializeComponent();
            articolo = new Articolo();
            scontrino = new Scontrino();
            indice = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiunta_Click(object sender, EventArgs e)
        {
            if (checkBoxAlimentare.Checked)
            {
                if (checkBoxAlimentareFresco.Checked)
                {
                    if(string.IsNullOrEmpty(codice.Text) || string.IsNullOrEmpty(descrizione.Text) || string.IsNullOrEmpty(prezzo.Text) || string.IsNullOrEmpty(annoScadenza.Text) || string.IsNullOrEmpty(giorniConsumo.Text))
                    {
                        MessageBox.Show("Sono presenti dei campi mancati; Inseire dati nei seguenti campi: Codice, Descrizione, Prezzo, Anno di Scadenza, Giorni Consumo");
                    }else
                        articolo = new ArticoloFresco(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), cartaFedelta.Checked, int.Parse(annoScadenza.Text), int.Parse(giorniConsumo.Text));
                }
                else
                {
                    if (string.IsNullOrEmpty(codice.Text) || string.IsNullOrEmpty(descrizione.Text) || string.IsNullOrEmpty(prezzo.Text) || string.IsNullOrEmpty(annoScadenza.Text))
                        MessageBox.Show("Sono presenti dei campi mancati; Inseire dati nei seguenti campi: Codice, Descrizione, Prezzo, Anno di Scadenza");
                    else
                        articolo = new ArticoloAlimentare(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), cartaFedelta.Checked, int.Parse(annoScadenza.Text));
                }
                indice++;
            }else if (checkBoxNonAlimentare.Checked)
            {
                if (string.IsNullOrEmpty(codice.Text) || string.IsNullOrEmpty(descrizione.Text) || string.IsNullOrEmpty(prezzo.Text) || string.IsNullOrEmpty(materiale.Text))
                    MessageBox.Show("Sono presenti dei campi mancati; Inseire dati nei seguenti campi: Codice, Descrizione, Prezzo, Materiale");
                else
                    articolo = new ArticoloNonAlimentare(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), cartaFedelta.Checked, materiale.Text, riciclabile.Checked);
                indice++;
            }else if(checkBoxAlimentareFresco.Checked && !checkBoxAlimentare.Checked) 
            {
                MessageBox.Show("Selezionare pure la categoria alimentare");
            }else
            {
                MessageBox.Show("Selezionare una categoria.");
            }

            scontrino.Aggiunta(articolo);

            listView1.Items.Clear();
            if (scontrino != null)
            {
                string[] stringa = new string[100];
                stringa = scontrino.Stringa();
                listView1.Items.Add("Articoli: \n");
                for (int i = 0; i < indice; i++)
                {
                    listView1.Items.Add(stringa[i] + "\n");
                }
            }
        }

        private void Sconto_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (scontrino != null)
            {
                string[] stringa = new string[100];
                stringa = scontrino.Stringa();
                listView1.Items.Add("Articoli: \n");
                for (int i = 0; i < indice; i++)
                {
                    listView1.Items.Add(stringa[i] + "\n");
                }
            }
            listView1.Items.Add("Totale: " + scontrino.Totale(cartaFedelta.Checked));
        }

        private void ricerca_Click(object sender, EventArgs e)
        {
            if (scontrino.Ricerca(descrizione.Text) != -1)
            {
                MessageBox.Show("L'articolo è stato trovato alla riga: " + scontrino.Ricerca(descrizione.Text));
            }
            else
                MessageBox.Show("L'articolo ricercato non è presente");
        }

        private void sort_Click(object sender, EventArgs e)
        {
            scontrino.BubbleSort();
            listView1.Items.Clear();
            if (scontrino != null)
            {
                string[] stringa = new string[100];
                stringa = scontrino.Stringa();
                listView1.Items.Add("Articoli: \n");
                for (int i = 0; i < indice; i++)
                {
                    listView1.Items.Add(stringa[i] + "\n");
                }
            }
        }
    }
}
