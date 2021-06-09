namespace GD_Decouverte
{
    partial class EcranProgression
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
            this.LPrimaire = new System.Windows.Forms.Label();
            this.PBPrimaire = new System.Windows.Forms.ProgressBar();
            this.PBSecondaire = new System.Windows.Forms.ProgressBar();
            this.LSecondaire = new System.Windows.Forms.Label();
            this.Bcopie = new System.Windows.Forms.Button();
            this.BQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LPrimaire
            // 
            this.LPrimaire.AutoSize = true;
            this.LPrimaire.Font = new System.Drawing.Font("Calibri", 13F);
            this.LPrimaire.ForeColor = System.Drawing.Color.DarkBlue;
            this.LPrimaire.Location = new System.Drawing.Point(13, 13);
            this.LPrimaire.Name = "LPrimaire";
            this.LPrimaire.Size = new System.Drawing.Size(115, 22);
            this.LPrimaire.TabIndex = 0;
            this.LPrimaire.Text = "Index primaire";
            // 
            // PBPrimaire
            // 
            this.PBPrimaire.Location = new System.Drawing.Point(17, 38);
            this.PBPrimaire.Name = "PBPrimaire";
            this.PBPrimaire.Size = new System.Drawing.Size(355, 41);
            this.PBPrimaire.Step = 1;
            this.PBPrimaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBPrimaire.TabIndex = 1;
            // 
            // PBSecondaire
            // 
            this.PBSecondaire.Location = new System.Drawing.Point(17, 117);
            this.PBSecondaire.Name = "PBSecondaire";
            this.PBSecondaire.Size = new System.Drawing.Size(355, 41);
            this.PBSecondaire.Step = 1;
            this.PBSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBSecondaire.TabIndex = 3;
            // 
            // LSecondaire
            // 
            this.LSecondaire.AutoSize = true;
            this.LSecondaire.Font = new System.Drawing.Font("Calibri", 10F);
            this.LSecondaire.ForeColor = System.Drawing.Color.DarkBlue;
            this.LSecondaire.Location = new System.Drawing.Point(13, 92);
            this.LSecondaire.Name = "LSecondaire";
            this.LSecondaire.Size = new System.Drawing.Size(103, 17);
            this.LSecondaire.TabIndex = 2;
            this.LSecondaire.Text = "Index secondaire";
            // 
            // Bcopie
            // 
            this.Bcopie.Font = new System.Drawing.Font("ObelixPro", 20F, System.Drawing.FontStyle.Bold);
            this.Bcopie.Location = new System.Drawing.Point(17, 241);
            this.Bcopie.Name = "Bcopie";
            this.Bcopie.Size = new System.Drawing.Size(152, 65);
            this.Bcopie.TabIndex = 4;
            this.Bcopie.Text = "Copie";
            this.Bcopie.UseVisualStyleBackColor = true;
            this.Bcopie.Click += new System.EventHandler(this.Bcopie_Click);
            // 
            // BQuitter
            // 
            this.BQuitter.Font = new System.Drawing.Font("ObelixPro", 20F, System.Drawing.FontStyle.Bold);
            this.BQuitter.Location = new System.Drawing.Point(197, 241);
            this.BQuitter.Name = "BQuitter";
            this.BQuitter.Size = new System.Drawing.Size(175, 65);
            this.BQuitter.TabIndex = 5;
            this.BQuitter.Text = "Quitter";
            this.BQuitter.UseVisualStyleBackColor = true;
            this.BQuitter.Click += new System.EventHandler(this.BQuitter_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.BQuitter);
            this.Controls.Add(this.Bcopie);
            this.Controls.Add(this.PBSecondaire);
            this.Controls.Add(this.LSecondaire);
            this.Controls.Add(this.PBPrimaire);
            this.Controls.Add(this.LPrimaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranProgression";
            this.Text = "Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranProgression_FormClosing);
            this.Load += new System.EventHandler(this.EcranProgression_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPrimaire;
        private System.Windows.Forms.ProgressBar PBPrimaire;
        private System.Windows.Forms.ProgressBar PBSecondaire;
        private System.Windows.Forms.Label LSecondaire;
        private System.Windows.Forms.Button Bcopie;
        private System.Windows.Forms.Button BQuitter;
    }
}