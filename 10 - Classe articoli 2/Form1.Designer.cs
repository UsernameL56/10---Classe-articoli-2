namespace _10___Classe_articoli_2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.codice = new System.Windows.Forms.TextBox();
            this.descrizione = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aggiunta = new System.Windows.Forms.Button();
            this.cartaFedelta = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.annoScadenza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.giorniConsumo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.materiale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.riciclabile = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkBoxAlimentare = new System.Windows.Forms.CheckBox();
            this.checkBoxNonAlimentare = new System.Windows.Forms.CheckBox();
            this.checkBoxAlimentareFresco = new System.Windows.Forms.CheckBox();
            this.Sconto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ricerca = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codice
            // 
            this.codice.Location = new System.Drawing.Point(65, 65);
            this.codice.Margin = new System.Windows.Forms.Padding(4);
            this.codice.Multiline = true;
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(175, 42);
            this.codice.TabIndex = 0;
            // 
            // descrizione
            // 
            this.descrizione.Location = new System.Drawing.Point(303, 65);
            this.descrizione.Margin = new System.Windows.Forms.Padding(4);
            this.descrizione.Multiline = true;
            this.descrizione.Name = "descrizione";
            this.descrizione.Size = new System.Drawing.Size(175, 42);
            this.descrizione.TabIndex = 1;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(527, 65);
            this.prezzo.Margin = new System.Windows.Forms.Padding(4);
            this.prezzo.Multiline = true;
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(175, 42);
            this.prezzo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrizione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezzo";
            // 
            // Aggiunta
            // 
            this.Aggiunta.Location = new System.Drawing.Point(13, 316);
            this.Aggiunta.Margin = new System.Windows.Forms.Padding(4);
            this.Aggiunta.Name = "Aggiunta";
            this.Aggiunta.Size = new System.Drawing.Size(143, 53);
            this.Aggiunta.TabIndex = 6;
            this.Aggiunta.Text = "Aggiungi";
            this.Aggiunta.UseVisualStyleBackColor = true;
            this.Aggiunta.Click += new System.EventHandler(this.Aggiunta_Click);
            // 
            // cartaFedelta
            // 
            this.cartaFedelta.AutoSize = true;
            this.cartaFedelta.Location = new System.Drawing.Point(539, 226);
            this.cartaFedelta.Margin = new System.Windows.Forms.Padding(4);
            this.cartaFedelta.Name = "cartaFedelta";
            this.cartaFedelta.Size = new System.Drawing.Size(73, 20);
            this.cartaFedelta.TabIndex = 7;
            this.cartaFedelta.Text = "Si o No";
            this.cartaFedelta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carta fedeltà";
            // 
            // annoScadenza
            // 
            this.annoScadenza.Location = new System.Drawing.Point(729, 65);
            this.annoScadenza.Margin = new System.Windows.Forms.Padding(4);
            this.annoScadenza.Multiline = true;
            this.annoScadenza.Name = "annoScadenza";
            this.annoScadenza.Size = new System.Drawing.Size(175, 42);
            this.annoScadenza.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Anno scadenza";
            // 
            // giorniConsumo
            // 
            this.giorniConsumo.Location = new System.Drawing.Point(989, 69);
            this.giorniConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.giorniConsumo.Multiline = true;
            this.giorniConsumo.Name = "giorniConsumo";
            this.giorniConsumo.Size = new System.Drawing.Size(175, 42);
            this.giorniConsumo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(985, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giorni Consumo";
            // 
            // materiale
            // 
            this.materiale.Location = new System.Drawing.Point(1209, 69);
            this.materiale.Margin = new System.Windows.Forms.Padding(4);
            this.materiale.Multiline = true;
            this.materiale.Name = "materiale";
            this.materiale.Size = new System.Drawing.Size(175, 42);
            this.materiale.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1205, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Materiale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1425, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Riciclabile";
            // 
            // riciclabile
            // 
            this.riciclabile.AutoSize = true;
            this.riciclabile.Location = new System.Drawing.Point(1429, 91);
            this.riciclabile.Margin = new System.Windows.Forms.Padding(4);
            this.riciclabile.Name = "riciclabile";
            this.riciclabile.Size = new System.Drawing.Size(73, 20);
            this.riciclabile.TabIndex = 16;
            this.riciclabile.Text = "Si o No";
            this.riciclabile.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(527, 262);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1064, 350);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // checkBoxAlimentare
            // 
            this.checkBoxAlimentare.AutoSize = true;
            this.checkBoxAlimentare.Location = new System.Drawing.Point(1571, 46);
            this.checkBoxAlimentare.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAlimentare.Name = "checkBoxAlimentare";
            this.checkBoxAlimentare.Size = new System.Drawing.Size(93, 20);
            this.checkBoxAlimentare.TabIndex = 20;
            this.checkBoxAlimentare.Text = "Alimentare";
            this.checkBoxAlimentare.UseVisualStyleBackColor = true;
            // 
            // checkBoxNonAlimentare
            // 
            this.checkBoxNonAlimentare.AutoSize = true;
            this.checkBoxNonAlimentare.Location = new System.Drawing.Point(1571, 74);
            this.checkBoxNonAlimentare.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNonAlimentare.Name = "checkBoxNonAlimentare";
            this.checkBoxNonAlimentare.Size = new System.Drawing.Size(121, 20);
            this.checkBoxNonAlimentare.TabIndex = 21;
            this.checkBoxNonAlimentare.Text = "Non Alimentare";
            this.checkBoxNonAlimentare.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlimentareFresco
            // 
            this.checkBoxAlimentareFresco.AutoSize = true;
            this.checkBoxAlimentareFresco.Location = new System.Drawing.Point(1571, 102);
            this.checkBoxAlimentareFresco.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAlimentareFresco.Name = "checkBoxAlimentareFresco";
            this.checkBoxAlimentareFresco.Size = new System.Drawing.Size(133, 20);
            this.checkBoxAlimentareFresco.TabIndex = 22;
            this.checkBoxAlimentareFresco.Text = "Alimentare fresco";
            this.checkBoxAlimentareFresco.UseVisualStyleBackColor = true;
            // 
            // Sconto
            // 
            this.Sconto.Location = new System.Drawing.Point(164, 316);
            this.Sconto.Margin = new System.Windows.Forms.Padding(4);
            this.Sconto.Name = "Sconto";
            this.Sconto.Size = new System.Drawing.Size(143, 53);
            this.Sconto.TabIndex = 23;
            this.Sconto.Text = "Sconta";
            this.Sconto.UseVisualStyleBackColor = true;
            this.Sconto.Click += new System.EventHandler(this.Sconto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(997, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Alimentare Fresco";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1205, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "NonAlimentare";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1425, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "NonAlimentare";
            // 
            // ricerca
            // 
            this.ricerca.Location = new System.Drawing.Point(315, 316);
            this.ricerca.Margin = new System.Windows.Forms.Padding(4);
            this.ricerca.Name = "ricerca";
            this.ricerca.Size = new System.Drawing.Size(143, 53);
            this.ricerca.TabIndex = 27;
            this.ricerca.Text = "Ricerca";
            this.ricerca.UseVisualStyleBackColor = true;
            this.ricerca.Click += new System.EventHandler(this.ricerca_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(13, 377);
            this.sort.Margin = new System.Windows.Forms.Padding(4);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(143, 53);
            this.sort.TabIndex = 28;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 639);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.ricerca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sconto);
            this.Controls.Add(this.checkBoxAlimentareFresco);
            this.Controls.Add(this.checkBoxNonAlimentare);
            this.Controls.Add(this.checkBoxAlimentare);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.riciclabile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materiale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.giorniConsumo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.annoScadenza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cartaFedelta);
            this.Controls.Add(this.Aggiunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.descrizione);
            this.Controls.Add(this.codice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codice;
        private System.Windows.Forms.TextBox descrizione;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Aggiunta;
        private System.Windows.Forms.CheckBox cartaFedelta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox annoScadenza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox giorniConsumo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox materiale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox riciclabile;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkBoxAlimentare;
        private System.Windows.Forms.CheckBox checkBoxNonAlimentare;
        private System.Windows.Forms.CheckBox checkBoxAlimentareFresco;
        private System.Windows.Forms.Button Sconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ricerca;
        private System.Windows.Forms.Button sort;
    }
}

