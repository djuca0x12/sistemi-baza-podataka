namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Zitarice
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
            this.dgvZitarice = new System.Windows.Forms.DataGridView();
            this.btnProdajZitaricu = new System.Windows.Forms.Button();
            this.btnObrisiZitaricu = new System.Windows.Forms.Button();
            this.btnIzmeniZitaricu = new System.Windows.Forms.Button();
            this.btnDodajZitaricu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZitarice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZitarice
            // 
            this.dgvZitarice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZitarice.Location = new System.Drawing.Point(27, 70);
            this.dgvZitarice.Name = "dgvZitarice";
            this.dgvZitarice.ReadOnly = true;
            this.dgvZitarice.RowHeadersWidth = 51;
            this.dgvZitarice.RowTemplate.Height = 24;
            this.dgvZitarice.Size = new System.Drawing.Size(1178, 308);
            this.dgvZitarice.TabIndex = 10;
            // 
            // btnProdajZitaricu
            // 
            this.btnProdajZitaricu.Location = new System.Drawing.Point(1254, 337);
            this.btnProdajZitaricu.Name = "btnProdajZitaricu";
            this.btnProdajZitaricu.Size = new System.Drawing.Size(154, 41);
            this.btnProdajZitaricu.TabIndex = 9;
            this.btnProdajZitaricu.Text = "Prodaj žitaricu";
            this.btnProdajZitaricu.UseVisualStyleBackColor = true;
            this.btnProdajZitaricu.Click += new System.EventHandler(this.btnProdajZitaricu_Click);
            // 
            // btnObrisiZitaricu
            // 
            this.btnObrisiZitaricu.Location = new System.Drawing.Point(1254, 248);
            this.btnObrisiZitaricu.Name = "btnObrisiZitaricu";
            this.btnObrisiZitaricu.Size = new System.Drawing.Size(154, 41);
            this.btnObrisiZitaricu.TabIndex = 8;
            this.btnObrisiZitaricu.Text = "Obriši žitaricu";
            this.btnObrisiZitaricu.UseVisualStyleBackColor = true;
            this.btnObrisiZitaricu.Click += new System.EventHandler(this.btnObrisiZitaricu_Click);
            // 
            // btnIzmeniZitaricu
            // 
            this.btnIzmeniZitaricu.Location = new System.Drawing.Point(1254, 159);
            this.btnIzmeniZitaricu.Name = "btnIzmeniZitaricu";
            this.btnIzmeniZitaricu.Size = new System.Drawing.Size(154, 41);
            this.btnIzmeniZitaricu.TabIndex = 7;
            this.btnIzmeniZitaricu.Text = "Izmeni žitaricu";
            this.btnIzmeniZitaricu.UseVisualStyleBackColor = true;
            this.btnIzmeniZitaricu.Click += new System.EventHandler(this.btnIzmeniZitaricu_Click);
            // 
            // btnDodajZitaricu
            // 
            this.btnDodajZitaricu.Location = new System.Drawing.Point(1254, 70);
            this.btnDodajZitaricu.Name = "btnDodajZitaricu";
            this.btnDodajZitaricu.Size = new System.Drawing.Size(154, 41);
            this.btnDodajZitaricu.TabIndex = 6;
            this.btnDodajZitaricu.Text = "Dodaj žitaricu";
            this.btnDodajZitaricu.UseVisualStyleBackColor = true;
            this.btnDodajZitaricu.Click += new System.EventHandler(this.btnDodajZitaricu_Click);
            // 
            // Form_Zitarice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 450);
            this.Controls.Add(this.dgvZitarice);
            this.Controls.Add(this.btnProdajZitaricu);
            this.Controls.Add(this.btnObrisiZitaricu);
            this.Controls.Add(this.btnIzmeniZitaricu);
            this.Controls.Add(this.btnDodajZitaricu);
            this.Name = "Form_Zitarice";
            this.Text = "Žitarice";
            this.Load += new System.EventHandler(this.Form_Zitarice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZitarice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZitarice;
        private System.Windows.Forms.Button btnProdajZitaricu;
        private System.Windows.Forms.Button btnObrisiZitaricu;
        private System.Windows.Forms.Button btnIzmeniZitaricu;
        private System.Windows.Forms.Button btnDodajZitaricu;
    }
}