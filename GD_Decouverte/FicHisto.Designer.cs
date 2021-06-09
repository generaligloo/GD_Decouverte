
namespace GD_Decouverte
{
    partial class EcranHisto
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
            this.graph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(13, 331);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(75, 23);
            this.graph.TabIndex = 1;
            this.graph.Text = "Graphique";
            this.graph.UseVisualStyleBackColor = true;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // EcranHisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranHisto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FicHisto";
            this.Load += new System.EventHandler(this.FicHisto_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranHisto_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button graph;
    }
}