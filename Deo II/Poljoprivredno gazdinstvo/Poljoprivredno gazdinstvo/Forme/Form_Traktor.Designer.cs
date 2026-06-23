namespace Poljoprivredno_gazdinstvo.Forme
{
    partial class Form_Traktor
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTraktori = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraktori)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1312, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Promeni podatke o traktoru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTraktori
            // 
            this.dataGridViewTraktori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraktori.Location = new System.Drawing.Point(22, 32);
            this.dataGridViewTraktori.Name = "dataGridViewTraktori";
            this.dataGridViewTraktori.RowHeadersWidth = 51;
            this.dataGridViewTraktori.RowTemplate.Height = 24;
            this.dataGridViewTraktori.Size = new System.Drawing.Size(1267, 538);
            this.dataGridViewTraktori.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1312, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dodaj novi traktor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1359, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obrisi traktor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1359, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "Zatvori";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Traktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 639);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridViewTraktori);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Traktor";
            this.Text = "Traktori na poljoprivrednom gazdinstvu";
            this.Load += new System.EventHandler(this.Form_Traktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraktori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewTraktori;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}