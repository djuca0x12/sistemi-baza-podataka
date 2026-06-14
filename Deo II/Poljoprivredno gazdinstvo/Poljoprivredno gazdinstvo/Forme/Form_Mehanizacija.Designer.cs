namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Mehanizacija
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
            this.btnTraktori = new System.Windows.Forms.Button();
            this.btnMasine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageTraktor = new System.Windows.Forms.Button();
            this.imageMasina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTraktori
            // 
            this.btnTraktori.Location = new System.Drawing.Point(155, 154);
            this.btnTraktori.Name = "btnTraktori";
            this.btnTraktori.Size = new System.Drawing.Size(113, 45);
            this.btnTraktori.TabIndex = 0;
            this.btnTraktori.Text = "Traktori";
            this.btnTraktori.UseVisualStyleBackColor = true;
            this.btnTraktori.Click += new System.EventHandler(this.btnTraktori_Click);
            // 
            // btnMasine
            // 
            this.btnMasine.Location = new System.Drawing.Point(151, 335);
            this.btnMasine.Name = "btnMasine";
            this.btnMasine.Size = new System.Drawing.Size(117, 39);
            this.btnMasine.TabIndex = 1;
            this.btnMasine.Text = "Masine";
            this.btnMasine.UseVisualStyleBackColor = true;
            this.btnMasine.Click += new System.EventHandler(this.btnMasine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pogledajte i upravljajte svim traktorima na gazdinstvu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pogledajte i upravljajte svim masinama na gazdinstvu";
            // 
            // imageTraktor
            // 
            this.imageTraktor.Location = new System.Drawing.Point(513, 76);
            this.imageTraktor.Name = "imageTraktor";
            this.imageTraktor.Size = new System.Drawing.Size(202, 142);
            this.imageTraktor.TabIndex = 6;
            this.imageTraktor.UseVisualStyleBackColor = true;
            // 
            // imageMasina
            // 
            this.imageMasina.Location = new System.Drawing.Point(449, 262);
            this.imageMasina.Name = "imageMasina";
            this.imageMasina.Size = new System.Drawing.Size(319, 134);
            this.imageMasina.TabIndex = 5;
            this.imageMasina.UseVisualStyleBackColor = true;
            // 
            // Form_Mehanizacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageTraktor);
            this.Controls.Add(this.imageMasina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMasine);
            this.Controls.Add(this.btnTraktori);
            this.Name = "Form_Mehanizacija";
            this.Text = "Form_Mehanizacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraktori;
        private System.Windows.Forms.Button btnMasine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button imageMasina;
        private System.Windows.Forms.Button imageTraktor;
    }
}