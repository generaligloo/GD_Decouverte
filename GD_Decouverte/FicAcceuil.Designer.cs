namespace GD_Decouverte
{
    partial class EcranAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LTitre = new System.Windows.Forms.Label();
            this.BPermuter = new System.Windows.Forms.Button();
            this.BEntrée = new System.Windows.Forms.Button();
            this.Pimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pimage)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitre
            // 
            this.LTitre.AutoSize = true;
            this.LTitre.Font = new System.Drawing.Font("ObelixPro", 18F);
            this.LTitre.ForeColor = System.Drawing.Color.MediumBlue;
            this.LTitre.Location = new System.Drawing.Point(97, 9);
            this.LTitre.Name = "LTitre";
            this.LTitre.Size = new System.Drawing.Size(190, 30);
            this.LTitre.TabIndex = 0;
            this.LTitre.Text = "Attention ! ";
            // 
            // BPermuter
            // 
            this.BPermuter.Font = new System.Drawing.Font("ObelixPro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPermuter.ForeColor = System.Drawing.Color.DarkRed;
            this.BPermuter.Location = new System.Drawing.Point(4, 438);
            this.BPermuter.Name = "BPermuter";
            this.BPermuter.Size = new System.Drawing.Size(198, 34);
            this.BPermuter.TabIndex = 2;
            this.BPermuter.Text = "P A S  D E  P A P I E R";
            this.BPermuter.UseVisualStyleBackColor = true;
            this.BPermuter.Click += new System.EventHandler(this.BPermuter_Click);
            // 
            // BEntrée
            // 
            this.BEntrée.Font = new System.Drawing.Font("ObelixPro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEntrée.ForeColor = System.Drawing.Color.DarkRed;
            this.BEntrée.Location = new System.Drawing.Point(208, 438);
            this.BEntrée.Name = "BEntrée";
            this.BEntrée.Size = new System.Drawing.Size(164, 34);
            this.BEntrée.TabIndex = 3;
            this.BEntrée.Text = "P a s s e p o r t";
            this.BEntrée.UseVisualStyleBackColor = true;
            this.BEntrée.Click += new System.EventHandler(this.BEntrée_Click);
            // 
            // Pimage
            // 
            this.Pimage.Image = global::GD_Decouverte.Properties.Resources.Eq_9MX_XEAQDhii;
            this.Pimage.Location = new System.Drawing.Point(53, 63);
            this.Pimage.Name = "Pimage";
            this.Pimage.Size = new System.Drawing.Size(273, 308);
            this.Pimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pimage.TabIndex = 1;
            this.Pimage.TabStop = false;
            // 
            // EcranAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 484);
            this.Controls.Add(this.BEntrée);
            this.Controls.Add(this.BPermuter);
            this.Controls.Add(this.Pimage);
            this.Controls.Add(this.LTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAcceuil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Acceuil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranAcceuil_FormClosing);
            this.Load += new System.EventHandler(this.EcranAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitre;
        private System.Windows.Forms.PictureBox Pimage;
        private System.Windows.Forms.Button BPermuter;
        private System.Windows.Forms.Button BEntrée;
    }
}

