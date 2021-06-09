
namespace GD_Decouverte
{
    partial class EcranProcessus
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
            this.LB_message = new System.Windows.Forms.ListBox();
            this.B_Processus1 = new System.Windows.Forms.Button();
            this.B_Processus2 = new System.Windows.Forms.Button();
            this.B_Processus3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_message
            // 
            this.LB_message.FormattingEnabled = true;
            this.LB_message.Location = new System.Drawing.Point(12, 12);
            this.LB_message.Name = "LB_message";
            this.LB_message.Size = new System.Drawing.Size(227, 121);
            this.LB_message.TabIndex = 0;
            // 
            // B_Processus1
            // 
            this.B_Processus1.Location = new System.Drawing.Point(12, 140);
            this.B_Processus1.Name = "B_Processus1";
            this.B_Processus1.Size = new System.Drawing.Size(227, 23);
            this.B_Processus1.TabIndex = 1;
            this.B_Processus1.Text = "Processus 1";
            this.B_Processus1.UseVisualStyleBackColor = true;
            this.B_Processus1.Click += new System.EventHandler(this.B_Processus1_Click);
            // 
            // B_Processus2
            // 
            this.B_Processus2.Location = new System.Drawing.Point(12, 169);
            this.B_Processus2.Name = "B_Processus2";
            this.B_Processus2.Size = new System.Drawing.Size(227, 23);
            this.B_Processus2.TabIndex = 2;
            this.B_Processus2.Text = "Processus 2";
            this.B_Processus2.UseVisualStyleBackColor = true;
            this.B_Processus2.Click += new System.EventHandler(this.B_Processus2_Click);
            // 
            // B_Processus3
            // 
            this.B_Processus3.Location = new System.Drawing.Point(12, 198);
            this.B_Processus3.Name = "B_Processus3";
            this.B_Processus3.Size = new System.Drawing.Size(227, 23);
            this.B_Processus3.TabIndex = 3;
            this.B_Processus3.Text = "Processus 3";
            this.B_Processus3.UseVisualStyleBackColor = true;
            this.B_Processus3.Click += new System.EventHandler(this.B_Processus3_Click);
            // 
            // EcranProcessus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 229);
            this.Controls.Add(this.B_Processus3);
            this.Controls.Add(this.B_Processus2);
            this.Controls.Add(this.B_Processus1);
            this.Controls.Add(this.LB_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranProcessus";
            this.Text = "Contrôle de processus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranProcessus_FormClosing);
            this.Load += new System.EventHandler(this.EcranProcessus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_message;
        private System.Windows.Forms.Button B_Processus1;
        private System.Windows.Forms.Button B_Processus2;
        private System.Windows.Forms.Button B_Processus3;
    }
}