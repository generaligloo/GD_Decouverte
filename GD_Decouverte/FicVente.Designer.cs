
namespace GD_Decouverte
{
    partial class EcranVente
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
            this.TRB_nbVendeurs = new System.Windows.Forms.TrackBar();
            this.LAB_NBvendeurs = new System.Windows.Forms.Label();
            this.LAB_nbTicket = new System.Windows.Forms.Label();
            this.TRB_tickets = new System.Windows.Forms.TrackBar();
            this.B_simulation = new System.Windows.Forms.Button();
            this.LB_console = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_nbVendeurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // TRB_nbVendeurs
            // 
            this.TRB_nbVendeurs.Location = new System.Drawing.Point(12, 25);
            this.TRB_nbVendeurs.Minimum = 2;
            this.TRB_nbVendeurs.Name = "TRB_nbVendeurs";
            this.TRB_nbVendeurs.Size = new System.Drawing.Size(274, 45);
            this.TRB_nbVendeurs.TabIndex = 0;
            this.TRB_nbVendeurs.Value = 4;
            // 
            // LAB_NBvendeurs
            // 
            this.LAB_NBvendeurs.AutoSize = true;
            this.LAB_NBvendeurs.Location = new System.Drawing.Point(12, 6);
            this.LAB_NBvendeurs.Name = "LAB_NBvendeurs";
            this.LAB_NBvendeurs.Size = new System.Drawing.Size(111, 13);
            this.LAB_NBvendeurs.TabIndex = 1;
            this.LAB_NBvendeurs.Text = "Nombres de vendeurs";
            // 
            // LAB_nbTicket
            // 
            this.LAB_nbTicket.AutoSize = true;
            this.LAB_nbTicket.Location = new System.Drawing.Point(12, 67);
            this.LAB_nbTicket.Name = "LAB_nbTicket";
            this.LAB_nbTicket.Size = new System.Drawing.Size(98, 13);
            this.LAB_nbTicket.TabIndex = 3;
            this.LAB_nbTicket.Text = "Nombres de tickets";
            // 
            // TRB_tickets
            // 
            this.TRB_tickets.Location = new System.Drawing.Point(12, 86);
            this.TRB_tickets.Maximum = 1000;
            this.TRB_tickets.Minimum = 2;
            this.TRB_tickets.Name = "TRB_tickets";
            this.TRB_tickets.Size = new System.Drawing.Size(274, 45);
            this.TRB_tickets.TabIndex = 2;
            this.TRB_tickets.TickFrequency = 100;
            this.TRB_tickets.Value = 300;
            // 
            // B_simulation
            // 
            this.B_simulation.Location = new System.Drawing.Point(12, 138);
            this.B_simulation.Name = "B_simulation";
            this.B_simulation.Size = new System.Drawing.Size(274, 52);
            this.B_simulation.TabIndex = 4;
            this.B_simulation.Text = "Simulation";
            this.B_simulation.UseVisualStyleBackColor = true;
            this.B_simulation.Click += new System.EventHandler(this.B_simulation_Click);
            // 
            // LB_console
            // 
            this.LB_console.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_console.FormattingEnabled = true;
            this.LB_console.ItemHeight = 18;
            this.LB_console.Location = new System.Drawing.Point(12, 196);
            this.LB_console.Name = "LB_console";
            this.LB_console.Size = new System.Drawing.Size(274, 184);
            this.LB_console.TabIndex = 5;
            // 
            // EcranVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 407);
            this.Controls.Add(this.LB_console);
            this.Controls.Add(this.B_simulation);
            this.Controls.Add(this.LAB_nbTicket);
            this.Controls.Add(this.TRB_tickets);
            this.Controls.Add(this.LAB_NBvendeurs);
            this.Controls.Add(this.TRB_nbVendeurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranVente";
            this.Text = "FicVente";
            ((System.ComponentModel.ISupportInitialize)(this.TRB_nbVendeurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TRB_nbVendeurs;
        private System.Windows.Forms.Label LAB_NBvendeurs;
        private System.Windows.Forms.Label LAB_nbTicket;
        private System.Windows.Forms.TrackBar TRB_tickets;
        private System.Windows.Forms.Button B_simulation;
        private System.Windows.Forms.ListBox LB_console;
    }
}