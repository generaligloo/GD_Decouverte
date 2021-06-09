
namespace GD_Decouverte
{
    partial class EcranCarte
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
            this.WBcarte = new System.Windows.Forms.WebBrowser();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.CWBcarte = new CefSharp.WinForms.ChromiumWebBrowser();
            this.SuspendLayout();
            // 
            // WBcarte
            // 
            this.WBcarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBcarte.Location = new System.Drawing.Point(0, 0);
            this.WBcarte.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBcarte.Name = "WBcarte";
            this.WBcarte.Size = new System.Drawing.Size(800, 450);
            this.WBcarte.TabIndex = 0;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(800, 450);
            this.chromiumWebBrowser1.TabIndex = 1;
            // 
            // CWBcarte
            // 
            this.CWBcarte.ActivateBrowserOnCreation = false;
            this.CWBcarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CWBcarte.Location = new System.Drawing.Point(0, 0);
            this.CWBcarte.Name = "CWBcarte";
            this.CWBcarte.Size = new System.Drawing.Size(800, 450);
            this.CWBcarte.TabIndex = 2;
            // 
            // EcranCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CWBcarte);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.WBcarte);
            this.Name = "EcranCarte";
            this.Text = "Carte";
            this.Load += new System.EventHandler(this.EcranCarte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBcarte;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private CefSharp.WinForms.ChromiumWebBrowser CWBcarte;
    }
}