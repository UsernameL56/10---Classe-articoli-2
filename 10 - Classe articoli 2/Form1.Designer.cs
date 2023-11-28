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
            this.Visualizzazione = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkBoxAlimentare = new System.Windows.Forms.CheckBox();
            this.checkBoxNonAlimentare = new System.Windows.Forms.CheckBox();
            this.checkBoxAlimentareFresco = new System.Windows.Forms.CheckBox();
            this.Sconto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codice
            // 
            this.codice.Location = new System.Drawing.Point(49, 53);
            this.codice.Multiline = true;
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(132, 35);
            this.codice.TabIndex = 0;
            // 
            // descrizione
            // 
            this.descrizione.Location = new System.Drawing.Point(227, 53);
            this.descrizione.Multiline = true;
            this.descrizione.Name = "descrizione";
            this.descrizione.Size = new System.Drawing.Size(132, 35);
            this.descrizione.TabIndex = 1;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(395, 53);
            this.prezzo.Multiline = true;
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(132, 35);
            this.prezzo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrizione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezzo";
            // 
            // Aggiunta
            // 
            this.Aggiunta.Location = new System.Drawing.Point(49, 233);
            this.Aggiunta.Name = "Aggiunta";
            this.Aggiunta.Size = new System.Drawing.Size(107, 43);
            this.Aggiunta.TabIndex = 6;
            this.Aggiunta.Text = "Aggiungi";
            this.Aggiunta.UseVisualStyleBackColor = true;
            this.Aggiunta.Click += new System.EventHandler(this.Aggiunta_Click);
            // 
            // cartaFedelta
            // 
            this.cartaFedelta.AutoSize = true;
            this.cartaFedelta.Location = new System.Drawing.Point(575, 71);
            this.cartaFedelta.Name = "cartaFedelta";
            this.cartaFedelta.Size = new System.Drawing.Size(61, 17);
            this.cartaFedelta.TabIndex = 7;
            this.cartaFedelta.Text = "Si o No";
            this.cartaFedelta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carta fedeltà";
            // 
            // annoScadenza
            // 
            this.annoScadenza.Location = new System.Drawing.Point(707, 50);
            this.annoScadenza.Multiline = true;
            this.annoScadenza.Name = "annoScadenza";
            this.annoScadenza.Size = new System.Drawing.Size(132, 35);
            this.annoScadenza.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Anno scadenza";
            // 
            // giorniConsumo
            // 
            this.giorniConsumo.Location = new System.Drawing.Point(902, 53);
            this.giorniConsumo.Multiline = true;
            this.giorniConsumo.Name = "giorniConsumo";
            this.giorniConsumo.Size = new System.Drawing.Size(132, 35);
            this.giorniConsumo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(899, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giorni Consumo";
            // 
            // materiale
            // 
            this.materiale.Location = new System.Drawing.Point(1067, 53);
            this.materiale.Multiline = true;
            this.materiale.Name = "materiale";
            this.materiale.Size = new System.Drawing.Size(132, 35);
            this.materiale.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1064, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Materiale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1229, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Riciclabile";
            // 
            // riciclabile
            // 
            this.riciclabile.AutoSize = true;
            this.riciclabile.Location = new System.Drawing.Point(1232, 71);
            this.riciclabile.Name = "riciclabile";
            this.riciclabile.Size = new System.Drawing.Size(61, 17);
            this.riciclabile.TabIndex = 16;
            this.riciclabile.Text = "Si o No";
            this.riciclabile.UseVisualStyleBackColor = true;
            // 
            // Visualizzazione
            // 
            this.Visualizzazione.Location = new System.Drawing.Point(189, 233);
            this.Visualizzazione.Name = "Visualizzazione";
            this.Visualizzazione.Size = new System.Drawing.Size(107, 43);
            this.Visualizzazione.TabIndex = 18;
            this.Visualizzazione.Text = "Visualizza";
            this.Visualizzazione.UseVisualStyleBackColor = true;
            this.Visualizzazione.Click += new System.EventHandler(this.Visualizzazione_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(538, 233);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 285);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // checkBoxAlimentare
            // 
            this.checkBoxAlimentare.AutoSize = true;
            this.checkBoxAlimentare.Location = new System.Drawing.Point(1321, 37);
            this.checkBoxAlimentare.Name = "checkBoxAlimentare";
            this.checkBoxAlimentare.Size = new System.Drawing.Size(75, 17);
            this.checkBoxAlimentare.TabIndex = 20;
            this.checkBoxAlimentare.Text = "Alimentare";
            this.checkBoxAlimentare.UseVisualStyleBackColor = true;
            // 
            // checkBoxNonAlimentare
            // 
            this.checkBoxNonAlimentare.AutoSize = true;
            this.checkBoxNonAlimentare.Location = new System.Drawing.Point(1321, 60);
            this.checkBoxNonAlimentare.Name = "checkBoxNonAlimentare";
            this.checkBoxNonAlimentare.Size = new System.Drawing.Size(98, 17);
            this.checkBoxNonAlimentare.TabIndex = 21;
            this.checkBoxNonAlimentare.Text = "Non Alimentare";
            this.checkBoxNonAlimentare.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlimentareFresco
            // 
            this.checkBoxAlimentareFresco.AutoSize = true;
            this.checkBoxAlimentareFresco.Location = new System.Drawing.Point(1321, 83);
            this.checkBoxAlimentareFresco.Name = "checkBoxAlimentareFresco";
            this.checkBoxAlimentareFresco.Size = new System.Drawing.Size(107, 17);
            this.checkBoxAlimentareFresco.TabIndex = 22;
            this.checkBoxAlimentareFresco.Text = "Alimentare fresco";
            this.checkBoxAlimentareFresco.UseVisualStyleBackColor = true;
            // 
            // Sconto
            // 
            this.Sconto.Location = new System.Drawing.Point(324, 233);
            this.Sconto.Name = "Sconto";
            this.Sconto.Size = new System.Drawing.Size(107, 43);
            this.Sconto.TabIndex = 23;
            this.Sconto.Text = "Sconta";
            this.Sconto.UseVisualStyleBackColor = true;
            this.Sconto.Click += new System.EventHandler(this.Sconto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 621);
            this.Controls.Add(this.Sconto);
            this.Controls.Add(this.checkBoxAlimentareFresco);
            this.Controls.Add(this.checkBoxNonAlimentare);
            this.Controls.Add(this.checkBoxAlimentare);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Visualizzazione);
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
        private System.Windows.Forms.Button Visualizzazione;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkBoxAlimentare;
        private System.Windows.Forms.CheckBox checkBoxNonAlimentare;
        private System.Windows.Forms.CheckBox checkBoxAlimentareFresco;
        private System.Windows.Forms.Button Sconto;
    }
}

