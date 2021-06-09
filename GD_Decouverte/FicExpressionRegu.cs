using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GD_Decouverte
{
    public partial class EcranExpressionRegu : Form
    {
        private bool Validite(string sExpReg)
        {
            try
            {
                Regex tmp = new Regex(sExpReg);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        private bool Correspondance(string sExpReg, string sAverifier, RegexOptions roParam)
        {
            if(Validite(sExpReg))
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.IsMatch(sAverifier);
            }
            return false;
        }
        private MatchCollection Correspondances(string sExpReg, string sAverifier, RegexOptions roParam)
        {
            if (Validite(sExpReg))
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.Matches(sAverifier);
            }
            return null;
        }
        private void MettreEnEvidence(MatchCollection mc, RichTextBox rtb)
        {
            rtb.Select(0, rtb.Text.Length);
            rtb.SelectionBackColor = Color.Transparent;
            foreach (Match m in mc)
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionBackColor = Color.Orange;
            }
        }
        private string Remplacer(string sExpReg, string sAVerifier, RegexOptions roParam, string sRemplacement)
        {
            if (Validite(sExpReg))
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.Replace(sAVerifier, sRemplacement);
            }
            return "Problème : Exp incorrect ! ";
        }
        public string[] Separer(string sExpReg, string sATraiter, RegexOptions roParametres)
        {
            if (Validite(sExpReg))
            {
                Regex exp = new Regex(sExpReg, roParametres);
                return exp.Split(sATraiter);
            }
            return new string[] { "Problème : Exp incorrect ! " };
        }
        public EcranExpressionRegu()
        {
            InitializeComponent();
        }

        private void TB_er_TextChanged(object sender, EventArgs e)
        {
            if (ChB_isValide.Checked = Validite(TB_er.Text))
            {
                ChB_IsCorrespondance.Checked = Correspondance(TB_er.Text, RTB_Atraiter.Text, ChB_IsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                MettreEnEvidence(Correspondances(TB_er.Text, RTB_Atraiter.Text, ChB_IsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), RTB_Atraiter);
            }
        }

        private void RTB_Atraiter_Leave(object sender, EventArgs e)
        {
            ChB_IsCorrespondance.Checked = Correspondance(TB_er.Text, RTB_Atraiter.Text, ChB_IsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(Correspondances(TB_er.Text, RTB_Atraiter.Text, ChB_IsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), RTB_Atraiter);
        }

        private void EcranExpressionRegu_Load(object sender, EventArgs e)
        {
            TB_er_TextChanged(null, null);
        }

        private void ChB_IsRespectCasse_CheckedChanged(object sender, EventArgs e)
        {
            RTB_Atraiter_Leave(null, null);
        }

        private void ChB_Remplacer_CheckedChanged(object sender, EventArgs e)
        {
            if(Validite(TB_er.Text) && ChB_Remplacer.Checked)
            {
                MessageBox.Show(Remplacer(TB_er.Text, RTB_Atraiter.Text, ChB_IsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase, TB_Remplacement.Text));
            }
            ChB_Remplacer.Checked = false;
        }

        private void ChB_Separer_CheckedChanged(object sender, EventArgs e)
        {
            if (Validite(TB_er.Text) && ChB_Separer.Checked)
            {
                string[] aTmp = Separer(TB_er.Text, RTB_Atraiter.Text, ChB_IsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                foreach (string s in aTmp)
                    MessageBox.Show(s);
            }
            ChB_Separer.Checked = false;
        }
    }
}
