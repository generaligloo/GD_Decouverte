
namespace GD_Decouverte
{
    partial class EcranGPS
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
            this.CBportCOM = new System.Windows.Forms.ComboBox();
            this.Bconnecter = new System.Windows.Forms.Button();
            this.TBlongitude = new System.Windows.Forms.TextBox();
            this.TBlatitude = new System.Windows.Forms.TextBox();
            this.Blecture = new System.Windows.Forms.Button();
            this.Bafficher = new System.Windows.Forms.Button();
            this.SPgps = new System.IO.Ports.SerialPort(this.components);
            this.Tchrono = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CBportCOM
            // 
            this.CBportCOM.FormattingEnabled = true;
            this.CBportCOM.Items.AddRange(new object[] {
            "COM 1",
            "COM 2",
            "COM 3",
            "COM 4",
            "COM 5",
            "COM 6"});
            this.CBportCOM.Location = new System.Drawing.Point(12, 12);
            this.CBportCOM.Name = "CBportCOM";
            this.CBportCOM.Size = new System.Drawing.Size(236, 21);
            this.CBportCOM.TabIndex = 0;
            // 
            // Bconnecter
            // 
            this.Bconnecter.Location = new System.Drawing.Point(12, 39);
            this.Bconnecter.Name = "Bconnecter";
            this.Bconnecter.Size = new System.Drawing.Size(236, 37);
            this.Bconnecter.TabIndex = 1;
            this.Bconnecter.Text = "Connecter";
            this.Bconnecter.UseVisualStyleBackColor = true;
            this.Bconnecter.Click += new System.EventHandler(this.Bconnecter_Click);
            // 
            // TBlongitude
            // 
            this.TBlongitude.Location = new System.Drawing.Point(13, 83);
            this.TBlongitude.Name = "TBlongitude";
            this.TBlongitude.Size = new System.Drawing.Size(235, 20);
            this.TBlongitude.TabIndex = 2;
            // 
            // TBlatitude
            // 
            this.TBlatitude.Location = new System.Drawing.Point(13, 109);
            this.TBlatitude.Name = "TBlatitude";
            this.TBlatitude.Size = new System.Drawing.Size(235, 20);
            this.TBlatitude.TabIndex = 3;
            // 
            // Blecture
            // 
            this.Blecture.Location = new System.Drawing.Point(13, 135);
            this.Blecture.Name = "Blecture";
            this.Blecture.Size = new System.Drawing.Size(236, 37);
            this.Blecture.TabIndex = 4;
            this.Blecture.Text = "Débuter lecture";
            this.Blecture.UseVisualStyleBackColor = true;
            this.Blecture.Click += new System.EventHandler(this.Blecture_Click);
            // 
            // Bafficher
            // 
            this.Bafficher.Location = new System.Drawing.Point(12, 178);
            this.Bafficher.Name = "Bafficher";
            this.Bafficher.Size = new System.Drawing.Size(236, 37);
            this.Bafficher.TabIndex = 5;
            this.Bafficher.Text = "carte";
            this.Bafficher.UseVisualStyleBackColor = true;
            this.Bafficher.Click += new System.EventHandler(this.Bafficher_Click);
            // 
            // Tchrono
            // 
            this.Tchrono.Interval = 1000;
            this.Tchrono.Tick += new System.EventHandler(this.Tchrono_Tick);
            // 
            // EcranGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 225);
            this.Controls.Add(this.Bafficher);
            this.Controls.Add(this.Blecture);
            this.Controls.Add(this.TBlatitude);
            this.Controls.Add(this.TBlongitude);
            this.Controls.Add(this.Bconnecter);
            this.Controls.Add(this.CBportCOM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranGPS";
            this.Text = "LectureGPS";
            this.Load += new System.EventHandler(this.EcranGPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBportCOM;
        private System.Windows.Forms.Button Bconnecter;
        private System.Windows.Forms.TextBox TBlongitude;
        private System.Windows.Forms.TextBox TBlatitude;
        private System.Windows.Forms.Button Blecture;
        private System.Windows.Forms.Button Bafficher;
        private System.IO.Ports.SerialPort SPgps;
        private System.Windows.Forms.Timer Tchrono;
    }
}