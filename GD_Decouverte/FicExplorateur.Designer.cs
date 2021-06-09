
namespace GD_Decouverte
{
    partial class EcranExplorateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            this.TScommandes = new System.Windows.Forms.ToolStrip();
            this.TSBquitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.SBpetit = new System.Windows.Forms.ToolStripMenuItem();
            this.SBgrand = new System.Windows.Forms.ToolStripMenuItem();
            this.SBliste = new System.Windows.Forms.ToolStripMenuItem();
            this.SBdetail = new System.Windows.Forms.ToolStripMenuItem();
            this.SSmessage = new System.Windows.Forms.StatusStrip();
            this.TSSLmessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.SCdiv = new System.Windows.Forms.SplitContainer();
            this.TVrepertoire = new System.Windows.Forms.TreeView();
            this.ILrepertoire = new System.Windows.Forms.ImageList(this.components);
            this.LVfichier = new System.Windows.Forms.ListView();
            this.Cnom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ctaille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ccrea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cmod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ILgrand = new System.Windows.Forms.ImageList(this.components);
            this.ILpetit = new System.Windows.Forms.ImageList(this.components);
            this.TScommandes.SuspendLayout();
            this.SSmessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCdiv)).BeginInit();
            this.SCdiv.Panel1.SuspendLayout();
            this.SCdiv.Panel2.SuspendLayout();
            this.SCdiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // TScommandes
            // 
            this.TScommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBquitter,
            this.toolStripSplitButton1});
            this.TScommandes.Location = new System.Drawing.Point(0, 0);
            this.TScommandes.Name = "TScommandes";
            this.TScommandes.Size = new System.Drawing.Size(800, 25);
            this.TScommandes.TabIndex = 0;
            this.TScommandes.Text = "toolStrip1";
            // 
            // TSBquitter
            // 
            this.TSBquitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBquitter.Image = global::GD_Decouverte.Properties.Resources.Hopstarter_Rounded_Square_Button_Delete;
            this.TSBquitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBquitter.Name = "TSBquitter";
            this.TSBquitter.Size = new System.Drawing.Size(23, 22);
            this.TSBquitter.Click += new System.EventHandler(this.TSBquitter_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SBpetit,
            this.SBgrand,
            this.SBliste,
            this.SBdetail});
            this.toolStripSplitButton1.Image = global::GD_Decouverte.Properties.Resources._017_bullets;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            // 
            // SBpetit
            // 
            this.SBpetit.Name = "SBpetit";
            this.SBpetit.Size = new System.Drawing.Size(154, 22);
            this.SBpetit.Text = "Petites icônes";
            this.SBpetit.Click += new System.EventHandler(this.SBpetit_Click);
            // 
            // SBgrand
            // 
            this.SBgrand.Name = "SBgrand";
            this.SBgrand.Size = new System.Drawing.Size(154, 22);
            this.SBgrand.Text = "Grandes icônes";
            this.SBgrand.Click += new System.EventHandler(this.SBgrand_Click);
            // 
            // SBliste
            // 
            this.SBliste.Name = "SBliste";
            this.SBliste.Size = new System.Drawing.Size(154, 22);
            this.SBliste.Text = "Liste";
            this.SBliste.Click += new System.EventHandler(this.SBliste_Click);
            // 
            // SBdetail
            // 
            this.SBdetail.Name = "SBdetail";
            this.SBdetail.Size = new System.Drawing.Size(154, 22);
            this.SBdetail.Text = "Détail";
            this.SBdetail.Click += new System.EventHandler(this.SBdetail_Click);
            // 
            // SSmessage
            // 
            this.SSmessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLmessage});
            this.SSmessage.Location = new System.Drawing.Point(0, 428);
            this.SSmessage.Name = "SSmessage";
            this.SSmessage.Size = new System.Drawing.Size(800, 22);
            this.SSmessage.TabIndex = 1;
            this.SSmessage.Text = "statusStrip1";
            // 
            // TSSLmessage
            // 
            this.TSSLmessage.Name = "TSSLmessage";
            this.TSSLmessage.Size = new System.Drawing.Size(118, 17);
            this.TSSLmessage.Text = "toolStripStatusLabel1";
            // 
            // SCdiv
            // 
            this.SCdiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCdiv.Location = new System.Drawing.Point(0, 25);
            this.SCdiv.Name = "SCdiv";
            // 
            // SCdiv.Panel1
            // 
            this.SCdiv.Panel1.Controls.Add(this.TVrepertoire);
            this.SCdiv.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // SCdiv.Panel2
            // 
            this.SCdiv.Panel2.Controls.Add(this.LVfichier);
            this.SCdiv.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.SCdiv.Size = new System.Drawing.Size(800, 403);
            this.SCdiv.SplitterDistance = 266;
            this.SCdiv.TabIndex = 2;
            // 
            // TVrepertoire
            // 
            this.TVrepertoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVrepertoire.ImageIndex = 0;
            this.TVrepertoire.ImageList = this.ILrepertoire;
            this.TVrepertoire.Location = new System.Drawing.Point(0, 0);
            this.TVrepertoire.Name = "TVrepertoire";
            this.TVrepertoire.SelectedImageIndex = 0;
            this.TVrepertoire.Size = new System.Drawing.Size(266, 403);
            this.TVrepertoire.TabIndex = 0;
            this.TVrepertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVrepertoire_AfterSelect);
            // 
            // ILrepertoire
            // 
            this.ILrepertoire.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILrepertoire.ImageStream")));
            this.ILrepertoire.TransparentColor = System.Drawing.Color.Transparent;
            this.ILrepertoire.Images.SetKeyName(0, "WEOrdi.bmp");
            this.ILrepertoire.Images.SetKeyName(1, "WEFloppy.bmp");
            this.ILrepertoire.Images.SetKeyName(2, "WERepertoire.bmp");
            this.ILrepertoire.Images.SetKeyName(3, "WERepertoireActif.bmp");
            this.ILrepertoire.Images.SetKeyName(4, "WEPoubelle.bmp");
            // 
            // LVfichier
            // 
            this.LVfichier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cnom,
            this.Ctaille,
            this.Ccrea,
            this.Cmod});
            this.LVfichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVfichier.FullRowSelect = true;
            this.LVfichier.HideSelection = false;
            this.LVfichier.LargeImageList = this.ILgrand;
            this.LVfichier.Location = new System.Drawing.Point(0, 0);
            this.LVfichier.Name = "LVfichier";
            this.LVfichier.Size = new System.Drawing.Size(530, 403);
            this.LVfichier.SmallImageList = this.ILpetit;
            this.LVfichier.TabIndex = 0;
            this.LVfichier.UseCompatibleStateImageBehavior = false;
            this.LVfichier.View = System.Windows.Forms.View.Details;
            // 
            // Cnom
            // 
            this.Cnom.Text = "Nom";
            this.Cnom.Width = 300;
            // 
            // Ctaille
            // 
            this.Ctaille.Text = "Taille";
            this.Ctaille.Width = 75;
            // 
            // Ccrea
            // 
            this.Ccrea.Text = "Création";
            this.Ccrea.Width = 75;
            // 
            // Cmod
            // 
            this.Cmod.Text = "Modification";
            this.Cmod.Width = 75;
            // 
            // ILgrand
            // 
            this.ILgrand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILgrand.ImageStream")));
            this.ILgrand.TransparentColor = System.Drawing.Color.Transparent;
            this.ILgrand.Images.SetKeyName(0, "WELVGrandeIcone.bmp");
            // 
            // ILpetit
            // 
            this.ILpetit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILpetit.ImageStream")));
            this.ILpetit.TransparentColor = System.Drawing.Color.Transparent;
            this.ILpetit.Images.SetKeyName(0, "WELVPetiteIcone.bmp");
            // 
            // EcranExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SCdiv);
            this.Controls.Add(this.SSmessage);
            this.Controls.Add(this.TScommandes);
            this.Name = "EcranExplorateur";
            this.Text = "FicExplorateur";
            this.Load += new System.EventHandler(this.EcranExplorateur_Load);
            this.TScommandes.ResumeLayout(false);
            this.TScommandes.PerformLayout();
            this.SSmessage.ResumeLayout(false);
            this.SSmessage.PerformLayout();
            this.SCdiv.Panel1.ResumeLayout(false);
            this.SCdiv.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCdiv)).EndInit();
            this.SCdiv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TScommandes;
        private System.Windows.Forms.StatusStrip SSmessage;
        private System.Windows.Forms.SplitContainer SCdiv;
        private System.Windows.Forms.TreeView TVrepertoire;
        private System.Windows.Forms.ListView LVfichier;
        private System.Windows.Forms.ImageList ILrepertoire;
        private System.Windows.Forms.ImageList ILpetit;
        private System.Windows.Forms.ImageList ILgrand;
        private System.Windows.Forms.ToolStripButton TSBquitter;
        private System.Windows.Forms.ToolStripStatusLabel TSSLmessage;
        private System.Windows.Forms.ColumnHeader Cnom;
        private System.Windows.Forms.ColumnHeader Ctaille;
        private System.Windows.Forms.ColumnHeader Ccrea;
        private System.Windows.Forms.ColumnHeader Cmod;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem SBpetit;
        private System.Windows.Forms.ToolStripMenuItem SBgrand;
        private System.Windows.Forms.ToolStripMenuItem SBliste;
        private System.Windows.Forms.ToolStripMenuItem SBdetail;
    }
}