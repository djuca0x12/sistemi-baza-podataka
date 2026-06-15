namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Masine
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnObrisiMasinu = new System.Windows.Forms.Button();
            this.btnDodajMasinu = new System.Windows.Forms.Button();
            this.dataGridViewMasin = new System.Windows.Forms.DataGridView();
            this.btnPromeniMasinu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasin)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1123, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 53);
            this.button4.TabIndex = 11;
            this.button4.Text = "Zatvori";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnObrisiMasinu
            // 
            this.btnObrisiMasinu.Location = new System.Drawing.Point(1123, 203);
            this.btnObrisiMasinu.Name = "btnObrisiMasinu";
            this.btnObrisiMasinu.Size = new System.Drawing.Size(129, 55);
            this.btnObrisiMasinu.TabIndex = 10;
            this.btnObrisiMasinu.Text = "Obrisi masinu";
            this.btnObrisiMasinu.UseVisualStyleBackColor = true;
            this.btnObrisiMasinu.Click += new System.EventHandler(this.btnObrisiMasinu_Click);
            // 
            // btnDodajMasinu
            // 
            this.btnDodajMasinu.Location = new System.Drawing.Point(1123, 313);
            this.btnDodajMasinu.Name = "btnDodajMasinu";
            this.btnDodajMasinu.Size = new System.Drawing.Size(129, 64);
            this.btnDodajMasinu.TabIndex = 9;
            this.btnDodajMasinu.Text = "Dodaj novu masinu";
            this.btnDodajMasinu.UseVisualStyleBackColor = true;
            this.btnDodajMasinu.Click += new System.EventHandler(this.btnDodajMasinu_Click);
            // 
            // dataGridViewMasin
            // 
            this.dataGridViewMasin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasin.Location = new System.Drawing.Point(23, 31);
            this.dataGridViewMasin.Name = "dataGridViewMasin";
            this.dataGridViewMasin.RowHeadersWidth = 51;
            this.dataGridViewMasin.RowTemplate.Height = 24;
            this.dataGridViewMasin.Size = new System.Drawing.Size(1004, 516);
            this.dataGridViewMasin.TabIndex = 8;
            // 
            // btnPromeniMasinu
            // 
            this.btnPromeniMasinu.Location = new System.Drawing.Point(1118, 94);
            this.btnPromeniMasinu.Name = "btnPromeniMasinu";
            this.btnPromeniMasinu.Size = new System.Drawing.Size(134, 57);
            this.btnPromeniMasinu.TabIndex = 7;
            this.btnPromeniMasinu.Text = "Promeni podatke o masini";
            this.btnPromeniMasinu.UseVisualStyleBackColor = true;
            this.btnPromeniMasinu.Click += new System.EventHandler(this.btnPromeniMasinu_Click);
            // 
            // Form_Masine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 618);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnObrisiMasinu);
            this.Controls.Add(this.btnDodajMasinu);
            this.Controls.Add(this.dataGridViewMasin);
            this.Controls.Add(this.btnPromeniMasinu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Masine";
            this.Text = "Form_Masine";
            this.Load += new System.EventHandler(this.Form_Masine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnObrisiMasinu;
        private System.Windows.Forms.Button btnDodajMasinu;
        private System.Windows.Forms.DataGridView dataGridViewMasin;
        private System.Windows.Forms.Button btnPromeniMasinu;
    }
}