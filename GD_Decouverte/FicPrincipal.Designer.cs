namespace GD_Decouverte
{
    partial class EcranPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.MPrincipal = new System.Windows.Forms.MenuStrip();
            this.MControle = new System.Windows.Forms.ToolStripMenuItem();
            this.MCListe = new System.Windows.Forms.ToolStripMenuItem();
            this.MCProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MCQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MAEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.MASpirographe = new System.Windows.Forms.ToolStripMenuItem();
            this.MAHorloge = new System.Windows.Forms.ToolStripMenuItem();
            this.MAhisto = new System.Windows.Forms.ToolStripMenuItem();
            this.MACarnaval = new System.Windows.Forms.ToolStripMenuItem();
            this.MAClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.MAedf = new System.Windows.Forms.ToolStripMenuItem();
            this.MAgps = new System.Windows.Forms.ToolStripMenuItem();
            this.MAbddirect = new System.Windows.Forms.ToolStripMenuItem();
            this.MAbddataset = new System.Windows.Forms.ToolStripMenuItem();
            this.MABDCouches = new System.Windows.Forms.ToolStripMenuItem();
            this.MAexpressionregu = new System.Windows.Forms.ToolStripMenuItem();
            this.MAintégration = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_Processus = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_philo = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_vente = new System.Windows.Forms.ToolStripMenuItem();
            this.MA_Sérialisation = new System.Windows.Forms.ToolStripMenuItem();
            this.MAide = new System.Windows.Forms.ToolStripMenuItem();
            this.MAIPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramme1 = new GD_2021_MesControles.Histogramme();
            this.MPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MPrincipal
            // 
            this.MPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MControle,
            this.MApplication,
            this.MAide});
            this.MPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MPrincipal.Name = "MPrincipal";
            this.MPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MPrincipal.TabIndex = 0;
            this.MPrincipal.Text = "menuStrip1";
            // 
            // MControle
            // 
            this.MControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCListe,
            this.MCProgression,
            this.toolStripMenuItem1,
            this.MCQuitter});
            this.MControle.Name = "MControle";
            this.MControle.Size = new System.Drawing.Size(70, 20);
            this.MControle.Text = "Contrôles";
            // 
            // MCListe
            // 
            this.MCListe.Name = "MCListe";
            this.MCListe.Size = new System.Drawing.Size(187, 22);
            this.MCListe.Text = "&Liste";
            this.MCListe.Click += new System.EventHandler(this.MCListe_Click);
            // 
            // MCProgression
            // 
            this.MCProgression.Name = "MCProgression";
            this.MCProgression.Size = new System.Drawing.Size(187, 22);
            this.MCProgression.Text = "&Barres de progression";
            this.MCProgression.Click += new System.EventHandler(this.MCProgression_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // MCQuitter
            // 
            this.MCQuitter.Name = "MCQuitter";
            this.MCQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MCQuitter.Size = new System.Drawing.Size(187, 22);
            this.MCQuitter.Text = "Quitter";
            this.MCQuitter.Click += new System.EventHandler(this.MCQuitter_Click);
            // 
            // MApplication
            // 
            this.MApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAEditeur,
            this.MASpirographe,
            this.MAHorloge,
            this.MAhisto,
            this.MACarnaval,
            this.MAClavierSouris,
            this.MAedf,
            this.MAgps,
            this.MAbddirect,
            this.MAbddataset,
            this.MABDCouches,
            this.MAexpressionregu,
            this.MAintégration,
            this.MA_Processus,
            this.MA_philo,
            this.MA_vente,
            this.MA_Sérialisation});
            this.MApplication.Name = "MApplication";
            this.MApplication.Size = new System.Drawing.Size(85, 20);
            this.MApplication.Text = "Applications";
            // 
            // MAEditeur
            // 
            this.MAEditeur.Name = "MAEditeur";
            this.MAEditeur.Size = new System.Drawing.Size(217, 22);
            this.MAEditeur.Text = "Editeur";
            this.MAEditeur.Click += new System.EventHandler(this.MAEditeur_Click);
            // 
            // MASpirographe
            // 
            this.MASpirographe.Name = "MASpirographe";
            this.MASpirographe.Size = new System.Drawing.Size(217, 22);
            this.MASpirographe.Text = "Spirographe";
            this.MASpirographe.Click += new System.EventHandler(this.maSpirographe_Click);
            // 
            // MAHorloge
            // 
            this.MAHorloge.Name = "MAHorloge";
            this.MAHorloge.Size = new System.Drawing.Size(217, 22);
            this.MAHorloge.Text = "Horloge";
            this.MAHorloge.Click += new System.EventHandler(this.horlogeToolStripMenuItem_Click);
            // 
            // MAhisto
            // 
            this.MAhisto.Name = "MAhisto";
            this.MAhisto.Size = new System.Drawing.Size(217, 22);
            this.MAhisto.Text = "Histogramme aléatoire";
            this.MAhisto.Click += new System.EventHandler(this.MAhisto_Click);
            // 
            // MACarnaval
            // 
            this.MACarnaval.Name = "MACarnaval";
            this.MACarnaval.Size = new System.Drawing.Size(217, 22);
            this.MACarnaval.Text = "Carnaval";
            this.MACarnaval.Click += new System.EventHandler(this.MACarnaval_Click);
            // 
            // MAClavierSouris
            // 
            this.MAClavierSouris.Name = "MAClavierSouris";
            this.MAClavierSouris.Size = new System.Drawing.Size(217, 22);
            this.MAClavierSouris.Text = "Clavier/Souris";
            this.MAClavierSouris.Click += new System.EventHandler(this.MAClavierSouris_Click);
            // 
            // MAedf
            // 
            this.MAedf.Name = "MAedf";
            this.MAedf.Size = new System.Drawing.Size(217, 22);
            this.MAedf.Text = "Explorateur de fichier";
            this.MAedf.Click += new System.EventHandler(this.MAedf_Click);
            // 
            // MAgps
            // 
            this.MAgps.Name = "MAgps";
            this.MAgps.Size = new System.Drawing.Size(217, 22);
            this.MAgps.Text = "Lecture GPS";
            this.MAgps.Click += new System.EventHandler(this.MAgps_Click);
            // 
            // MAbddirect
            // 
            this.MAbddirect.Name = "MAbddirect";
            this.MAbddirect.Size = new System.Drawing.Size(217, 22);
            this.MAbddirect.Text = "Base de données (direct)";
            this.MAbddirect.Click += new System.EventHandler(this.MAbddirect_Click);
            // 
            // MAbddataset
            // 
            this.MAbddataset.Name = "MAbddataset";
            this.MAbddataset.Size = new System.Drawing.Size(217, 22);
            this.MAbddataset.Text = "Base de données (DTS)";
            this.MAbddataset.Click += new System.EventHandler(this.MAbddataset_Click);
            // 
            // MABDCouches
            // 
            this.MABDCouches.Name = "MABDCouches";
            this.MABDCouches.Size = new System.Drawing.Size(217, 22);
            this.MABDCouches.Text = "Base de données (couches)";
            this.MABDCouches.Click += new System.EventHandler(this.MABDCouches_Click);
            // 
            // MAexpressionregu
            // 
            this.MAexpressionregu.Name = "MAexpressionregu";
            this.MAexpressionregu.Size = new System.Drawing.Size(217, 22);
            this.MAexpressionregu.Text = "Expression régulière";
            this.MAexpressionregu.Click += new System.EventHandler(this.MAexpressionregu_Click);
            // 
            // MAintégration
            // 
            this.MAintégration.Name = "MAintégration";
            this.MAintégration.Size = new System.Drawing.Size(217, 22);
            this.MAintégration.Text = "Intégration";
            this.MAintégration.Click += new System.EventHandler(this.MAintégration_Click);
            // 
            // MA_Processus
            // 
            this.MA_Processus.Name = "MA_Processus";
            this.MA_Processus.Size = new System.Drawing.Size(217, 22);
            this.MA_Processus.Text = "Processus";
            this.MA_Processus.Click += new System.EventHandler(this.MA_Processus_Click);
            // 
            // MA_philo
            // 
            this.MA_philo.Name = "MA_philo";
            this.MA_philo.Size = new System.Drawing.Size(217, 22);
            this.MA_philo.Text = "Dîner des philosophes";
            this.MA_philo.Click += new System.EventHandler(this.MA_philo_Click);
            // 
            // MA_vente
            // 
            this.MA_vente.Name = "MA_vente";
            this.MA_vente.Size = new System.Drawing.Size(217, 22);
            this.MA_vente.Text = "Vente de ticket";
            this.MA_vente.Click += new System.EventHandler(this.MA_vente_Click);
            // 
            // MA_Sérialisation
            // 
            this.MA_Sérialisation.Name = "MA_Sérialisation";
            this.MA_Sérialisation.Size = new System.Drawing.Size(217, 22);
            this.MA_Sérialisation.Text = "Sérialisation";
            this.MA_Sérialisation.Click += new System.EventHandler(this.MA_Sérialisation_Click);
            // 
            // MAide
            // 
            this.MAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAIPropos});
            this.MAide.Name = "MAide";
            this.MAide.Size = new System.Drawing.Size(43, 20);
            this.MAide.Text = "Aide";
            // 
            // MAIPropos
            // 
            this.MAIPropos.Name = "MAIPropos";
            this.MAIPropos.Size = new System.Drawing.Size(122, 22);
            this.MAIPropos.Text = "A propos";
            this.MAIPropos.Click += new System.EventHandler(this.MAIPropos_Click);
            // 
            // histogramme1
            // 
            this.histogramme1.Entrees.Add(((GD_2021_MesControles.MonPoint)(resources.GetObject("histogramme1.Entrees"))));
            this.histogramme1.Entrees.Add(((GD_2021_MesControles.MonPoint)(resources.GetObject("histogramme1.Entrees1"))));
            this.histogramme1.Entrees.Add(((GD_2021_MesControles.MonPoint)(resources.GetObject("histogramme1.Entrees2"))));
            this.histogramme1.Location = new System.Drawing.Point(12, 251);
            this.histogramme1.Name = "histogramme1";
            this.histogramme1.Size = new System.Drawing.Size(776, 187);
            this.histogramme1.TabIndex = 1;
            this.histogramme1.Trait = System.Drawing.Color.DarkMagenta;
            this.histogramme1.XMax = 110;
            this.histogramme1.XMin = -10;
            this.histogramme1.YMax = 110;
            this.histogramme1.YMin = -10;
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.histogramme1);
            this.Controls.Add(this.MPrincipal);
            this.MainMenuStrip = this.MPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.EcranPrincipal_Load);
            this.MPrincipal.ResumeLayout(false);
            this.MPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MControle;
        private System.Windows.Forms.ToolStripMenuItem MCListe;
        private System.Windows.Forms.ToolStripMenuItem MCProgression;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MCQuitter;
        private System.Windows.Forms.ToolStripMenuItem MApplication;
        private System.Windows.Forms.ToolStripMenuItem MAEditeur;
        private System.Windows.Forms.ToolStripMenuItem MAide;
        private System.Windows.Forms.ToolStripMenuItem MAIPropos;
        private System.Windows.Forms.ToolStripMenuItem MASpirographe;
        private System.Windows.Forms.ToolStripMenuItem MAHorloge;
        private System.Windows.Forms.ToolStripMenuItem MAhisto;
        private System.Windows.Forms.ToolStripMenuItem MACarnaval;
        private System.Windows.Forms.ToolStripMenuItem MAClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem MAedf;
        private System.Windows.Forms.ToolStripMenuItem MAgps;
        private System.Windows.Forms.ToolStripMenuItem MAbddirect;
        private System.Windows.Forms.ToolStripMenuItem MAbddataset;
        private System.Windows.Forms.ToolStripMenuItem MABDCouches;
        private System.Windows.Forms.ToolStripMenuItem MAexpressionregu;
        private System.Windows.Forms.ToolStripMenuItem MAintégration;
        private GD_2021_MesControles.Histogramme histogramme1;
        private System.Windows.Forms.ToolStripMenuItem MA_Processus;
        private System.Windows.Forms.ToolStripMenuItem MA_philo;
        private System.Windows.Forms.ToolStripMenuItem MA_vente;
        private System.Windows.Forms.ToolStripMenuItem MA_Sérialisation;
    }
}