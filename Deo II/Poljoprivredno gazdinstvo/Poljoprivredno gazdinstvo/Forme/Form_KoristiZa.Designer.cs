namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_KoristiZa
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
            this.dataGridViewPrikaz = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrikaz
            // 
            this.dataGridViewPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrikaz.Location = new System.Drawing.Point(22, 24);
            this.dataGridViewPrikaz.Name = "dataGridViewPrikaz";
            this.dataGridViewPrikaz.RowHeadersWidth = 51;
            this.dataGridViewPrikaz.RowTemplate.Height = 24;
            this.dataGridViewPrikaz.Size = new System.Drawing.Size(740, 466);
            this.dataGridViewPrikaz.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj podatak o koriscenju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(905, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Promeni podatke o koriscenju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(949, 446);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(86, 44);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Poljoprivredno_gazdinstvo.Properties.Resources.KoristiZa1_ig_thumbnail_161_161;
            this.button3.Location = new System.Drawing.Point(850, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 194);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(919, 382);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(116, 44);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi podatak";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form_KoristiZa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 502);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPrikaz);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_KoristiZa";
            this.Text = "Form_KoristiZa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrikaz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnObrisi;
    }
}