namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Dodaj_Traktor
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
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.numGodinaProizvodnje = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numSnaga = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numRadniSati = new System.Windows.Forms.NumericUpDown();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtBrojMotora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaProizvodnje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadniSati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj sasije:";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(146, 60);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(121, 22);
            this.txtBrojSasije.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(146, 186);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(121, 22);
            this.txtKomentar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Komentar:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(145, 256);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "u upotrebi",
            "u kvraru",
            "na servisu",
            "prodat"});
            this.cBoxStatus.Location = new System.Drawing.Point(146, 128);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.cBoxStatus.TabIndex = 8;
            // 
            // dateDatumKupovine
            // 
            this.dateDatumKupovine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDatumKupovine.Location = new System.Drawing.Point(534, 60);
            this.dateDatumKupovine.Name = "dateDatumKupovine";
            this.dateDatumKupovine.Size = new System.Drawing.Size(159, 22);
            this.dateDatumKupovine.TabIndex = 9;
            // 
            // numGodinaProizvodnje
            // 
            this.numGodinaProizvodnje.Location = new System.Drawing.Point(534, 134);
            this.numGodinaProizvodnje.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numGodinaProizvodnje.Name = "numGodinaProizvodnje";
            this.numGodinaProizvodnje.Size = new System.Drawing.Size(159, 22);
            this.numGodinaProizvodnje.TabIndex = 10;
            this.numGodinaProizvodnje.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum kupovine:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Godina proizvodnje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Snaga:";
            // 
            // numSnaga
            // 
            this.numSnaga.Location = new System.Drawing.Point(146, 326);
            this.numSnaga.Name = "numSnaga";
            this.numSnaga.Size = new System.Drawing.Size(121, 22);
            this.numSnaga.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Broj motora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Radni sati:";
            // 
            // numRadniSati
            // 
            this.numRadniSati.Location = new System.Drawing.Point(534, 206);
            this.numRadniSati.Name = "numRadniSati";
            this.numRadniSati.Size = new System.Drawing.Size(159, 22);
            this.numRadniSati.TabIndex = 19;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(445, 332);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(99, 35);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtBrojMotora
            // 
            this.txtBrojMotora.Location = new System.Drawing.Point(146, 394);
            this.txtBrojMotora.Name = "txtBrojMotora";
            this.txtBrojMotora.Size = new System.Drawing.Size(121, 22);
            this.txtBrojMotora.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Otkazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Dodaj_Traktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBrojMotora);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numRadniSati);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numSnaga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numGodinaProizvodnje);
            this.Controls.Add(this.dateDatumKupovine);
            this.Controls.Add(this.cBoxStatus);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dodaj_Traktor";
            this.Text = "Form_Add_Traktor";
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaProizvodnje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadniSati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.DateTimePicker dateDatumKupovine;
        private System.Windows.Forms.NumericUpDown numGodinaProizvodnje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSnaga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numRadniSati;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtBrojMotora;
        private System.Windows.Forms.Button button1;
    }
}