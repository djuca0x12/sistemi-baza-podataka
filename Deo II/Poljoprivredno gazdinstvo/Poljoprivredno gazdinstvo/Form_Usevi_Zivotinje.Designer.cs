namespace Poljoprivredno_gazdinstvo
{
    partial class Form_Usevi_Zivotinje
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
            this.Dodaj_Životinju = new System.Windows.Forms.Button();
            this.Dodaj_Vocnjak = new System.Windows.Forms.Button();
            this.Dodaj_Povrce = new System.Windows.Forms.Button();
            this.Dodaj_zitarice = new System.Windows.Forms.Button();
            this.Dodaj_Krmno_Bilje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj_Životinju
            // 
            this.Dodaj_Životinju.Location = new System.Drawing.Point(89, 84);
            this.Dodaj_Životinju.Name = "Dodaj_Životinju";
            this.Dodaj_Životinju.Size = new System.Drawing.Size(154, 41);
            this.Dodaj_Životinju.TabIndex = 0;
            this.Dodaj_Životinju.Text = "Dodaj životinju";
            this.Dodaj_Životinju.UseVisualStyleBackColor = true;
            this.Dodaj_Životinju.Click += new System.EventHandler(this.Dodaj_Životinju_Click);
            // 
            // Dodaj_Vocnjak
            // 
            this.Dodaj_Vocnjak.Location = new System.Drawing.Point(89, 167);
            this.Dodaj_Vocnjak.Name = "Dodaj_Vocnjak";
            this.Dodaj_Vocnjak.Size = new System.Drawing.Size(154, 41);
            this.Dodaj_Vocnjak.TabIndex = 1;
            this.Dodaj_Vocnjak.Text = "Dodaj voćnjak";
            this.Dodaj_Vocnjak.UseVisualStyleBackColor = true;
            this.Dodaj_Vocnjak.Click += new System.EventHandler(this.Dodaj_Vocnjak_Click);
            // 
            // Dodaj_Povrce
            // 
            this.Dodaj_Povrce.Location = new System.Drawing.Point(89, 245);
            this.Dodaj_Povrce.Name = "Dodaj_Povrce";
            this.Dodaj_Povrce.Size = new System.Drawing.Size(154, 41);
            this.Dodaj_Povrce.TabIndex = 2;
            this.Dodaj_Povrce.Text = "Dodaj povrće";
            this.Dodaj_Povrce.UseVisualStyleBackColor = true;
            this.Dodaj_Povrce.Click += new System.EventHandler(this.Dodaj_Povrce_Click);
            // 
            // Dodaj_zitarice
            // 
            this.Dodaj_zitarice.Location = new System.Drawing.Point(334, 84);
            this.Dodaj_zitarice.Name = "Dodaj_zitarice";
            this.Dodaj_zitarice.Size = new System.Drawing.Size(154, 41);
            this.Dodaj_zitarice.TabIndex = 3;
            this.Dodaj_zitarice.Text = "Dodaj žitarice";
            this.Dodaj_zitarice.UseVisualStyleBackColor = true;
            this.Dodaj_zitarice.Click += new System.EventHandler(this.Dodaj_zitarice_Click);
            // 
            // Dodaj_Krmno_Bilje
            // 
            this.Dodaj_Krmno_Bilje.Location = new System.Drawing.Point(334, 167);
            this.Dodaj_Krmno_Bilje.Name = "Dodaj_Krmno_Bilje";
            this.Dodaj_Krmno_Bilje.Size = new System.Drawing.Size(154, 41);
            this.Dodaj_Krmno_Bilje.TabIndex = 4;
            this.Dodaj_Krmno_Bilje.Text = "Dodaj krmno bilje";
            this.Dodaj_Krmno_Bilje.UseVisualStyleBackColor = true;
            this.Dodaj_Krmno_Bilje.Click += new System.EventHandler(this.Dodaj_Krmno_Bilje_Click);
            // 
            // Form_Usevi_Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dodaj_Krmno_Bilje);
            this.Controls.Add(this.Dodaj_zitarice);
            this.Controls.Add(this.Dodaj_Povrce);
            this.Controls.Add(this.Dodaj_Vocnjak);
            this.Controls.Add(this.Dodaj_Životinju);
            this.Name = "Form_Usevi_Zivotinje";
            this.Text = "Form_Usevi_Zivotinje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dodaj_Životinju;
        private System.Windows.Forms.Button Dodaj_Vocnjak;
        private System.Windows.Forms.Button Dodaj_Povrce;
        private System.Windows.Forms.Button Dodaj_zitarice;
        private System.Windows.Forms.Button Dodaj_Krmno_Bilje;
    }
}