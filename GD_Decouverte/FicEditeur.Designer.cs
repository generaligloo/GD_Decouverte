namespace GD_Decouverte
{
    partial class EcranEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranEditeur));
            this.msCommande = new System.Windows.Forms.MenuStrip();
            this.mcFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mcFichierNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mcFichierOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mcFichierEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mcFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mcEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.mcEditerCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.mcEditerCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.mcEditerColler = new System.Windows.Forms.ToolStripMenuItem();
            this.mcFormater = new System.Windows.Forms.ToolStripMenuItem();
            this.mcFormaterJustifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mcJustifierGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mcJustifierDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mcjustifierCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.mcFormaterPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.caractèreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mcCaractèreGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mcCaractèreItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.mcCaractèreSouligné = new System.Windows.Forms.ToolStripMenuItem();
            this.mcCaractèreBarré = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bQuitter = new System.Windows.Forms.PictureBox();
            this.bEnregistrer = new System.Windows.Forms.PictureBox();
            this.bOuvrir = new System.Windows.Forms.PictureBox();
            this.bNouveau = new System.Windows.Forms.PictureBox();
            this.rtbEditeur = new System.Windows.Forms.RichTextBox();
            this.dOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.dEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.dPolice = new System.Windows.Forms.FontDialog();
            this.msCommande.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEnregistrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOuvrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNouveau)).BeginInit();
            this.SuspendLayout();
            // 
            // msCommande
            // 
            this.msCommande.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcFichier,
            this.mcEditer,
            this.mcFormater});
            this.msCommande.Location = new System.Drawing.Point(0, 0);
            this.msCommande.Name = "msCommande";
            this.msCommande.Size = new System.Drawing.Size(800, 24);
            this.msCommande.TabIndex = 0;
            this.msCommande.Text = "menuStrip1";
            // 
            // mcFichier
            // 
            this.mcFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcFichierNouveau,
            this.toolStripMenuItem1,
            this.mcFichierOuvrir,
            this.mcFichierEnregistrer,
            this.toolStripMenuItem2,
            this.mcFichierQuitter});
            this.mcFichier.Name = "mcFichier";
            this.mcFichier.Size = new System.Drawing.Size(54, 20);
            this.mcFichier.Text = "Fichier";
            // 
            // mcFichierNouveau
            // 
            this.mcFichierNouveau.Name = "mcFichierNouveau";
            this.mcFichierNouveau.Size = new System.Drawing.Size(130, 22);
            this.mcFichierNouveau.Text = "Nouveau";
            this.mcFichierNouveau.Click += new System.EventHandler(this.mcFichierNouveau_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // mcFichierOuvrir
            // 
            this.mcFichierOuvrir.Name = "mcFichierOuvrir";
            this.mcFichierOuvrir.Size = new System.Drawing.Size(130, 22);
            this.mcFichierOuvrir.Text = "Ouvrir";
            this.mcFichierOuvrir.Click += new System.EventHandler(this.mcFichierOuvrir_Click);
            // 
            // mcFichierEnregistrer
            // 
            this.mcFichierEnregistrer.Name = "mcFichierEnregistrer";
            this.mcFichierEnregistrer.Size = new System.Drawing.Size(130, 22);
            this.mcFichierEnregistrer.Text = "Enregistrer";
            this.mcFichierEnregistrer.Click += new System.EventHandler(this.mcFichierEnregistrer_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // mcFichierQuitter
            // 
            this.mcFichierQuitter.Name = "mcFichierQuitter";
            this.mcFichierQuitter.Size = new System.Drawing.Size(130, 22);
            this.mcFichierQuitter.Text = "Quitter";
            this.mcFichierQuitter.Click += new System.EventHandler(this.mcFichierQuitter_Click);
            // 
            // mcEditer
            // 
            this.mcEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcEditerCopier,
            this.mcEditerCouper,
            this.mcEditerColler});
            this.mcEditer.Name = "mcEditer";
            this.mcEditer.Size = new System.Drawing.Size(49, 20);
            this.mcEditer.Text = "Editer";
            // 
            // mcEditerCopier
            // 
            this.mcEditerCopier.Name = "mcEditerCopier";
            this.mcEditerCopier.Size = new System.Drawing.Size(113, 22);
            this.mcEditerCopier.Text = "Copier";
            this.mcEditerCopier.Click += new System.EventHandler(this.mcEditerCopier_Click);
            // 
            // mcEditerCouper
            // 
            this.mcEditerCouper.Name = "mcEditerCouper";
            this.mcEditerCouper.Size = new System.Drawing.Size(113, 22);
            this.mcEditerCouper.Text = "Couper";
            this.mcEditerCouper.Click += new System.EventHandler(this.mcEditerCouper_Click);
            // 
            // mcEditerColler
            // 
            this.mcEditerColler.Name = "mcEditerColler";
            this.mcEditerColler.Size = new System.Drawing.Size(113, 22);
            this.mcEditerColler.Text = "Coller";
            this.mcEditerColler.Click += new System.EventHandler(this.mcEditerColler_Click);
            // 
            // mcFormater
            // 
            this.mcFormater.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcFormaterJustifier,
            this.mcFormaterPolice,
            this.caractèreToolStripMenuItem});
            this.mcFormater.Name = "mcFormater";
            this.mcFormater.Size = new System.Drawing.Size(67, 20);
            this.mcFormater.Text = "Formater";
            // 
            // mcFormaterJustifier
            // 
            this.mcFormaterJustifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcJustifierGauche,
            this.mcJustifierDroite,
            this.mcjustifierCentre});
            this.mcFormaterJustifier.Name = "mcFormaterJustifier";
            this.mcFormaterJustifier.Size = new System.Drawing.Size(180, 22);
            this.mcFormaterJustifier.Text = "Justifier";
            // 
            // mcJustifierGauche
            // 
            this.mcJustifierGauche.Name = "mcJustifierGauche";
            this.mcJustifierGauche.Size = new System.Drawing.Size(180, 22);
            this.mcJustifierGauche.Text = "Gauche";
            this.mcJustifierGauche.Click += new System.EventHandler(this.mcJustifierGauche_Click);
            // 
            // mcJustifierDroite
            // 
            this.mcJustifierDroite.Name = "mcJustifierDroite";
            this.mcJustifierDroite.Size = new System.Drawing.Size(180, 22);
            this.mcJustifierDroite.Text = "Droite";
            this.mcJustifierDroite.Click += new System.EventHandler(this.mcJustifierDroite_Click);
            // 
            // mcjustifierCentre
            // 
            this.mcjustifierCentre.Name = "mcjustifierCentre";
            this.mcjustifierCentre.Size = new System.Drawing.Size(180, 22);
            this.mcjustifierCentre.Text = "Centre";
            this.mcjustifierCentre.Click += new System.EventHandler(this.mcjustifierCentre_Click);
            // 
            // mcFormaterPolice
            // 
            this.mcFormaterPolice.Name = "mcFormaterPolice";
            this.mcFormaterPolice.Size = new System.Drawing.Size(180, 22);
            this.mcFormaterPolice.Text = "Police";
            this.mcFormaterPolice.Click += new System.EventHandler(this.mcFormaterPolice_Click);
            // 
            // caractèreToolStripMenuItem
            // 
            this.caractèreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcCaractèreGras,
            this.mcCaractèreItalique,
            this.mcCaractèreSouligné,
            this.mcCaractèreBarré});
            this.caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            this.caractèreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // mcCaractèreGras
            // 
            this.mcCaractèreGras.Name = "mcCaractèreGras";
            this.mcCaractèreGras.Size = new System.Drawing.Size(180, 22);
            this.mcCaractèreGras.Text = "Gras";
            this.mcCaractèreGras.Click += new System.EventHandler(this.mcCaractèreGras_Click);
            // 
            // mcCaractèreItalique
            // 
            this.mcCaractèreItalique.Name = "mcCaractèreItalique";
            this.mcCaractèreItalique.Size = new System.Drawing.Size(180, 22);
            this.mcCaractèreItalique.Text = "Italique";
            this.mcCaractèreItalique.Click += new System.EventHandler(this.mcCaractèreItalique_Click);
            // 
            // mcCaractèreSouligné
            // 
            this.mcCaractèreSouligné.Name = "mcCaractèreSouligné";
            this.mcCaractèreSouligné.Size = new System.Drawing.Size(180, 22);
            this.mcCaractèreSouligné.Text = "Souligné";
            this.mcCaractèreSouligné.Click += new System.EventHandler(this.mcCaractèreSouligné_Click);
            // 
            // mcCaractèreBarré
            // 
            this.mcCaractèreBarré.Name = "mcCaractèreBarré";
            this.mcCaractèreBarré.Size = new System.Drawing.Size(180, 22);
            this.mcCaractèreBarré.Text = "Barré";
            this.mcCaractèreBarré.Click += new System.EventHandler(this.mcCaractèreBarré_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bQuitter);
            this.panel1.Controls.Add(this.bEnregistrer);
            this.panel1.Controls.Add(this.bOuvrir);
            this.panel1.Controls.Add(this.bNouveau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 1;
            // 
            // bQuitter
            // 
            this.bQuitter.Image = ((System.Drawing.Image)(resources.GetObject("bQuitter.Image")));
            this.bQuitter.Location = new System.Drawing.Point(105, 3);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(28, 28);
            this.bQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bQuitter.TabIndex = 3;
            this.bQuitter.TabStop = false;
            this.bQuitter.Click += new System.EventHandler(this.mcFichierQuitter_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("bEnregistrer.Image")));
            this.bEnregistrer.Location = new System.Drawing.Point(71, 3);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(28, 28);
            this.bEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bEnregistrer.TabIndex = 2;
            this.bEnregistrer.TabStop = false;
            this.bEnregistrer.Click += new System.EventHandler(this.mcFichierEnregistrer_Click);
            // 
            // bOuvrir
            // 
            this.bOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("bOuvrir.Image")));
            this.bOuvrir.Location = new System.Drawing.Point(37, 3);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(28, 28);
            this.bOuvrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bOuvrir.TabIndex = 1;
            this.bOuvrir.TabStop = false;
            this.bOuvrir.Click += new System.EventHandler(this.mcFichierOuvrir_Click);
            // 
            // bNouveau
            // 
            this.bNouveau.Image = ((System.Drawing.Image)(resources.GetObject("bNouveau.Image")));
            this.bNouveau.Location = new System.Drawing.Point(3, 3);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(28, 28);
            this.bNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bNouveau.TabIndex = 0;
            this.bNouveau.TabStop = false;
            this.bNouveau.Click += new System.EventHandler(this.mcFichierNouveau_Click);
            // 
            // rtbEditeur
            // 
            this.rtbEditeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditeur.Location = new System.Drawing.Point(0, 59);
            this.rtbEditeur.Name = "rtbEditeur";
            this.rtbEditeur.Size = new System.Drawing.Size(800, 391);
            this.rtbEditeur.TabIndex = 2;
            this.rtbEditeur.Text = "";
            this.rtbEditeur.TextChanged += new System.EventHandler(this.rtbEditeur_TextChanged);
            // 
            // dOuvrir
            // 
            this.dOuvrir.Filter = "Mes fichiers Textes |*.mesdoc| Tout fichier|*.*";
            // 
            // dEnregistrer
            // 
            this.dEnregistrer.Filter = "Mes fichiers Textes |*.mesdoc| Tout fichier|*.*";
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbEditeur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msCommande);
            this.MainMenuStrip = this.msCommande;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranEditeur";
            this.Text = "Traitement de texte";
            this.Load += new System.EventHandler(this.EcranEditeur_Load);
            this.msCommande.ResumeLayout(false);
            this.msCommande.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEnregistrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOuvrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNouveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCommande;
        private System.Windows.Forms.ToolStripMenuItem mcFichier;
        private System.Windows.Forms.ToolStripMenuItem mcFichierNouveau;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mcFichierOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mcFichierEnregistrer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mcFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mcEditer;
        private System.Windows.Forms.ToolStripMenuItem mcEditerCopier;
        private System.Windows.Forms.ToolStripMenuItem mcEditerCouper;
        private System.Windows.Forms.ToolStripMenuItem mcEditerColler;
        private System.Windows.Forms.ToolStripMenuItem mcFormater;
        private System.Windows.Forms.ToolStripMenuItem mcFormaterJustifier;
        private System.Windows.Forms.ToolStripMenuItem mcJustifierGauche;
        private System.Windows.Forms.ToolStripMenuItem mcJustifierDroite;
        private System.Windows.Forms.ToolStripMenuItem mcjustifierCentre;
        private System.Windows.Forms.ToolStripMenuItem mcFormaterPolice;
        private System.Windows.Forms.ToolStripMenuItem caractèreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mcCaractèreGras;
        private System.Windows.Forms.ToolStripMenuItem mcCaractèreItalique;
        private System.Windows.Forms.ToolStripMenuItem mcCaractèreSouligné;
        private System.Windows.Forms.ToolStripMenuItem mcCaractèreBarré;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bQuitter;
        private System.Windows.Forms.PictureBox bEnregistrer;
        private System.Windows.Forms.PictureBox bOuvrir;
        private System.Windows.Forms.PictureBox bNouveau;
        private System.Windows.Forms.RichTextBox rtbEditeur;
        private System.Windows.Forms.OpenFileDialog dOuvrir;
        private System.Windows.Forms.SaveFileDialog dEnregistrer;
        private System.Windows.Forms.FontDialog dPolice;
    }
}