namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_KoristiZa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cBoxTrkatori = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatumOd = new System.Windows.Forms.DateTimePicker();
            this.cBoxMasina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.cBoxPrinos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PonistiIzbor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite iz liste traktor";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(667, 273);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(106, 41);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cBoxTrkatori
            // 
            this.cBoxTrkatori.FormattingEnabled = true;
            this.cBoxTrkatori.Location = new System.Drawing.Point(64, 124);
            this.cBoxTrkatori.Name = "cBoxTrkatori";
            this.cBoxTrkatori.Size = new System.Drawing.Size(178, 24);
            this.cBoxTrkatori.TabIndex = 2;
            this.cBoxTrkatori.SelectedIndexChanged += new System.EventHandler(this.cBoxTrkatori_SelectedIndexChanged);
            // 
            // dateTimePickerDatumOd
            // 
            this.dateTimePickerDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumOd.Location = new System.Drawing.Point(85, 280);
            this.dateTimePickerDatumOd.Name = "dateTimePickerDatumOd";
            this.dateTimePickerDatumOd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatumOd.TabIndex = 3;
            // 
            // cBoxMasina
            // 
            this.cBoxMasina.FormattingEnabled = true;
            this.cBoxMasina.Location = new System.Drawing.Point(401, 124);
            this.cBoxMasina.Name = "cBoxMasina";
            this.cBoxMasina.Size = new System.Drawing.Size(178, 24);
            this.cBoxMasina.TabIndex = 5;
            this.cBoxMasina.SelectedIndexChanged += new System.EventHandler(this.cBoxMasina_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izaberite iz liste masinu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odaberite vreme pocetka koriscenja:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(867, 273);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(106, 41);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // cBoxPrinos
            // 
            this.cBoxPrinos.FormattingEnabled = true;
            this.cBoxPrinos.Location = new System.Drawing.Point(739, 124);
            this.cBoxPrinos.Name = "cBoxPrinos";
            this.cBoxPrinos.Size = new System.Drawing.Size(178, 24);
            this.cBoxPrinos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Izaberite iz liste prinos:";
            // 
            // PonistiIzbor
            // 
            this.PonistiIzbor.Location = new System.Drawing.Point(473, 273);
            this.PonistiIzbor.Name = "PonistiIzbor";
            this.PonistiIzbor.Size = new System.Drawing.Size(106, 41);
            this.PonistiIzbor.TabIndex = 10;
            this.PonistiIzbor.Text = "Ponisti izbor";
            this.PonistiIzbor.UseVisualStyleBackColor = true;
            this.PonistiIzbor.Click += new System.EventHandler(this.PonistiIzbor_Click);
            // 
            // Form_Dodaj_KoristiZa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 397);
            this.Controls.Add(this.PonistiIzbor);
            this.Controls.Add(this.cBoxPrinos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxMasina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDatumOd);
            this.Controls.Add(this.cBoxTrkatori);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dodaj_KoristiZa";
            this.Text = "Dodaj podatak o korišćenju";
            this.Load += new System.EventHandler(this.Form_Dodaj_KoristiZa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cBoxTrkatori;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumOd;
        private System.Windows.Forms.ComboBox cBoxMasina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cBoxPrinos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PonistiIzbor;
    }
}