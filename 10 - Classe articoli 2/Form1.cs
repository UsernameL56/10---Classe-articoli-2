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

namespace _10___Classe_articoli_2
{
    public partial class Form1 : Form
    {
        Articolo[] array;
        int indice;
        public Form1()
        {
            InitializeComponent();
            array = new Articolo[100];
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
                        array[indice] = new ArticoloFresco(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), cartaFedelta.Checked, int.Parse(annoScadenza.Text), int.Parse(giorniConsumo.Text));
                }
                else
                {
                    if (string.IsNullOrEmpty(codice.Text) || string.IsNullOrEmpty(descrizione.Text) || string.IsNullOrEmpty(prezzo.Text) || string.IsNullOrEmpty(annoScadenza.Text))
                        MessageBox.Show("Sono presenti dei campi mancati; Inseire dati nei seguenti campi: Codice, Descrizione, Prezzo, Anno di Scadenza");
                    else
                        array[indice] = new ArticoloAlimentare(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), cartaFedelta.Checked, int.Parse(annoScadenza.Text));
                }
                indice++;
            }else if (checkBoxNonAlimentare.Checked)
            {
                if (string.IsNullOrEmpty(codice.Text) || string.IsNullOrEmpty(descrizione.Text) || string.IsNullOrEmpty(prezzo.Text) || string.IsNullOrEmpty(materiale.Text))
                    MessageBox.Show("Sono presenti dei campi mancati; Inseire dati nei seguenti campi: Codice, Descrizione, Prezzo, Materiale");
                else
                    array[indice] = new ArticoloNonAlimentare(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), cartaFedelta.Checked, materiale.Text, riciclabile.Checked);
                indice++;
            }else if(checkBoxAlimentareFresco.Checked && !checkBoxAlimentare.Checked) 
            {
                MessageBox.Show("Selezionare pure la categoria alimentare");
            }else
            {
                MessageBox.Show("Selezionare una categoria.");
            }
        }

        private void Visualizzazione_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if(array != null)
            {
                foreach (var articolo in array)
                {
                    if(articolo != null)
                        listView1.Items.Add(articolo.ToString());
                }
            }
        }

        private void Sconto_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (array != null)
            {
                foreach (var articolo in array)
                {
                    if (articolo != null)
                    {
                        articolo.Sconta(cartaFedelta.Checked);
                        listView1.Items.Add(articolo.ToString());
                    }           
                }
            }
        }
    }
}
