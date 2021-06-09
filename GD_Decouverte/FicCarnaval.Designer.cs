
namespace GD_Decouverte
{
    partial class EcranCarnaval
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
            this.bGeometrique = new System.Windows.Forms.Button();
            this.bTexte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGeometrique
            // 
            this.bGeometrique.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGeometrique.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bGeometrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGeometrique.Location = new System.Drawing.Point(12, 99);
            this.bGeometrique.Name = "bGeometrique";
            this.bGeometrique.Size = new System.Drawing.Size(309, 58);
            this.bGeometrique.TabIndex = 0;
            this.bGeometrique.UseVisualStyleBackColor = false;
            this.bGeometrique.Click += new System.EventHandler(this.bGeometrique_Click);
            // 
            // bTexte
            // 
            this.bTexte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bTexte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bTexte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTexte.Location = new System.Drawing.Point(12, 12);
            this.bTexte.Name = "bTexte";
            this.bTexte.Size = new System.Drawing.Size(309, 58);
            this.bTexte.TabIndex = 1;
            this.bTexte.UseVisualStyleBackColor = false;
            this.bTexte.Click += new System.EventHandler(this.bTexte_Click);
            // 
            // EcranCarnaval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.bTexte);
            this.Controls.Add(this.bGeometrique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranCarnaval";
            this.Text = "FicCarnaval";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranCarnaval_Paint);
            this.Resize += new System.EventHandler(this.EcranCarnaval_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGeometrique;
        private System.Windows.Forms.Button bTexte;
    }
}