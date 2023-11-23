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
        private Articolo[] array;
        int _codice;
        string _descrizione;
        double _prezzoUnitario;
        bool _cartaFedelta;
        private int indice;
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
            _codice = int.Parse(codice.Text);
            _descrizione = descrizione.Text;
            _prezzoUnitario = int.Parse(prezzo.Text);
            _cartaFedelta = cartaFedelta.Checked;
        }
    }
}
