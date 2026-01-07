namespace Benzingebrauchsrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gefahren = new System.Windows.Forms.TextBox();
            this.txt_verbraucht = new System.Windows.Forms.TextBox();
            this.txt_pro_100_km = new System.Windows.Forms.TextBox();
            this.txt_miles_per_gallon = new System.Windows.Forms.TextBox();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gefahrene Kilometer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verbrauch in Litern";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verbrauch pro 100 km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miles per gallon";
            // 
            // txt_gefahren
            // 
            this.txt_gefahren.Location = new System.Drawing.Point(403, 68);
            this.txt_gefahren.Multiline = true;
            this.txt_gefahren.Name = "txt_gefahren";
            this.txt_gefahren.Size = new System.Drawing.Size(118, 30);
            this.txt_gefahren.TabIndex = 4;
            // 
            // txt_verbraucht
            // 
            this.txt_verbraucht.Location = new System.Drawing.Point(403, 127);
            this.txt_verbraucht.Multiline = true;
            this.txt_verbraucht.Name = "txt_verbraucht";
            this.txt_verbraucht.Size = new System.Drawing.Size(118, 30);
            this.txt_verbraucht.TabIndex = 5;
            // 
            // txt_pro_100_km
            // 
            this.txt_pro_100_km.Location = new System.Drawing.Point(403, 233);
            this.txt_pro_100_km.Multiline = true;
            this.txt_pro_100_km.Name = "txt_pro_100_km";
            this.txt_pro_100_km.Size = new System.Drawing.Size(118, 30);
            this.txt_pro_100_km.TabIndex = 6;
            // 
            // txt_miles_per_gallon
            // 
            this.txt_miles_per_gallon.Location = new System.Drawing.Point(403, 290);
            this.txt_miles_per_gallon.Multiline = true;
            this.txt_miles_per_gallon.Name = "txt_miles_per_gallon";
            this.txt_miles_per_gallon.Size = new System.Drawing.Size(118, 30);
            this.txt_miles_per_gallon.TabIndex = 7;
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_berechnen.Location = new System.Drawing.Point(113, 175);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(408, 38);
            this.btn_berechnen.TabIndex = 8;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.txt_miles_per_gallon);
            this.Controls.Add(this.txt_pro_100_km);
            this.Controls.Add(this.txt_verbraucht);
            this.Controls.Add(this.txt_gefahren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Benzinverbrauchsrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gefahren;
        private System.Windows.Forms.TextBox txt_verbraucht;
        private System.Windows.Forms.TextBox txt_pro_100_km;
        private System.Windows.Forms.TextBox txt_miles_per_gallon;
        private System.Windows.Forms.Button btn_berechnen;
    }
}

