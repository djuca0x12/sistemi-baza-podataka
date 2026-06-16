namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Zivotinje
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
            this.btnDodajZivotinju = new System.Windows.Forms.Button();
            this.btnIzmeniZivotinju = new System.Windows.Forms.Button();
            this.btnObrisiZivotinju = new System.Windows.Forms.Button();
            this.btnProdajZivotinju = new System.Windows.Forms.Button();
            this.dgvZivotinje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZivotinju
            // 
            this.btnDodajZivotinju.Location = new System.Drawing.Point(1457, 68);
            this.btnDodajZivotinju.Name = "btnDodajZivotinju";
            this.btnDodajZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnDodajZivotinju.TabIndex = 1;
            this.btnDodajZivotinju.Text = "Dodaj životinju";
            this.btnDodajZivotinju.UseVisualStyleBackColor = true;
            this.btnDodajZivotinju.Click += new System.EventHandler(this.btnDodajZivotinju_Click);
            // 
            // btnIzmeniZivotinju
            // 
            this.btnIzmeniZivotinju.Location = new System.Drawing.Point(1457, 157);
            this.btnIzmeniZivotinju.Name = "btnIzmeniZivotinju";
            this.btnIzmeniZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnIzmeniZivotinju.TabIndex = 2;
            this.btnIzmeniZivotinju.Text = "Izmeni životinju";
            this.btnIzmeniZivotinju.UseVisualStyleBackColor = true;
            this.btnIzmeniZivotinju.Click += new System.EventHandler(this.btnIzmeniZivotinju_Click);
            // 
            // btnObrisiZivotinju
            // 
            this.btnObrisiZivotinju.Location = new System.Drawing.Point(1457, 246);
            this.btnObrisiZivotinju.Name = "btnObrisiZivotinju";
            this.btnObrisiZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnObrisiZivotinju.TabIndex = 3;
            this.btnObrisiZivotinju.Text = "Obriši životinju";
            this.btnObrisiZivotinju.UseVisualStyleBackColor = true;
            this.btnObrisiZivotinju.Click += new System.EventHandler(this.btnObrisiZivotinju_Click);
            // 
            // btnProdajZivotinju
            // 
            this.btnProdajZivotinju.Location = new System.Drawing.Point(1457, 335);
            this.btnProdajZivotinju.Name = "btnProdajZivotinju";
            this.btnProdajZivotinju.Size = new System.Drawing.Size(154, 41);
            this.btnProdajZivotinju.TabIndex = 4;
            this.btnProdajZivotinju.Text = "Prodaj životinju";
            this.btnProdajZivotinju.UseVisualStyleBackColor = true;
            this.btnProdajZivotinju.Click += new System.EventHandler(this.btnProdajZivotinju_Click);
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(57, 68);
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.ReadOnly = true;
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.RowTemplate.Height = 24;
            this.dgvZivotinje.Size = new System.Drawing.Size(1342, 308);
            this.dgvZivotinje.TabIndex = 5;
            // 
            // Form_Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 449);
            this.Controls.Add(this.dgvZivotinje);
            this.Controls.Add(this.btnProdajZivotinju);
            this.Controls.Add(this.btnObrisiZivotinju);
            this.Controls.Add(this.btnIzmeniZivotinju);
            this.Controls.Add(this.btnDodajZivotinju);
            this.Name = "Form_Zivotinje";
            this.Text = "Sve životinje";
            this.Load += new System.EventHandler(this.Form_Zivotinje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZivotinju;
        private System.Windows.Forms.Button btnIzmeniZivotinju;
        private System.Windows.Forms.Button btnObrisiZivotinju;
        private System.Windows.Forms.Button btnProdajZivotinju;
        private System.Windows.Forms.DataGridView dgvZivotinje;
    }
}