
namespace GD_Decouverte
{
    partial class EcranSerial
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
            this.B_classePrepa = new System.Windows.Forms.Button();
            this.B_hardSerial = new System.Windows.Forms.Button();
            this.B_rapidSerial = new System.Windows.Forms.Button();
            this.B_univerSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_classePrepa
            // 
            this.B_classePrepa.Location = new System.Drawing.Point(12, 12);
            this.B_classePrepa.Name = "B_classePrepa";
            this.B_classePrepa.Size = new System.Drawing.Size(232, 43);
            this.B_classePrepa.TabIndex = 0;
            this.B_classePrepa.Text = "Sérialisé classe préparée";
            this.B_classePrepa.UseVisualStyleBackColor = true;
            this.B_classePrepa.Click += new System.EventHandler(this.B_classePrepa_Click);
            // 
            // B_hardSerial
            // 
            this.B_hardSerial.Location = new System.Drawing.Point(12, 61);
            this.B_hardSerial.Name = "B_hardSerial";
            this.B_hardSerial.Size = new System.Drawing.Size(232, 43);
            this.B_hardSerial.TabIndex = 1;
            this.B_hardSerial.Text = "Sérialisé \"à la dur\" Hard Serial";
            this.B_hardSerial.UseVisualStyleBackColor = true;
            this.B_hardSerial.Click += new System.EventHandler(this.B_hardSerial_Click);
            // 
            // B_rapidSerial
            // 
            this.B_rapidSerial.Location = new System.Drawing.Point(12, 110);
            this.B_rapidSerial.Name = "B_rapidSerial";
            this.B_rapidSerial.Size = new System.Drawing.Size(232, 43);
            this.B_rapidSerial.TabIndex = 2;
            this.B_rapidSerial.Text = "Sérialisé à la volée";
            this.B_rapidSerial.UseVisualStyleBackColor = true;
            this.B_rapidSerial.Click += new System.EventHandler(this.B_rapidSerial_Click);
            // 
            // B_univerSerial
            // 
            this.B_univerSerial.Location = new System.Drawing.Point(12, 159);
            this.B_univerSerial.Name = "B_univerSerial";
            this.B_univerSerial.Size = new System.Drawing.Size(232, 43);
            this.B_univerSerial.TabIndex = 3;
            this.B_univerSerial.Text = "Sérialisation universelle";
            this.B_univerSerial.UseVisualStyleBackColor = true;
            this.B_univerSerial.Click += new System.EventHandler(this.B_univerSerial_Click);
            // 
            // EcranSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 213);
            this.Controls.Add(this.B_univerSerial);
            this.Controls.Add(this.B_rapidSerial);
            this.Controls.Add(this.B_hardSerial);
            this.Controls.Add(this.B_classePrepa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranSerial";
            this.Text = "Sérialisation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_classePrepa;
        private System.Windows.Forms.Button B_hardSerial;
        private System.Windows.Forms.Button B_rapidSerial;
        private System.Windows.Forms.Button B_univerSerial;
    }
}