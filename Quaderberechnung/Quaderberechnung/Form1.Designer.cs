namespace Quaderberechnung
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
            this.lbl_volumen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_oberfläche = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_raumdiagonale = new System.Windows.Forms.Label();
            this.txt_seite_a = new System.Windows.Forms.TextBox();
            this.txt_seite_c = new System.Windows.Forms.TextBox();
            this.txt_seite_b = new System.Windows.Forms.TextBox();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seitenlänge a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seitenlänge b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seitenlänge c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volumen:";
            // 
            // lbl_volumen
            // 
            this.lbl_volumen.AutoSize = true;
            this.lbl_volumen.Location = new System.Drawing.Point(162, 257);
            this.lbl_volumen.Name = "lbl_volumen";
            this.lbl_volumen.Size = new System.Drawing.Size(0, 16);
            this.lbl_volumen.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oberfläche:";
            // 
            // lbl_oberfläche
            // 
            this.lbl_oberfläche.AutoSize = true;
            this.lbl_oberfläche.Location = new System.Drawing.Point(162, 331);
            this.lbl_oberfläche.Name = "lbl_oberfläche";
            this.lbl_oberfläche.Size = new System.Drawing.Size(0, 16);
            this.lbl_oberfläche.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Raumdiagonale:";
            // 
            // lbl_raumdiagonale
            // 
            this.lbl_raumdiagonale.AutoSize = true;
            this.lbl_raumdiagonale.Location = new System.Drawing.Point(353, 257);
            this.lbl_raumdiagonale.Name = "lbl_raumdiagonale";
            this.lbl_raumdiagonale.Size = new System.Drawing.Size(0, 16);
            this.lbl_raumdiagonale.TabIndex = 8;
            // 
            // txt_seite_a
            // 
            this.txt_seite_a.Location = new System.Drawing.Point(165, 139);
            this.txt_seite_a.Multiline = true;
            this.txt_seite_a.Name = "txt_seite_a";
            this.txt_seite_a.Size = new System.Drawing.Size(105, 26);
            this.txt_seite_a.TabIndex = 9;
            // 
            // txt_seite_c
            // 
            this.txt_seite_c.Location = new System.Drawing.Point(548, 139);
            this.txt_seite_c.Multiline = true;
            this.txt_seite_c.Name = "txt_seite_c";
            this.txt_seite_c.Size = new System.Drawing.Size(105, 26);
            this.txt_seite_c.TabIndex = 10;
            // 
            // txt_seite_b
            // 
            this.txt_seite_b.Location = new System.Drawing.Point(356, 139);
            this.txt_seite_b.Multiline = true;
            this.txt_seite_b.Name = "txt_seite_b";
            this.txt_seite_b.Size = new System.Drawing.Size(105, 26);
            this.txt_seite_b.TabIndex = 11;
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_berechnen.Location = new System.Drawing.Point(548, 298);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(180, 49);
            this.btn_berechnen.TabIndex = 12;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(549, 355);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(116, 56);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.txt_seite_b);
            this.Controls.Add(this.txt_seite_c);
            this.Controls.Add(this.txt_seite_a);
            this.Controls.Add(this.lbl_raumdiagonale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_oberfläche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_volumen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quaderberechnung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_volumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_oberfläche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_raumdiagonale;
        private System.Windows.Forms.TextBox txt_seite_a;
        private System.Windows.Forms.TextBox txt_seite_c;
        private System.Windows.Forms.TextBox txt_seite_b;
        private System.Windows.Forms.Button btn_berechnen;
        private System.Windows.Forms.Button btn_clear;
    }
}

