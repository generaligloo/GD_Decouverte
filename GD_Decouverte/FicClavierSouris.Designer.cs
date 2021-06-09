
namespace GD_Decouverte
{
    partial class EcranClavierSouris
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
            this.lbClavier = new System.Windows.Forms.Label();
            this.LB_listeclavier = new System.Windows.Forms.ListBox();
            this.bRAZ = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.lbClicGauche = new System.Windows.Forms.Label();
            this.TBClicGauche = new System.Windows.Forms.TextBox();
            this.PaZoneSouris = new System.Windows.Forms.Panel();
            this.TBClicDroit = new System.Windows.Forms.TextBox();
            this.lbClicDroit = new System.Windows.Forms.Label();
            this.TBOrdonné = new System.Windows.Forms.TextBox();
            this.lbordonné = new System.Windows.Forms.Label();
            this.TBAbscisse = new System.Windows.Forms.TextBox();
            this.lbAbscisse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClavier
            // 
            this.lbClavier.AutoSize = true;
            this.lbClavier.Location = new System.Drawing.Point(13, 13);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(39, 13);
            this.lbClavier.TabIndex = 0;
            this.lbClavier.Text = "Clavier";
            // 
            // LB_listeclavier
            // 
            this.LB_listeclavier.FormattingEnabled = true;
            this.LB_listeclavier.Location = new System.Drawing.Point(16, 29);
            this.LB_listeclavier.Name = "LB_listeclavier";
            this.LB_listeclavier.Size = new System.Drawing.Size(179, 290);
            this.LB_listeclavier.TabIndex = 1;
            // 
            // bRAZ
            // 
            this.bRAZ.Location = new System.Drawing.Point(16, 326);
            this.bRAZ.Name = "bRAZ";
            this.bRAZ.Size = new System.Drawing.Size(75, 23);
            this.bRAZ.TabIndex = 2;
            this.bRAZ.Text = "RAZ";
            this.bRAZ.UseVisualStyleBackColor = true;
            this.bRAZ.Click += new System.EventHandler(this.bRAZ_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(120, 326);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 23);
            this.bQuitter.TabIndex = 3;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // lbClicGauche
            // 
            this.lbClicGauche.AutoSize = true;
            this.lbClicGauche.Location = new System.Drawing.Point(218, 13);
            this.lbClicGauche.Name = "lbClicGauche";
            this.lbClicGauche.Size = new System.Drawing.Size(65, 13);
            this.lbClicGauche.TabIndex = 4;
            this.lbClicGauche.Text = "Clic Gauche";
            // 
            // TBClicGauche
            // 
            this.TBClicGauche.Location = new System.Drawing.Point(221, 29);
            this.TBClicGauche.Name = "TBClicGauche";
            this.TBClicGauche.ReadOnly = true;
            this.TBClicGauche.Size = new System.Drawing.Size(76, 20);
            this.TBClicGauche.TabIndex = 5;
            this.TBClicGauche.Text = "0";
            this.TBClicGauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaZoneSouris
            // 
            this.PaZoneSouris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaZoneSouris.Location = new System.Drawing.Point(221, 52);
            this.PaZoneSouris.Name = "PaZoneSouris";
            this.PaZoneSouris.Size = new System.Drawing.Size(400, 300);
            this.PaZoneSouris.TabIndex = 6;
            this.PaZoneSouris.Paint += new System.Windows.Forms.PaintEventHandler(this.PaZoneSouris_Paint);
            this.PaZoneSouris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaZoneSouris_MouseDown);
            this.PaZoneSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaZoneSouris_MouseMove);
            // 
            // TBClicDroit
            // 
            this.TBClicDroit.Location = new System.Drawing.Point(303, 29);
            this.TBClicDroit.Name = "TBClicDroit";
            this.TBClicDroit.ReadOnly = true;
            this.TBClicDroit.Size = new System.Drawing.Size(76, 20);
            this.TBClicDroit.TabIndex = 8;
            this.TBClicDroit.Text = "0";
            this.TBClicDroit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbClicDroit
            // 
            this.lbClicDroit.AutoSize = true;
            this.lbClicDroit.Location = new System.Drawing.Point(300, 12);
            this.lbClicDroit.Name = "lbClicDroit";
            this.lbClicDroit.Size = new System.Drawing.Size(49, 13);
            this.lbClicDroit.TabIndex = 7;
            this.lbClicDroit.Text = "Clic Droit";
            // 
            // TBOrdonné
            // 
            this.TBOrdonné.Location = new System.Drawing.Point(545, 29);
            this.TBOrdonné.Name = "TBOrdonné";
            this.TBOrdonné.ReadOnly = true;
            this.TBOrdonné.Size = new System.Drawing.Size(76, 20);
            this.TBOrdonné.TabIndex = 12;
            this.TBOrdonné.Text = "0";
            this.TBOrdonné.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbordonné
            // 
            this.lbordonné.AutoSize = true;
            this.lbordonné.Location = new System.Drawing.Point(542, 12);
            this.lbordonné.Name = "lbordonné";
            this.lbordonné.Size = new System.Drawing.Size(57, 13);
            this.lbordonné.TabIndex = 11;
            this.lbordonné.Text = "Position: Y";
            // 
            // TBAbscisse
            // 
            this.TBAbscisse.Location = new System.Drawing.Point(463, 29);
            this.TBAbscisse.Name = "TBAbscisse";
            this.TBAbscisse.ReadOnly = true;
            this.TBAbscisse.Size = new System.Drawing.Size(76, 20);
            this.TBAbscisse.TabIndex = 10;
            this.TBAbscisse.Text = "0";
            this.TBAbscisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbAbscisse
            // 
            this.lbAbscisse.AutoSize = true;
            this.lbAbscisse.Location = new System.Drawing.Point(460, 13);
            this.lbAbscisse.Name = "lbAbscisse";
            this.lbAbscisse.Size = new System.Drawing.Size(60, 13);
            this.lbAbscisse.TabIndex = 9;
            this.lbAbscisse.Text = "Position : X";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.TBOrdonné);
            this.Controls.Add(this.lbordonné);
            this.Controls.Add(this.TBAbscisse);
            this.Controls.Add(this.lbAbscisse);
            this.Controls.Add(this.TBClicDroit);
            this.Controls.Add(this.lbClicDroit);
            this.Controls.Add(this.PaZoneSouris);
            this.Controls.Add(this.TBClicGauche);
            this.Controls.Add(this.lbClicGauche);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bRAZ);
            this.Controls.Add(this.LB_listeclavier);
            this.Controls.Add(this.lbClavier);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClavierSouris";
            this.Text = "FicClavierSouris";
            this.Load += new System.EventHandler(this.EcranClavierSouris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClavier;
        private System.Windows.Forms.ListBox LB_listeclavier;
        private System.Windows.Forms.Button bRAZ;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Label lbClicGauche;
        private System.Windows.Forms.TextBox TBClicGauche;
        private System.Windows.Forms.Panel PaZoneSouris;
        private System.Windows.Forms.TextBox TBClicDroit;
        private System.Windows.Forms.Label lbClicDroit;
        private System.Windows.Forms.TextBox TBOrdonné;
        private System.Windows.Forms.Label lbordonné;
        private System.Windows.Forms.TextBox TBAbscisse;
        private System.Windows.Forms.Label lbAbscisse;
    }
}