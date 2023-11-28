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
                    array[indice] = new ArticoloFresco(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), int.Parse(annoScadenza.Text), int.Parse(giorniConsumo.Text));
                }
                else
                {
                    array[indice] = new ArticoloAlimentare(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), int.Parse(annoScadenza.Text));
                }
                indice++;
            }else if (checkBoxNonAlimentare.Checked)
            {
                array[indice] = new ArticoloNonAlimentare(int.Parse(codice.Text), descrizione.Text, double.Parse(prezzo.Text), materiale.Text, riciclabile.Checked);
                indice++;
            }
            else
            {
                MessageBox.Show("Selezionare una categoria.");
            }
        }

        private void Visualizzazione_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Articolo articolo in array)
            {
                listView1.Items.Add(articolo.ToString());
            }
        }

        private void Sconto_Click(object sender, EventArgs e)
        {
            foreach (Articolo articolo in array)
            {
                MessageBox.Show($"Prezzo iniziale:{articolo.PrezzoUnitario}\n");
                articolo.Sconta(cartaFedelta.Checked);
                MessageBox.Show($"Prezzo scontato:{articolo.PrezzoUnitario}\n");

            }
        }
    }
}
