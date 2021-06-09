namespace GD_Decouverte
{
    partial class EcranListe
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
            this.lFichier = new System.Windows.Forms.Label();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.bOuvrir = new System.Windows.Forms.Button();
            this.bEnregrister = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lQualite = new System.Windows.Forms.Label();
            this.cbQualité = new System.Windows.Forms.ComboBox();
            this.lNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.bModifier = new System.Windows.Forms.Button();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFichier
            // 
            this.lFichier.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFichier.Location = new System.Drawing.Point(13, 13);
            this.lFichier.Name = "lFichier";
            this.lFichier.Size = new System.Drawing.Size(394, 18);
            this.lFichier.TabIndex = 0;
            this.lFichier.Text = "Nom du fichier";
            this.lFichier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPersonne
            // 
            this.lbPersonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.Location = new System.Drawing.Point(16, 35);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(391, 184);
            this.lbPersonne.Sorted = true;
            this.lbPersonne.TabIndex = 1;
            this.lbPersonne.DoubleClick += new System.EventHandler(this.lbPersonne_DoubleClick);
            // 
            // bOuvrir
            // 
            this.bOuvrir.Location = new System.Drawing.Point(16, 226);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(125, 23);
            this.bOuvrir.TabIndex = 2;
            this.bOuvrir.Text = "Ouvrir";
            this.bOuvrir.UseVisualStyleBackColor = true;
            this.bOuvrir.Click += new System.EventHandler(this.bOuvrir_Click);
            // 
            // bEnregrister
            // 
            this.bEnregrister.Location = new System.Drawing.Point(16, 255);
            this.bEnregrister.Name = "bEnregrister";
            this.bEnregrister.Size = new System.Drawing.Size(125, 23);
            this.bEnregrister.TabIndex = 3;
            this.bEnregrister.Text = "Enregistrer";
            this.bEnregrister.UseVisualStyleBackColor = true;
            this.bEnregrister.Click += new System.EventHandler(this.bEnregrister_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(16, 314);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(125, 23);
            this.bAjouter.TabIndex = 4;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(16, 343);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(125, 23);
            this.bSupprimer.TabIndex = 5;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.bAnnuler);
            this.gbDetail.Controls.Add(this.bConfirmer);
            this.gbDetail.Controls.Add(this.tbNom);
            this.gbDetail.Controls.Add(this.lNom);
            this.gbDetail.Controls.Add(this.cbQualité);
            this.gbDetail.Controls.Add(this.lQualite);
            this.gbDetail.Location = new System.Drawing.Point(147, 226);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(260, 140);
            this.gbDetail.TabIndex = 6;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Détail";
            // 
            // lQualite
            // 
            this.lQualite.AutoSize = true;
            this.lQualite.Location = new System.Drawing.Point(7, 20);
            this.lQualite.Name = "lQualite";
            this.lQualite.Size = new System.Drawing.Size(40, 13);
            this.lQualite.TabIndex = 0;
            this.lQualite.Text = "Qualité";
            // 
            // cbQualité
            // 
            this.cbQualité.FormattingEnabled = true;
            this.cbQualité.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "Mondamoiseau",
            "Autre"});
            this.cbQualité.Location = new System.Drawing.Point(10, 37);
            this.cbQualité.Name = "cbQualité";
            this.cbQualité.Size = new System.Drawing.Size(244, 21);
            this.cbQualité.TabIndex = 1;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(7, 61);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 2;
            this.lNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(10, 78);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(244, 20);
            this.tbNom.TabIndex = 3;
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(10, 105);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(75, 23);
            this.bConfirmer.TabIndex = 4;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(179, 104);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 5;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            this.ofdOuvrir.Filter = "Fichier texte|*.txt|Tous les fichiers|*.*";
            // 
            // sfdEnregistrer
            // 
            this.sfdEnregistrer.Filter = "Fichier texte|*.txt|Tous les fichiers|*.*";
            // 
            // bModifier
            // 
            this.bModifier.Location = new System.Drawing.Point(16, 285);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(125, 23);
            this.bModifier.TabIndex = 7;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 379);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bEnregrister);
            this.Controls.Add(this.bOuvrir);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.lFichier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranListe";
            this.Text = "Liste";
            this.Load += new System.EventHandler(this.EcranListe_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lFichier;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.Button bOuvrir;
        private System.Windows.Forms.Button bEnregrister;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.ComboBox cbQualité;
        private System.Windows.Forms.Label lQualite;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.Button bModifier;
    }
}