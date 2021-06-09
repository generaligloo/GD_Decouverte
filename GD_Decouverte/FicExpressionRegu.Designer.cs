
namespace GD_Decouverte
{
    partial class EcranExpressionRegu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExpressionRegu));
            this.L_expressionregu = new System.Windows.Forms.Label();
            this.TB_er = new System.Windows.Forms.TextBox();
            this.ChB_isValide = new System.Windows.Forms.CheckBox();
            this.ChB_IsCorrespondance = new System.Windows.Forms.CheckBox();
            this.ChB_IsRespectCasse = new System.Windows.Forms.CheckBox();
            this.ChB_Remplacer = new System.Windows.Forms.CheckBox();
            this.ChB_Separer = new System.Windows.Forms.CheckBox();
            this.TB_Remplacement = new System.Windows.Forms.TextBox();
            this.LB_Remplacement = new System.Windows.Forms.Label();
            this.LB_Atraiter = new System.Windows.Forms.Label();
            this.RTB_Atraiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // L_expressionregu
            // 
            this.L_expressionregu.AutoSize = true;
            this.L_expressionregu.Location = new System.Drawing.Point(13, 13);
            this.L_expressionregu.Name = "L_expressionregu";
            this.L_expressionregu.Size = new System.Drawing.Size(101, 13);
            this.L_expressionregu.TabIndex = 0;
            this.L_expressionregu.Text = "Expression régulière";
            // 
            // TB_er
            // 
            this.TB_er.Location = new System.Drawing.Point(16, 30);
            this.TB_er.Name = "TB_er";
            this.TB_er.Size = new System.Drawing.Size(772, 20);
            this.TB_er.TabIndex = 1;
            this.TB_er.Text = "\\b[1-9][0-9]*\\b";
            this.TB_er.TextChanged += new System.EventHandler(this.TB_er_TextChanged);
            // 
            // ChB_isValide
            // 
            this.ChB_isValide.AutoSize = true;
            this.ChB_isValide.Enabled = false;
            this.ChB_isValide.Location = new System.Drawing.Point(16, 57);
            this.ChB_isValide.Name = "ChB_isValide";
            this.ChB_isValide.Size = new System.Drawing.Size(60, 17);
            this.ChB_isValide.TabIndex = 2;
            this.ChB_isValide.Text = "Validité";
            this.ChB_isValide.UseVisualStyleBackColor = true;
            // 
            // ChB_IsCorrespondance
            // 
            this.ChB_IsCorrespondance.AutoSize = true;
            this.ChB_IsCorrespondance.Enabled = false;
            this.ChB_IsCorrespondance.Location = new System.Drawing.Point(82, 57);
            this.ChB_IsCorrespondance.Name = "ChB_IsCorrespondance";
            this.ChB_IsCorrespondance.Size = new System.Drawing.Size(115, 17);
            this.ChB_IsCorrespondance.TabIndex = 3;
            this.ChB_IsCorrespondance.Text = "Correspondance(s)";
            this.ChB_IsCorrespondance.UseVisualStyleBackColor = true;
            // 
            // ChB_IsRespectCasse
            // 
            this.ChB_IsRespectCasse.AutoSize = true;
            this.ChB_IsRespectCasse.Location = new System.Drawing.Point(203, 56);
            this.ChB_IsRespectCasse.Name = "ChB_IsRespectCasse";
            this.ChB_IsRespectCasse.Size = new System.Drawing.Size(123, 17);
            this.ChB_IsRespectCasse.TabIndex = 4;
            this.ChB_IsRespectCasse.Text = "Respect de la casse";
            this.ChB_IsRespectCasse.UseVisualStyleBackColor = true;
            this.ChB_IsRespectCasse.CheckedChanged += new System.EventHandler(this.ChB_IsRespectCasse_CheckedChanged);
            // 
            // ChB_Remplacer
            // 
            this.ChB_Remplacer.AutoSize = true;
            this.ChB_Remplacer.Location = new System.Drawing.Point(332, 56);
            this.ChB_Remplacer.Name = "ChB_Remplacer";
            this.ChB_Remplacer.Size = new System.Drawing.Size(77, 17);
            this.ChB_Remplacer.TabIndex = 5;
            this.ChB_Remplacer.Text = "Remplacer";
            this.ChB_Remplacer.UseVisualStyleBackColor = true;
            this.ChB_Remplacer.CheckedChanged += new System.EventHandler(this.ChB_Remplacer_CheckedChanged);
            // 
            // ChB_Separer
            // 
            this.ChB_Separer.AutoSize = true;
            this.ChB_Separer.Location = new System.Drawing.Point(415, 56);
            this.ChB_Separer.Name = "ChB_Separer";
            this.ChB_Separer.Size = new System.Drawing.Size(63, 17);
            this.ChB_Separer.TabIndex = 6;
            this.ChB_Separer.Text = "Séparer";
            this.ChB_Separer.UseVisualStyleBackColor = true;
            this.ChB_Separer.CheckedChanged += new System.EventHandler(this.ChB_Separer_CheckedChanged);
            // 
            // TB_Remplacement
            // 
            this.TB_Remplacement.Location = new System.Drawing.Point(16, 96);
            this.TB_Remplacement.Name = "TB_Remplacement";
            this.TB_Remplacement.Size = new System.Drawing.Size(772, 20);
            this.TB_Remplacement.TabIndex = 8;
            // 
            // LB_Remplacement
            // 
            this.LB_Remplacement.AutoSize = true;
            this.LB_Remplacement.Location = new System.Drawing.Point(13, 79);
            this.LB_Remplacement.Name = "LB_Remplacement";
            this.LB_Remplacement.Size = new System.Drawing.Size(118, 13);
            this.LB_Remplacement.TabIndex = 7;
            this.LB_Remplacement.Text = "Texte de remplacement";
            // 
            // LB_Atraiter
            // 
            this.LB_Atraiter.AutoSize = true;
            this.LB_Atraiter.Location = new System.Drawing.Point(13, 119);
            this.LB_Atraiter.Name = "LB_Atraiter";
            this.LB_Atraiter.Size = new System.Drawing.Size(43, 13);
            this.LB_Atraiter.TabIndex = 9;
            this.LB_Atraiter.Text = "À traiter";
            // 
            // RTB_Atraiter
            // 
            this.RTB_Atraiter.Location = new System.Drawing.Point(16, 136);
            this.RTB_Atraiter.Name = "RTB_Atraiter";
            this.RTB_Atraiter.Size = new System.Drawing.Size(772, 302);
            this.RTB_Atraiter.TabIndex = 10;
            this.RTB_Atraiter.Text = resources.GetString("RTB_Atraiter.Text");
            this.RTB_Atraiter.Leave += new System.EventHandler(this.RTB_Atraiter_Leave);
            // 
            // EcranExpressionRegu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTB_Atraiter);
            this.Controls.Add(this.LB_Atraiter);
            this.Controls.Add(this.TB_Remplacement);
            this.Controls.Add(this.LB_Remplacement);
            this.Controls.Add(this.ChB_Separer);
            this.Controls.Add(this.ChB_Remplacer);
            this.Controls.Add(this.ChB_IsRespectCasse);
            this.Controls.Add(this.ChB_IsCorrespondance);
            this.Controls.Add(this.ChB_isValide);
            this.Controls.Add(this.TB_er);
            this.Controls.Add(this.L_expressionregu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranExpressionRegu";
            this.Text = "FicExpressionRegu";
            this.Load += new System.EventHandler(this.EcranExpressionRegu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_expressionregu;
        private System.Windows.Forms.TextBox TB_er;
        private System.Windows.Forms.CheckBox ChB_isValide;
        private System.Windows.Forms.CheckBox ChB_IsCorrespondance;
        private System.Windows.Forms.CheckBox ChB_IsRespectCasse;
        private System.Windows.Forms.CheckBox ChB_Remplacer;
        private System.Windows.Forms.CheckBox ChB_Separer;
        private System.Windows.Forms.TextBox TB_Remplacement;
        private System.Windows.Forms.Label LB_Remplacement;
        private System.Windows.Forms.Label LB_Atraiter;
        private System.Windows.Forms.RichTextBox RTB_Atraiter;
    }
}