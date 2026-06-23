namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Povrce
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
            this.dgvPovrce = new System.Windows.Forms.DataGridView();
            this.btnProdajPovrce = new System.Windows.Forms.Button();
            this.btnObrisiPovrce = new System.Windows.Forms.Button();
            this.btnIzmeniPovrce = new System.Windows.Forms.Button();
            this.btnDodajPovrce = new System.Windows.Forms.Button();
            this.btnSubvencije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovrce)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPovrce
            // 
            this.dgvPovrce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovrce.Location = new System.Drawing.Point(45, 80);
            this.dgvPovrce.Name = "dgvPovrce";
            this.dgvPovrce.ReadOnly = true;
            this.dgvPovrce.RowHeadersWidth = 51;
            this.dgvPovrce.RowTemplate.Height = 24;
            this.dgvPovrce.Size = new System.Drawing.Size(1178, 358);
            this.dgvPovrce.TabIndex = 15;
            // 
            // btnProdajPovrce
            // 
            this.btnProdajPovrce.Location = new System.Drawing.Point(1266, 292);
            this.btnProdajPovrce.Name = "btnProdajPovrce";
            this.btnProdajPovrce.Size = new System.Drawing.Size(236, 41);
            this.btnProdajPovrce.TabIndex = 14;
            this.btnProdajPovrce.Text = "Proizvedi prinos";
            this.btnProdajPovrce.UseVisualStyleBackColor = true;
            this.btnProdajPovrce.Click += new System.EventHandler(this.btnProdajPovrce_Click);
            // 
            // btnObrisiPovrce
            // 
            this.btnObrisiPovrce.Location = new System.Drawing.Point(1266, 203);
            this.btnObrisiPovrce.Name = "btnObrisiPovrce";
            this.btnObrisiPovrce.Size = new System.Drawing.Size(236, 41);
            this.btnObrisiPovrce.TabIndex = 13;
            this.btnObrisiPovrce.Text = "Obriši povrće";
            this.btnObrisiPovrce.UseVisualStyleBackColor = true;
            this.btnObrisiPovrce.Click += new System.EventHandler(this.btnObrisiPovrce_Click);
            // 
            // btnIzmeniPovrce
            // 
            this.btnIzmeniPovrce.Location = new System.Drawing.Point(1266, 115);
            this.btnIzmeniPovrce.Name = "btnIzmeniPovrce";
            this.btnIzmeniPovrce.Size = new System.Drawing.Size(236, 41);
            this.btnIzmeniPovrce.TabIndex = 12;
            this.btnIzmeniPovrce.Text = "Izmeni povrće";
            this.btnIzmeniPovrce.UseVisualStyleBackColor = true;
            this.btnIzmeniPovrce.Click += new System.EventHandler(this.btnIzmeniPovrce_Click);
            // 
            // btnDodajPovrce
            // 
            this.btnDodajPovrce.Location = new System.Drawing.Point(1266, 25);
            this.btnDodajPovrce.Name = "btnDodajPovrce";
            this.btnDodajPovrce.Size = new System.Drawing.Size(236, 41);
            this.btnDodajPovrce.TabIndex = 11;
            this.btnDodajPovrce.Text = "Dodaj povrće";
            this.btnDodajPovrce.UseVisualStyleBackColor = true;
            this.btnDodajPovrce.Click += new System.EventHandler(this.btnDodajPovrce_Click);
            // 
            // btnSubvencije
            // 
            this.btnSubvencije.Location = new System.Drawing.Point(1266, 374);
            this.btnSubvencije.Name = "btnSubvencije";
            this.btnSubvencije.Size = new System.Drawing.Size(236, 84);
            this.btnSubvencije.TabIndex = 16;
            this.btnSubvencije.Text = "Podnesi zahtev za dobijanje subvencije";
            this.btnSubvencije.UseVisualStyleBackColor = true;
            this.btnSubvencije.Click += new System.EventHandler(this.btnSubvencije_Click);
            // 
            // Form_Povrce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 483);
            this.Controls.Add(this.btnSubvencije);
            this.Controls.Add(this.dgvPovrce);
            this.Controls.Add(this.btnProdajPovrce);
            this.Controls.Add(this.btnObrisiPovrce);
            this.Controls.Add(this.btnIzmeniPovrce);
            this.Controls.Add(this.btnDodajPovrce);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Povrce";
            this.Text = "Povrće";
            this.Load += new System.EventHandler(this.Form_Povrce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovrce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPovrce;
        private System.Windows.Forms.Button btnProdajPovrce;
        private System.Windows.Forms.Button btnObrisiPovrce;
        private System.Windows.Forms.Button btnIzmeniPovrce;
        private System.Windows.Forms.Button btnDodajPovrce;
        private System.Windows.Forms.Button btnSubvencije;
    }
}