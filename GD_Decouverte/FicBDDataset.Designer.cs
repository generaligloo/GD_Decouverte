
namespace GD_Decouverte
{
    partial class EcranBDDataset
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
            this.DGVclient = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoDataSet = new GD_Decouverte.persoDataSet();
            this.clientTableAdapter = new GD_Decouverte.persoDataSetTableAdapters.ClientTableAdapter();
            this.nUMCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBid = new System.Windows.Forms.Label();
            this.TBid = new System.Windows.Forms.TextBox();
            this.TBpre = new System.Windows.Forms.TextBox();
            this.LBpre = new System.Windows.Forms.Label();
            this.TBnom = new System.Windows.Forms.TextBox();
            this.LBnom = new System.Windows.Forms.Label();
            this.LBdate = new System.Windows.Forms.Label();
            this.DTPnaissance = new System.Windows.Forms.DateTimePicker();
            this.Bpremier = new System.Windows.Forms.Button();
            this.Bprecedent = new System.Windows.Forms.Button();
            this.Bdernier = new System.Windows.Forms.Button();
            this.Bsuivant = new System.Windows.Forms.Button();
            this.LBposition = new System.Windows.Forms.Label();
            this.Bconfirmer = new System.Windows.Forms.Button();
            this.Bannuler = new System.Windows.Forms.Button();
            this.Bediter = new System.Windows.Forms.Button();
            this.Bajouter = new System.Windows.Forms.Button();
            this.Bsupprimer = new System.Windows.Forms.Button();
            this.DGV_commande = new System.Windows.Forms.DataGridView();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new GD_Decouverte.persoDataSetTableAdapters.CommandeTableAdapter();
            this.nUMCOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMCLIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVclient
            // 
            this.DGVclient.AllowUserToAddRows = false;
            this.DGVclient.AllowUserToDeleteRows = false;
            this.DGVclient.AutoGenerateColumns = false;
            this.DGVclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMCLIDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pREDataGridViewTextBoxColumn,
            this.nAIDataGridViewTextBoxColumn});
            this.DGVclient.DataSource = this.clientBindingSource;
            this.DGVclient.Location = new System.Drawing.Point(271, 23);
            this.DGVclient.Name = "DGVclient";
            this.DGVclient.ReadOnly = true;
            this.DGVclient.RowHeadersVisible = false;
            this.DGVclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVclient.Size = new System.Drawing.Size(361, 150);
            this.DGVclient.TabIndex = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.persoDataSetBindingSource;
            this.clientBindingSource.CurrentChanged += new System.EventHandler(this.clientBindingSource_CurrentChanged);
            // 
            // persoDataSetBindingSource
            // 
            this.persoDataSetBindingSource.DataSource = this.persoDataSet;
            this.persoDataSetBindingSource.Position = 0;
            // 
            // persoDataSet
            // 
            this.persoDataSet.DataSetName = "persoDataSet";
            this.persoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // nUMCLIDataGridViewTextBoxColumn
            // 
            this.nUMCLIDataGridViewTextBoxColumn.DataPropertyName = "NUMCLI";
            this.nUMCLIDataGridViewTextBoxColumn.HeaderText = "ID client";
            this.nUMCLIDataGridViewTextBoxColumn.Name = "nUMCLIDataGridViewTextBoxColumn";
            this.nUMCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMCLIDataGridViewTextBoxColumn.Width = 70;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pREDataGridViewTextBoxColumn
            // 
            this.pREDataGridViewTextBoxColumn.DataPropertyName = "PRE";
            this.pREDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.pREDataGridViewTextBoxColumn.Name = "pREDataGridViewTextBoxColumn";
            this.pREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAIDataGridViewTextBoxColumn
            // 
            this.nAIDataGridViewTextBoxColumn.DataPropertyName = "NAI";
            this.nAIDataGridViewTextBoxColumn.HeaderText = "Naissance";
            this.nAIDataGridViewTextBoxColumn.Name = "nAIDataGridViewTextBoxColumn";
            this.nAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAIDataGridViewTextBoxColumn.Visible = false;
            // 
            // LBid
            // 
            this.LBid.AutoSize = true;
            this.LBid.Location = new System.Drawing.Point(12, 12);
            this.LBid.Name = "LBid";
            this.LBid.Size = new System.Drawing.Size(53, 13);
            this.LBid.TabIndex = 1;
            this.LBid.Text = "Identifiant";
            // 
            // TBid
            // 
            this.TBid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NUMCLI", true));
            this.TBid.Location = new System.Drawing.Point(12, 28);
            this.TBid.Name = "TBid";
            this.TBid.ReadOnly = true;
            this.TBid.Size = new System.Drawing.Size(235, 20);
            this.TBid.TabIndex = 2;
            this.TBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBpre
            // 
            this.TBpre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
            this.TBpre.Location = new System.Drawing.Point(12, 75);
            this.TBpre.Name = "TBpre";
            this.TBpre.Size = new System.Drawing.Size(235, 20);
            this.TBpre.TabIndex = 4;
            this.TBpre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBpre
            // 
            this.LBpre.AutoSize = true;
            this.LBpre.Location = new System.Drawing.Point(12, 59);
            this.LBpre.Name = "LBpre";
            this.LBpre.Size = new System.Drawing.Size(43, 13);
            this.LBpre.TabIndex = 3;
            this.LBpre.Text = "Prénom";
            // 
            // TBnom
            // 
            this.TBnom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.TBnom.Location = new System.Drawing.Point(12, 114);
            this.TBnom.Name = "TBnom";
            this.TBnom.Size = new System.Drawing.Size(235, 20);
            this.TBnom.TabIndex = 6;
            this.TBnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBnom
            // 
            this.LBnom.AutoSize = true;
            this.LBnom.Location = new System.Drawing.Point(12, 98);
            this.LBnom.Name = "LBnom";
            this.LBnom.Size = new System.Drawing.Size(29, 13);
            this.LBnom.TabIndex = 5;
            this.LBnom.Text = "Nom";
            // 
            // LBdate
            // 
            this.LBdate.AutoSize = true;
            this.LBdate.Location = new System.Drawing.Point(12, 137);
            this.LBdate.Name = "LBdate";
            this.LBdate.Size = new System.Drawing.Size(57, 13);
            this.LBdate.TabIndex = 7;
            this.LBdate.Text = "Naissance";
            // 
            // DTPnaissance
            // 
            this.DTPnaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
            this.DTPnaissance.Location = new System.Drawing.Point(12, 153);
            this.DTPnaissance.Name = "DTPnaissance";
            this.DTPnaissance.Size = new System.Drawing.Size(235, 20);
            this.DTPnaissance.TabIndex = 8;
            // 
            // Bpremier
            // 
            this.Bpremier.Location = new System.Drawing.Point(15, 180);
            this.Bpremier.Name = "Bpremier";
            this.Bpremier.Size = new System.Drawing.Size(23, 23);
            this.Bpremier.TabIndex = 9;
            this.Bpremier.Text = "|<";
            this.Bpremier.UseVisualStyleBackColor = true;
            this.Bpremier.Click += new System.EventHandler(this.Bpremier_Click);
            // 
            // Bprecedent
            // 
            this.Bprecedent.Location = new System.Drawing.Point(44, 180);
            this.Bprecedent.Name = "Bprecedent";
            this.Bprecedent.Size = new System.Drawing.Size(23, 23);
            this.Bprecedent.TabIndex = 10;
            this.Bprecedent.Text = "<";
            this.Bprecedent.UseVisualStyleBackColor = true;
            this.Bprecedent.Click += new System.EventHandler(this.Bprecedent_Click);
            // 
            // Bdernier
            // 
            this.Bdernier.Location = new System.Drawing.Point(224, 180);
            this.Bdernier.Name = "Bdernier";
            this.Bdernier.Size = new System.Drawing.Size(23, 23);
            this.Bdernier.TabIndex = 11;
            this.Bdernier.Text = ">|";
            this.Bdernier.UseVisualStyleBackColor = true;
            this.Bdernier.Click += new System.EventHandler(this.Bdernier_Click);
            // 
            // Bsuivant
            // 
            this.Bsuivant.Location = new System.Drawing.Point(195, 180);
            this.Bsuivant.Name = "Bsuivant";
            this.Bsuivant.Size = new System.Drawing.Size(23, 23);
            this.Bsuivant.TabIndex = 12;
            this.Bsuivant.Text = ">";
            this.Bsuivant.UseVisualStyleBackColor = true;
            this.Bsuivant.Click += new System.EventHandler(this.Bsuivant_Click);
            // 
            // LBposition
            // 
            this.LBposition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBposition.ForeColor = System.Drawing.Color.White;
            this.LBposition.Location = new System.Drawing.Point(73, 180);
            this.LBposition.Name = "LBposition";
            this.LBposition.Size = new System.Drawing.Size(116, 23);
            this.LBposition.TabIndex = 13;
            this.LBposition.Text = "0/0";
            this.LBposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bconfirmer
            // 
            this.Bconfirmer.Location = new System.Drawing.Point(15, 209);
            this.Bconfirmer.Name = "Bconfirmer";
            this.Bconfirmer.Size = new System.Drawing.Size(75, 23);
            this.Bconfirmer.TabIndex = 14;
            this.Bconfirmer.Text = "Confirmer";
            this.Bconfirmer.UseVisualStyleBackColor = true;
            this.Bconfirmer.Click += new System.EventHandler(this.Bconfirmer_Click);
            // 
            // Bannuler
            // 
            this.Bannuler.Location = new System.Drawing.Point(172, 209);
            this.Bannuler.Name = "Bannuler";
            this.Bannuler.Size = new System.Drawing.Size(75, 23);
            this.Bannuler.TabIndex = 15;
            this.Bannuler.Text = "Annuler";
            this.Bannuler.UseVisualStyleBackColor = true;
            this.Bannuler.Click += new System.EventHandler(this.Bannuler_Click);
            // 
            // Bediter
            // 
            this.Bediter.Location = new System.Drawing.Point(15, 238);
            this.Bediter.Name = "Bediter";
            this.Bediter.Size = new System.Drawing.Size(65, 23);
            this.Bediter.TabIndex = 16;
            this.Bediter.Text = "Editer";
            this.Bediter.UseVisualStyleBackColor = true;
            this.Bediter.Click += new System.EventHandler(this.Bediter_Click);
            // 
            // Bajouter
            // 
            this.Bajouter.Location = new System.Drawing.Point(98, 238);
            this.Bajouter.Name = "Bajouter";
            this.Bajouter.Size = new System.Drawing.Size(65, 23);
            this.Bajouter.TabIndex = 17;
            this.Bajouter.Text = "Ajouter";
            this.Bajouter.UseVisualStyleBackColor = true;
            this.Bajouter.Click += new System.EventHandler(this.Bajouter_Click);
            // 
            // Bsupprimer
            // 
            this.Bsupprimer.Location = new System.Drawing.Point(182, 238);
            this.Bsupprimer.Name = "Bsupprimer";
            this.Bsupprimer.Size = new System.Drawing.Size(65, 23);
            this.Bsupprimer.TabIndex = 18;
            this.Bsupprimer.Text = "Supprimer";
            this.Bsupprimer.UseVisualStyleBackColor = true;
            this.Bsupprimer.Click += new System.EventHandler(this.Bsupprimer_Click);
            // 
            // DGV_commande
            // 
            this.DGV_commande.AutoGenerateColumns = false;
            this.DGV_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_commande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMCOMDataGridViewTextBoxColumn,
            this.nUMCLIDataGridViewTextBoxColumn1,
            this.dATDataGridViewTextBoxColumn});
            this.DGV_commande.DataSource = this.commandeBindingSource;
            this.DGV_commande.Location = new System.Drawing.Point(271, 180);
            this.DGV_commande.Name = "DGV_commande";
            this.DGV_commande.ReadOnly = true;
            this.DGV_commande.RowHeadersVisible = false;
            this.DGV_commande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_commande.Size = new System.Drawing.Size(361, 258);
            this.DGV_commande.TabIndex = 19;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.persoDataSetBindingSource;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // nUMCOMDataGridViewTextBoxColumn
            // 
            this.nUMCOMDataGridViewTextBoxColumn.DataPropertyName = "NUMCOM";
            this.nUMCOMDataGridViewTextBoxColumn.HeaderText = "ID com";
            this.nUMCOMDataGridViewTextBoxColumn.Name = "nUMCOMDataGridViewTextBoxColumn";
            this.nUMCOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMCOMDataGridViewTextBoxColumn.Width = 50;
            // 
            // nUMCLIDataGridViewTextBoxColumn1
            // 
            this.nUMCLIDataGridViewTextBoxColumn1.DataPropertyName = "NUMCLI";
            this.nUMCLIDataGridViewTextBoxColumn1.HeaderText = "NUMCLI";
            this.nUMCLIDataGridViewTextBoxColumn1.Name = "nUMCLIDataGridViewTextBoxColumn1";
            this.nUMCLIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dATDataGridViewTextBoxColumn
            // 
            this.dATDataGridViewTextBoxColumn.DataPropertyName = "DAT";
            this.dATDataGridViewTextBoxColumn.HeaderText = "DAT";
            this.dATDataGridViewTextBoxColumn.Name = "dATDataGridViewTextBoxColumn";
            this.dATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EcranBDDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.DGV_commande);
            this.Controls.Add(this.Bsupprimer);
            this.Controls.Add(this.Bajouter);
            this.Controls.Add(this.Bediter);
            this.Controls.Add(this.Bannuler);
            this.Controls.Add(this.Bconfirmer);
            this.Controls.Add(this.LBposition);
            this.Controls.Add(this.Bsuivant);
            this.Controls.Add(this.Bdernier);
            this.Controls.Add(this.Bprecedent);
            this.Controls.Add(this.Bpremier);
            this.Controls.Add(this.DTPnaissance);
            this.Controls.Add(this.LBdate);
            this.Controls.Add(this.TBnom);
            this.Controls.Add(this.LBnom);
            this.Controls.Add(this.TBpre);
            this.Controls.Add(this.LBpre);
            this.Controls.Add(this.TBid);
            this.Controls.Add(this.LBid);
            this.Controls.Add(this.DGVclient);
            this.Name = "EcranBDDataset";
            this.Text = "FicBDDataset";
            this.Load += new System.EventHandler(this.EcranBDDataset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVclient;
        private System.Windows.Forms.BindingSource persoDataSetBindingSource;
        private persoDataSet persoDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private persoDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LBid;
        private System.Windows.Forms.TextBox TBid;
        private System.Windows.Forms.TextBox TBpre;
        private System.Windows.Forms.Label LBpre;
        private System.Windows.Forms.TextBox TBnom;
        private System.Windows.Forms.Label LBnom;
        private System.Windows.Forms.Label LBdate;
        private System.Windows.Forms.DateTimePicker DTPnaissance;
        private System.Windows.Forms.Button Bpremier;
        private System.Windows.Forms.Button Bprecedent;
        private System.Windows.Forms.Button Bdernier;
        private System.Windows.Forms.Button Bsuivant;
        private System.Windows.Forms.Label LBposition;
        private System.Windows.Forms.Button Bconfirmer;
        private System.Windows.Forms.Button Bannuler;
        private System.Windows.Forms.Button Bediter;
        private System.Windows.Forms.Button Bajouter;
        private System.Windows.Forms.Button Bsupprimer;
        private System.Windows.Forms.DataGridView DGV_commande;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private persoDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMCOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMCLIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATDataGridViewTextBoxColumn;
    }
}