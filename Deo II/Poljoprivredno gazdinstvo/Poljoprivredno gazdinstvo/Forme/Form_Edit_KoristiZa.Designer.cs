namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Edit_KoristiZa
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
            this.PonistiIzbor = new System.Windows.Forms.Button();
            this.cBoxPrinos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxMasina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumOd = new System.Windows.Forms.DateTimePicker();
            this.cBoxTrkatori = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumDo = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDatum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PonistiIzbor
            // 
            this.PonistiIzbor.Location = new System.Drawing.Point(362, 264);
            this.PonistiIzbor.Name = "PonistiIzbor";
            this.PonistiIzbor.Size = new System.Drawing.Size(106, 41);
            this.PonistiIzbor.TabIndex = 21;
            this.PonistiIzbor.Text = "Ponisti izbor";
            this.PonistiIzbor.UseVisualStyleBackColor = true;
            this.PonistiIzbor.Click += new System.EventHandler(this.PonistiIzbor_Click);
            // 
            // cBoxPrinos
            // 
            this.cBoxPrinos.FormattingEnabled = true;
            this.cBoxPrinos.Location = new System.Drawing.Point(555, 115);
            this.cBoxPrinos.Name = "cBoxPrinos";
            this.cBoxPrinos.Size = new System.Drawing.Size(178, 24);
            this.cBoxPrinos.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Izaberite iz liste prinos:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(641, 264);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(106, 41);
            this.btnZatvori.TabIndex = 18;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Odaberite vreme pocetka koriscenja:";
            // 
            // cBoxMasina
            // 
            this.cBoxMasina.FormattingEnabled = true;
            this.cBoxMasina.Location = new System.Drawing.Point(299, 115);
            this.cBoxMasina.Name = "cBoxMasina";
            this.cBoxMasina.Size = new System.Drawing.Size(178, 24);
            this.cBoxMasina.TabIndex = 16;
            this.cBoxMasina.SelectedIndexChanged += new System.EventHandler(this.cBoxMasina_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Izaberite iz liste masinu:";
            // 
            // dateTimePickerDatumOd
            // 
            this.dateTimePickerDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumOd.Location = new System.Drawing.Point(49, 238);
            this.dateTimePickerDatumOd.Name = "dateTimePickerDatumOd";
            this.dateTimePickerDatumOd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatumOd.TabIndex = 14;
            // 
            // cBoxTrkatori
            // 
            this.cBoxTrkatori.FormattingEnabled = true;
            this.cBoxTrkatori.Location = new System.Drawing.Point(49, 115);
            this.cBoxTrkatori.Name = "cBoxTrkatori";
            this.cBoxTrkatori.Size = new System.Drawing.Size(178, 24);
            this.cBoxTrkatori.TabIndex = 13;
            this.cBoxTrkatori.SelectedIndexChanged += new System.EventHandler(this.cBoxTrkatori_SelectedIndexChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(500, 264);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(106, 41);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Izaberite iz liste traktor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Odaberite vreme kraja koriscenja:";
            // 
            // dateTimePickerDatumDo
            // 
            this.dateTimePickerDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumDo.Location = new System.Drawing.Point(49, 369);
            this.dateTimePickerDatumDo.Name = "dateTimePickerDatumDo";
            this.dateTimePickerDatumDo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatumDo.TabIndex = 22;
            // 
            // checkBoxDatum
            // 
            this.checkBoxDatum.AutoSize = true;
            this.checkBoxDatum.Location = new System.Drawing.Point(154, 409);
            this.checkBoxDatum.Name = "checkBoxDatum";
            this.checkBoxDatum.Size = new System.Drawing.Size(123, 20);
            this.checkBoxDatum.TabIndex = 24;
            this.checkBoxDatum.Text = "Omoguci datum";
            this.checkBoxDatum.UseVisualStyleBackColor = true;
            this.checkBoxDatum.CheckedChanged += new System.EventHandler(this.checkBoxDatum_CheckedChanged);
            // 
            // Form_Edit_KoristiZa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDatumDo);
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
            this.Name = "Form_Edit_KoristiZa";
            this.Text = "Form_Edit_KoristiZa";
            this.Load += new System.EventHandler(this.Form_Edit_KoristiZa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PonistiIzbor;
        private System.Windows.Forms.ComboBox cBoxPrinos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxMasina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumOd;
        private System.Windows.Forms.ComboBox cBoxTrkatori;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumDo;
        private System.Windows.Forms.CheckBox checkBoxDatum;
    }
}