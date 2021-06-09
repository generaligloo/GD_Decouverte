
namespace GD_Decouverte
{
    partial class EcranBDD
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
            this.LBconsole = new System.Windows.Forms.ListBox();
            this.Bconsulter = new System.Windows.Forms.Button();
            this.Bdenombrer = new System.Windows.Forms.Button();
            this.Binsérer = new System.Windows.Forms.Button();
            this.TBnom = new System.Windows.Forms.TextBox();
            this.Lnom = new System.Windows.Forms.Label();
            this.Lpre = new System.Windows.Forms.Label();
            this.TBpre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBconsole
            // 
            this.LBconsole.FormattingEnabled = true;
            this.LBconsole.Location = new System.Drawing.Point(12, 12);
            this.LBconsole.Name = "LBconsole";
            this.LBconsole.Size = new System.Drawing.Size(296, 329);
            this.LBconsole.TabIndex = 0;
            // 
            // Bconsulter
            // 
            this.Bconsulter.Location = new System.Drawing.Point(314, 12);
            this.Bconsulter.Name = "Bconsulter";
            this.Bconsulter.Size = new System.Drawing.Size(126, 35);
            this.Bconsulter.TabIndex = 1;
            this.Bconsulter.Text = "Consulter";
            this.Bconsulter.UseVisualStyleBackColor = true;
            this.Bconsulter.Click += new System.EventHandler(this.Bconsulter_Click);
            // 
            // Bdenombrer
            // 
            this.Bdenombrer.Location = new System.Drawing.Point(314, 53);
            this.Bdenombrer.Name = "Bdenombrer";
            this.Bdenombrer.Size = new System.Drawing.Size(126, 35);
            this.Bdenombrer.TabIndex = 2;
            this.Bdenombrer.Text = "Dénombrer";
            this.Bdenombrer.UseVisualStyleBackColor = true;
            this.Bdenombrer.Click += new System.EventHandler(this.Bdenombrer_Click);
            // 
            // Binsérer
            // 
            this.Binsérer.Location = new System.Drawing.Point(314, 301);
            this.Binsérer.Name = "Binsérer";
            this.Binsérer.Size = new System.Drawing.Size(126, 35);
            this.Binsérer.TabIndex = 3;
            this.Binsérer.Text = "Insérer";
            this.Binsérer.UseVisualStyleBackColor = true;
            this.Binsérer.Click += new System.EventHandler(this.Binsérer_Click);
            // 
            // TBnom
            // 
            this.TBnom.Location = new System.Drawing.Point(314, 219);
            this.TBnom.Name = "TBnom";
            this.TBnom.Size = new System.Drawing.Size(123, 20);
            this.TBnom.TabIndex = 4;
            // 
            // Lnom
            // 
            this.Lnom.AutoSize = true;
            this.Lnom.Location = new System.Drawing.Point(314, 200);
            this.Lnom.Name = "Lnom";
            this.Lnom.Size = new System.Drawing.Size(35, 13);
            this.Lnom.TabIndex = 5;
            this.Lnom.Text = "Nom :";
            // 
            // Lpre
            // 
            this.Lpre.AutoSize = true;
            this.Lpre.Location = new System.Drawing.Point(314, 247);
            this.Lpre.Name = "Lpre";
            this.Lpre.Size = new System.Drawing.Size(49, 13);
            this.Lpre.TabIndex = 7;
            this.Lpre.Text = "Prénom :";
            // 
            // TBpre
            // 
            this.TBpre.Location = new System.Drawing.Point(314, 266);
            this.TBpre.Name = "TBpre";
            this.TBpre.Size = new System.Drawing.Size(123, 20);
            this.TBpre.TabIndex = 6;
            // 
            // EcranBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 348);
            this.Controls.Add(this.Lpre);
            this.Controls.Add(this.TBpre);
            this.Controls.Add(this.Lnom);
            this.Controls.Add(this.TBnom);
            this.Controls.Add(this.Binsérer);
            this.Controls.Add(this.Bdenombrer);
            this.Controls.Add(this.Bconsulter);
            this.Controls.Add(this.LBconsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBDD";
            this.Text = "Base de données direct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBconsole;
        private System.Windows.Forms.Button Bconsulter;
        private System.Windows.Forms.Button Bdenombrer;
        private System.Windows.Forms.Button Binsérer;
        private System.Windows.Forms.TextBox TBnom;
        private System.Windows.Forms.Label Lnom;
        private System.Windows.Forms.Label Lpre;
        private System.Windows.Forms.TextBox TBpre;
    }
}