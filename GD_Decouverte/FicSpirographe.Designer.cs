
namespace GD_Decouverte
{
    partial class EcranSpirographe
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
            this.gbParametres = new System.Windows.Forms.GroupBox();
            this.lSommet = new System.Windows.Forms.Label();
            this.tbSommet = new System.Windows.Forms.TrackBar();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lDensite = new System.Windows.Forms.Label();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.lProfondeur = new System.Windows.Forms.Label();
            this.bExecuter = new System.Windows.Forms.Button();
            this.bFond = new System.Windows.Forms.Button();
            this.bTrait = new System.Windows.Forms.Button();
            this.dCouleur = new System.Windows.Forms.ColorDialog();
            this.gbParametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametres
            // 
            this.gbParametres.Controls.Add(this.bFond);
            this.gbParametres.Controls.Add(this.bTrait);
            this.gbParametres.Controls.Add(this.bExecuter);
            this.gbParametres.Controls.Add(this.tbProfondeur);
            this.gbParametres.Controls.Add(this.lProfondeur);
            this.gbParametres.Controls.Add(this.tbDensite);
            this.gbParametres.Controls.Add(this.lDensite);
            this.gbParametres.Controls.Add(this.tbSommet);
            this.gbParametres.Controls.Add(this.lSommet);
            this.gbParametres.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbParametres.Location = new System.Drawing.Point(0, 0);
            this.gbParametres.Name = "gbParametres";
            this.gbParametres.Size = new System.Drawing.Size(225, 332);
            this.gbParametres.TabIndex = 0;
            this.gbParametres.TabStop = false;
            this.gbParametres.Text = "Paramètres";
            // 
            // lSommet
            // 
            this.lSommet.AutoSize = true;
            this.lSommet.Location = new System.Drawing.Point(7, 20);
            this.lSommet.Name = "lSommet";
            this.lSommet.Size = new System.Drawing.Size(133, 13);
            this.lSommet.TabIndex = 0;
            this.lSommet.Text = "Nombre de sommets (3 - 8)";
            // 
            // tbSommet
            // 
            this.tbSommet.Location = new System.Drawing.Point(1, 36);
            this.tbSommet.Maximum = 8;
            this.tbSommet.Minimum = 3;
            this.tbSommet.Name = "tbSommet";
            this.tbSommet.Size = new System.Drawing.Size(225, 45);
            this.tbSommet.TabIndex = 1;
            this.tbSommet.Value = 5;
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(1, 98);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(225, 45);
            this.tbDensite.TabIndex = 3;
            this.tbDensite.Value = 10;
            // 
            // lDensite
            // 
            this.lDensite.AutoSize = true;
            this.lDensite.Location = new System.Drawing.Point(6, 84);
            this.lDensite.Name = "lDensite";
            this.lDensite.Size = new System.Drawing.Size(130, 13);
            this.lDensite.TabIndex = 2;
            this.lDensite.Text = "Densité de dessin (5 à 20)";
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(1, 162);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(225, 45);
            this.tbProfondeur.TabIndex = 5;
            this.tbProfondeur.TickFrequency = 5;
            this.tbProfondeur.Value = 40;
            // 
            // lProfondeur
            // 
            this.lProfondeur.AutoSize = true;
            this.lProfondeur.Location = new System.Drawing.Point(7, 146);
            this.lProfondeur.Name = "lProfondeur";
            this.lProfondeur.Size = new System.Drawing.Size(155, 13);
            this.lProfondeur.TabIndex = 4;
            this.lProfondeur.Text = "Profondeur de dessin ( 20 à 80)";
            // 
            // bExecuter
            // 
            this.bExecuter.Font = new System.Drawing.Font("ObelixPro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExecuter.Location = new System.Drawing.Point(7, 213);
            this.bExecuter.Name = "bExecuter";
            this.bExecuter.Size = new System.Drawing.Size(213, 46);
            this.bExecuter.TabIndex = 6;
            this.bExecuter.Text = "Executer";
            this.bExecuter.UseVisualStyleBackColor = true;
            this.bExecuter.Click += new System.EventHandler(this.bExecuter_Click);
            // 
            // bFond
            // 
            this.bFond.Font = new System.Drawing.Font("ObelixPro", 12F);
            this.bFond.Image = global::GD_Decouverte.Properties.Resources.Wwalczyszyn_Iwindows_Paint;
            this.bFond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bFond.Location = new System.Drawing.Point(119, 265);
            this.bFond.Name = "bFond";
            this.bFond.Size = new System.Drawing.Size(101, 46);
            this.bFond.TabIndex = 8;
            this.bFond.Text = "fond";
            this.bFond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bFond.UseVisualStyleBackColor = true;
            this.bFond.Click += new System.EventHandler(this.bFond_Click);
            // 
            // bTrait
            // 
            this.bTrait.Font = new System.Drawing.Font("ObelixPro", 12F);
            this.bTrait.Image = global::GD_Decouverte.Properties.Resources._15165_ConvertImage;
            this.bTrait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTrait.Location = new System.Drawing.Point(6, 265);
            this.bTrait.Name = "bTrait";
            this.bTrait.Size = new System.Drawing.Size(107, 46);
            this.bTrait.TabIndex = 7;
            this.bTrait.Text = "trait";
            this.bTrait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bTrait.UseVisualStyleBackColor = true;
            this.bTrait.Click += new System.EventHandler(this.bTrait_Click);
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.gbParametres);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EcranSpirographe";
            this.Text = "Spirographe";
            this.Load += new System.EventHandler(this.EcranSpirographe_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranSpirographe_Paint);
            this.gbParametres.ResumeLayout(false);
            this.gbParametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametres;
        private System.Windows.Forms.Button bExecuter;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.Label lProfondeur;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lDensite;
        private System.Windows.Forms.TrackBar tbSommet;
        private System.Windows.Forms.Label lSommet;
        private System.Windows.Forms.Button bTrait;
        private System.Windows.Forms.Button bFond;
        private System.Windows.Forms.ColorDialog dCouleur;
    }
}