
namespace GD_Decouverte
{
    partial class EcranBDCouches
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
            this.components = new System.ComponentModel.Container();
            this.DGVpersonne = new System.Windows.Forms.DataGridView();
            this.Bajouter = new System.Windows.Forms.Button();
            this.Bediter = new System.Windows.Forms.Button();
            this.Bsupprimer = new System.Windows.Forms.Button();
            this.LBidentifiant = new System.Windows.Forms.Label();
            this.TBid = new System.Windows.Forms.TextBox();
            this.TBpre = new System.Windows.Forms.TextBox();
            this.LBpre = new System.Windows.Forms.Label();
            this.TBnom = new System.Windows.Forms.TextBox();
            this.LBnom = new System.Windows.Forms.Label();
            this.LBnai = new System.Windows.Forms.Label();
            this.DTPnai = new System.Windows.Forms.DateTimePicker();
            this.Bconfirmer = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAffiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDpersonneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDpersonneDataSet = new GD_Decouverte.BDpersonneDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpersonneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpersonneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVpersonne
            // 
            this.DGVpersonne.AllowUserToAddRows = false;
            this.DGVpersonne.AllowUserToDeleteRows = false;
            this.DGVpersonne.AutoGenerateColumns = false;
            this.DGVpersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cAffiche});
            this.DGVpersonne.DataSource = this.bDpersonneDataSetBindingSource;
            this.DGVpersonne.Location = new System.Drawing.Point(12, 12);
            this.DGVpersonne.MultiSelect = false;
            this.DGVpersonne.Name = "DGVpersonne";
            this.DGVpersonne.ReadOnly = true;
            this.DGVpersonne.RowHeadersVisible = false;
            this.DGVpersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVpersonne.Size = new System.Drawing.Size(363, 193);
            this.DGVpersonne.TabIndex = 0;
            // 
            // Bajouter
            // 
            this.Bajouter.Location = new System.Drawing.Point(12, 211);
            this.Bajouter.Name = "Bajouter";
            this.Bajouter.Size = new System.Drawing.Size(75, 23);
            this.Bajouter.TabIndex = 1;
            this.Bajouter.Text = "Ajouter";
            this.Bajouter.UseVisualStyleBackColor = true;
            this.Bajouter.Click += new System.EventHandler(this.Bajouter_Click);
            // 
            // Bediter
            // 
            this.Bediter.Location = new System.Drawing.Point(154, 211);
            this.Bediter.Name = "Bediter";
            this.Bediter.Size = new System.Drawing.Size(75, 23);
            this.Bediter.TabIndex = 2;
            this.Bediter.Text = "Editer";
            this.Bediter.UseVisualStyleBackColor = true;
            this.Bediter.Click += new System.EventHandler(this.Bediter_Click);
            // 
            // Bsupprimer
            // 
            this.Bsupprimer.Location = new System.Drawing.Point(300, 211);
            this.Bsupprimer.Name = "Bsupprimer";
            this.Bsupprimer.Size = new System.Drawing.Size(75, 23);
            this.Bsupprimer.TabIndex = 3;
            this.Bsupprimer.Text = "Supprimer";
            this.Bsupprimer.UseVisualStyleBackColor = true;
            this.Bsupprimer.Click += new System.EventHandler(this.Bsupprimer_Click);
            // 
            // LBidentifiant
            // 
            this.LBidentifiant.AutoSize = true;
            this.LBidentifiant.Location = new System.Drawing.Point(9, 242);
            this.LBidentifiant.Name = "LBidentifiant";
            this.LBidentifiant.Size = new System.Drawing.Size(53, 13);
            this.LBidentifiant.TabIndex = 4;
            this.LBidentifiant.Text = "Identifiant";
            // 
            // TBid
            // 
            this.TBid.Location = new System.Drawing.Point(12, 258);
            this.TBid.Name = "TBid";
            this.TBid.ReadOnly = true;
            this.TBid.Size = new System.Drawing.Size(179, 20);
            this.TBid.TabIndex = 5;
            this.TBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBpre
            // 
            this.TBpre.Location = new System.Drawing.Point(12, 301);
            this.TBpre.Name = "TBpre";
            this.TBpre.Size = new System.Drawing.Size(179, 20);
            this.TBpre.TabIndex = 4;
            // 
            // LBpre
            // 
            this.LBpre.AutoSize = true;
            this.LBpre.Location = new System.Drawing.Point(9, 284);
            this.LBpre.Name = "LBpre";
            this.LBpre.Size = new System.Drawing.Size(43, 13);
            this.LBpre.TabIndex = 6;
            this.LBpre.Text = "Prénom";
            // 
            // TBnom
            // 
            this.TBnom.Location = new System.Drawing.Point(202, 301);
            this.TBnom.Name = "TBnom";
            this.TBnom.Size = new System.Drawing.Size(179, 20);
            this.TBnom.TabIndex = 5;
            // 
            // LBnom
            // 
            this.LBnom.AutoSize = true;
            this.LBnom.Location = new System.Drawing.Point(199, 284);
            this.LBnom.Name = "LBnom";
            this.LBnom.Size = new System.Drawing.Size(29, 13);
            this.LBnom.TabIndex = 8;
            this.LBnom.Text = "Nom";
            // 
            // LBnai
            // 
            this.LBnai.AutoSize = true;
            this.LBnai.Location = new System.Drawing.Point(199, 242);
            this.LBnai.Name = "LBnai";
            this.LBnai.Size = new System.Drawing.Size(98, 13);
            this.LBnai.TabIndex = 10;
            this.LBnai.Text = "Date de Naissance";
            // 
            // DTPnai
            // 
            this.DTPnai.Location = new System.Drawing.Point(202, 258);
            this.DTPnai.Name = "DTPnai";
            this.DTPnai.Size = new System.Drawing.Size(179, 20);
            this.DTPnai.TabIndex = 6;
            // 
            // Bconfirmer
            // 
            this.Bconfirmer.Location = new System.Drawing.Point(12, 327);
            this.Bconfirmer.Name = "Bconfirmer";
            this.Bconfirmer.Size = new System.Drawing.Size(179, 23);
            this.Bconfirmer.TabIndex = 7;
            this.Bconfirmer.Text = "Confirmer";
            this.Bconfirmer.UseVisualStyleBackColor = true;
            this.Bconfirmer.Click += new System.EventHandler(this.Bconfirmer_Click);
            // 
            // Bannuler
            // 
            this.Bannuler.Location = new System.Drawing.Point(202, 327);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(179, 23);
            this.Bannuler.TabIndex = 8;
            this.Bannuler.Text = "Annuler";
            this.Bannuler.UseVisualStyleBackColor = true;
            this.Bannuler.Click += new System.EventHandler(this.Bannuler_Click);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.Frozen = true;
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cAffiche
            // 
            this.cAffiche.DataPropertyName = "Afficher";
            this.cAffiche.HeaderText = "Prénom et nom";
            this.cAffiche.Name = "cAffiche";
            this.cAffiche.ReadOnly = true;
            this.cAffiche.Width = 300;
            // 
            // bDpersonneDataSetBindingSource
            // 
            this.bDpersonneDataSetBindingSource.DataSource = this.bDpersonneDataSet;
            this.bDpersonneDataSetBindingSource.Position = 0;
            // 
            // bDpersonneDataSet
            // 
            this.bDpersonneDataSet.DataSetName = "BDpersonneDataSet";
            this.bDpersonneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EcranBDCouches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 359);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.Bconfirmer);
            this.Controls.Add(this.DTPnai);
            this.Controls.Add(this.LBnai);
            this.Controls.Add(this.TBnom);
            this.Controls.Add(this.LBnom);
            this.Controls.Add(this.TBpre);
            this.Controls.Add(this.LBpre);
            this.Controls.Add(this.TBid);
            this.Controls.Add(this.LBidentifiant);
            this.Controls.Add(this.Bsupprimer);
            this.Controls.Add(this.Bediter);
            this.Controls.Add(this.Bajouter);
            this.Controls.Add(this.DGVpersonne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBDCouches";
            this.Text = "FicBDCouches";
            this.Load += new System.EventHandler(this.EcranBDCouches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpersonneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDpersonneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVpersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAffiche;
        private System.Windows.Forms.BindingSource bDpersonneDataSetBindingSource;
        private BDpersonneDataSet bDpersonneDataSet;
        private System.Windows.Forms.Button Bajouter;
        private System.Windows.Forms.Button Bediter;
        private System.Windows.Forms.Button Bsupprimer;
        private System.Windows.Forms.Label LBidentifiant;
        private System.Windows.Forms.TextBox TBid;
        private System.Windows.Forms.TextBox TBpre;
        private System.Windows.Forms.Label LBpre;
        private System.Windows.Forms.TextBox TBnom;
        private System.Windows.Forms.Label LBnom;
        private System.Windows.Forms.Label LBnai;
        private System.Windows.Forms.DateTimePicker DTPnai;
        private System.Windows.Forms.Button Bconfirmer;
        private System.Windows.Forms.Button Bannuler;
    }
}