namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Edit_Masina
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
            this.label7 = new System.Windows.Forms.Label();
            this.numBrojTockova = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numGodinaProizvodnje = new System.Windows.Forms.NumericUpDown();
            this.dateDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojTockova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaProizvodnje)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Broj tockova:";
            // 
            // numBrojTockova
            // 
            this.numBrojTockova.Location = new System.Drawing.Point(679, 207);
            this.numBrojTockova.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numBrojTockova.Name = "numBrojTockova";
            this.numBrojTockova.Size = new System.Drawing.Size(159, 22);
            this.numBrojTockova.TabIndex = 60;
            this.numBrojTockova.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 59;
            this.button1.Text = "Otkazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(287, 353);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(112, 35);
            this.btnSacuvaj.TabIndex = 58;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Godina proizvodnje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Datum kupovine:";
            // 
            // numGodinaProizvodnje
            // 
            this.numGodinaProizvodnje.Location = new System.Drawing.Point(679, 139);
            this.numGodinaProizvodnje.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numGodinaProizvodnje.Name = "numGodinaProizvodnje";
            this.numGodinaProizvodnje.Size = new System.Drawing.Size(159, 22);
            this.numGodinaProizvodnje.TabIndex = 55;
            this.numGodinaProizvodnje.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // dateDatumKupovine
            // 
            this.dateDatumKupovine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDatumKupovine.Location = new System.Drawing.Point(679, 65);
            this.dateDatumKupovine.Name = "dateDatumKupovine";
            this.dateDatumKupovine.Size = new System.Drawing.Size(159, 22);
            this.dateDatumKupovine.TabIndex = 54;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "u upotrebi",
            "u kvaru",
            "na servisu",
            "prodat"});
            this.cBoxStatus.Location = new System.Drawing.Point(198, 131);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.cBoxStatus.TabIndex = 53;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(197, 259);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Model:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(198, 189);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(121, 22);
            this.txtKomentar.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Komentar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status:";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(198, 63);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(121, 22);
            this.txtBrojSasije.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Broj sasije:";
            // 
            // Form_Edit_Masina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numBrojTockova);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSacuvaj);
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
            this.Name = "Form_Edit_Masina";
            this.Text = "Promeni podatke o masini";
            ((System.ComponentModel.ISupportInitialize)(this.numBrojTockova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaProizvodnje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBrojTockova;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numGodinaProizvodnje;
        private System.Windows.Forms.DateTimePicker dateDatumKupovine;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label label1;
    }
}