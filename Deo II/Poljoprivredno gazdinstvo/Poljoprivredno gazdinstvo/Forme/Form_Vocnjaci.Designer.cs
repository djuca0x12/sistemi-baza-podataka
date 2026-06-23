namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Vocnjaci
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
            this.dgvVocnjaci = new System.Windows.Forms.DataGridView();
            this.btnProdajVoćnjak = new System.Windows.Forms.Button();
            this.btnObrisiVocnjak = new System.Windows.Forms.Button();
            this.btnIzmeniVocnjak = new System.Windows.Forms.Button();
            this.btnDodajVocnjak = new System.Windows.Forms.Button();
            this.btnSubvencije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocnjaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVocnjaci
            // 
            this.dgvVocnjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVocnjaci.Location = new System.Drawing.Point(36, 75);
            this.dgvVocnjaci.Name = "dgvVocnjaci";
            this.dgvVocnjaci.ReadOnly = true;
            this.dgvVocnjaci.RowHeadersWidth = 51;
            this.dgvVocnjaci.RowTemplate.Height = 24;
            this.dgvVocnjaci.Size = new System.Drawing.Size(1178, 308);
            this.dgvVocnjaci.TabIndex = 15;
            // 
            // btnProdajVoćnjak
            // 
            this.btnProdajVoćnjak.Location = new System.Drawing.Point(1263, 296);
            this.btnProdajVoćnjak.Name = "btnProdajVoćnjak";
            this.btnProdajVoćnjak.Size = new System.Drawing.Size(243, 41);
            this.btnProdajVoćnjak.TabIndex = 14;
            this.btnProdajVoćnjak.Text = "Proizvedi prinos";
            this.btnProdajVoćnjak.UseVisualStyleBackColor = true;
            this.btnProdajVoćnjak.Click += new System.EventHandler(this.btnProdajVoćnjak_Click);
            // 
            // btnObrisiVocnjak
            // 
            this.btnObrisiVocnjak.Location = new System.Drawing.Point(1263, 207);
            this.btnObrisiVocnjak.Name = "btnObrisiVocnjak";
            this.btnObrisiVocnjak.Size = new System.Drawing.Size(243, 41);
            this.btnObrisiVocnjak.TabIndex = 13;
            this.btnObrisiVocnjak.Text = "Obriši voćnjak";
            this.btnObrisiVocnjak.UseVisualStyleBackColor = true;
            this.btnObrisiVocnjak.Click += new System.EventHandler(this.btnObrisiVocnjak_Click);
            // 
            // btnIzmeniVocnjak
            // 
            this.btnIzmeniVocnjak.Location = new System.Drawing.Point(1263, 118);
            this.btnIzmeniVocnjak.Name = "btnIzmeniVocnjak";
            this.btnIzmeniVocnjak.Size = new System.Drawing.Size(243, 41);
            this.btnIzmeniVocnjak.TabIndex = 12;
            this.btnIzmeniVocnjak.Text = "Izmeni voćnjak";
            this.btnIzmeniVocnjak.UseVisualStyleBackColor = true;
            this.btnIzmeniVocnjak.Click += new System.EventHandler(this.btnIzmeniVocnjak_Click);
            // 
            // btnDodajVocnjak
            // 
            this.btnDodajVocnjak.Location = new System.Drawing.Point(1263, 29);
            this.btnDodajVocnjak.Name = "btnDodajVocnjak";
            this.btnDodajVocnjak.Size = new System.Drawing.Size(243, 41);
            this.btnDodajVocnjak.TabIndex = 11;
            this.btnDodajVocnjak.Text = "Dodaj voćnjak";
            this.btnDodajVocnjak.UseVisualStyleBackColor = true;
            this.btnDodajVocnjak.Click += new System.EventHandler(this.btnDodajVocnjak_Click);
            // 
            // btnSubvencije
            // 
            this.btnSubvencije.Location = new System.Drawing.Point(1263, 363);
            this.btnSubvencije.Name = "btnSubvencije";
            this.btnSubvencije.Size = new System.Drawing.Size(243, 62);
            this.btnSubvencije.TabIndex = 16;
            this.btnSubvencije.Text = "Podnesi zahtev za dobijanje subvencije";
            this.btnSubvencije.UseVisualStyleBackColor = true;
            this.btnSubvencije.Click += new System.EventHandler(this.btnSubvencije_Click);
            // 
            // Form_Vocnjaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 450);
            this.Controls.Add(this.btnSubvencije);
            this.Controls.Add(this.dgvVocnjaci);
            this.Controls.Add(this.btnProdajVoćnjak);
            this.Controls.Add(this.btnObrisiVocnjak);
            this.Controls.Add(this.btnIzmeniVocnjak);
            this.Controls.Add(this.btnDodajVocnjak);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Vocnjaci";
            this.Text = "Voćnjaci";
            this.Load += new System.EventHandler(this.Form_Vocnjaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocnjaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVocnjaci;
        private System.Windows.Forms.Button btnProdajVoćnjak;
        private System.Windows.Forms.Button btnObrisiVocnjak;
        private System.Windows.Forms.Button btnIzmeniVocnjak;
        private System.Windows.Forms.Button btnDodajVocnjak;
        private System.Windows.Forms.Button btnSubvencije;
    }
}