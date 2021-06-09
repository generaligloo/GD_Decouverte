
namespace GD_Decouverte
{
    partial class EcranIntegration
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
            this.LB_gauche = new System.Windows.Forms.Label();
            this.TB_gauche = new System.Windows.Forms.TextBox();
            this.TB_droite = new System.Windows.Forms.TextBox();
            this.LB_droite = new System.Windows.Forms.Label();
            this.TB_int = new System.Windows.Forms.TextBox();
            this.LB_int = new System.Windows.Forms.Label();
            this.LBO_resultat = new System.Windows.Forms.ListBox();
            this.B_poly = new System.Windows.Forms.Button();
            this.B_trigono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_gauche
            // 
            this.LB_gauche.AutoSize = true;
            this.LB_gauche.Location = new System.Drawing.Point(13, 13);
            this.LB_gauche.Name = "LB_gauche";
            this.LB_gauche.Size = new System.Drawing.Size(45, 13);
            this.LB_gauche.TabIndex = 0;
            this.LB_gauche.Text = "Gauche";
            // 
            // TB_gauche
            // 
            this.TB_gauche.Location = new System.Drawing.Point(16, 30);
            this.TB_gauche.Name = "TB_gauche";
            this.TB_gauche.Size = new System.Drawing.Size(100, 20);
            this.TB_gauche.TabIndex = 1;
            this.TB_gauche.Text = "0";
            this.TB_gauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_droite
            // 
            this.TB_droite.Location = new System.Drawing.Point(126, 30);
            this.TB_droite.Name = "TB_droite";
            this.TB_droite.Size = new System.Drawing.Size(100, 20);
            this.TB_droite.TabIndex = 3;
            this.TB_droite.Text = "4";
            this.TB_droite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LB_droite
            // 
            this.LB_droite.AutoSize = true;
            this.LB_droite.Location = new System.Drawing.Point(123, 13);
            this.LB_droite.Name = "LB_droite";
            this.LB_droite.Size = new System.Drawing.Size(35, 13);
            this.LB_droite.TabIndex = 2;
            this.LB_droite.Text = "Droite";
            // 
            // TB_int
            // 
            this.TB_int.Location = new System.Drawing.Point(238, 30);
            this.TB_int.Name = "TB_int";
            this.TB_int.Size = new System.Drawing.Size(100, 20);
            this.TB_int.TabIndex = 5;
            this.TB_int.Text = "2";
            this.TB_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LB_int
            // 
            this.LB_int.AutoSize = true;
            this.LB_int.Location = new System.Drawing.Point(225, 13);
            this.LB_int.Name = "LB_int";
            this.LB_int.Size = new System.Drawing.Size(79, 13);
            this.LB_int.TabIndex = 4;
            this.LB_int.Text = "Nb d\'intervalles";
            // 
            // LBO_resultat
            // 
            this.LBO_resultat.FormattingEnabled = true;
            this.LBO_resultat.Location = new System.Drawing.Point(16, 56);
            this.LBO_resultat.Name = "LBO_resultat";
            this.LBO_resultat.Size = new System.Drawing.Size(322, 134);
            this.LBO_resultat.TabIndex = 6;
            // 
            // B_poly
            // 
            this.B_poly.Location = new System.Drawing.Point(16, 196);
            this.B_poly.Name = "B_poly";
            this.B_poly.Size = new System.Drawing.Size(322, 38);
            this.B_poly.TabIndex = 7;
            this.B_poly.Text = "Polynôme : X² +1";
            this.B_poly.UseVisualStyleBackColor = true;
            this.B_poly.Click += new System.EventHandler(this.B_poly_Click);
            // 
            // B_trigono
            // 
            this.B_trigono.Location = new System.Drawing.Point(16, 240);
            this.B_trigono.Name = "B_trigono";
            this.B_trigono.Size = new System.Drawing.Size(322, 38);
            this.B_trigono.TabIndex = 8;
            this.B_trigono.Text = "Trigonométrique : cos(x)";
            this.B_trigono.UseVisualStyleBackColor = true;
            this.B_trigono.Click += new System.EventHandler(this.B_trigono_Click);
            // 
            // EcranIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 295);
            this.Controls.Add(this.B_trigono);
            this.Controls.Add(this.B_poly);
            this.Controls.Add(this.LBO_resultat);
            this.Controls.Add(this.TB_int);
            this.Controls.Add(this.LB_int);
            this.Controls.Add(this.TB_droite);
            this.Controls.Add(this.LB_droite);
            this.Controls.Add(this.TB_gauche);
            this.Controls.Add(this.LB_gauche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranIntegration";
            this.Text = "FicIntegration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_gauche;
        private System.Windows.Forms.TextBox TB_gauche;
        private System.Windows.Forms.TextBox TB_droite;
        private System.Windows.Forms.Label LB_droite;
        private System.Windows.Forms.TextBox TB_int;
        private System.Windows.Forms.Label LB_int;
        private System.Windows.Forms.ListBox LBO_resultat;
        private System.Windows.Forms.Button B_poly;
        private System.Windows.Forms.Button B_trigono;
    }
}