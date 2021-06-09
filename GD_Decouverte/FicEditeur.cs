using System;
using System.Drawing;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranEditeur : Form
    {
        private bool modif;
        private string nFichier;

        public EcranEditeur()
        {
            InitializeComponent();
        }

        private void EcranEditeur_Load(object sender, EventArgs e)
        {
            modif = false;
            nFichier = "";
        }

        private void FichierEnregistrer()
        {
            if (nFichier == "")
            {
                if (dEnregistrer.ShowDialog() == DialogResult.OK)
                    nFichier = dEnregistrer.FileName;
            }
            if (nFichier != "")
            {
                rtbEditeur.SaveFile(nFichier);
                modif = false;
            }
        }

        private void VerifierEnregistrement()
        {
            if (modif)
            {
                if (MessageBox.Show("Enregistrer la modification ?", "Texte modifié", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    FichierEnregistrer();
            }
        }

        private void mcFichierNouveau_Click(object sender, EventArgs e)
        {
            VerifierEnregistrement();
            rtbEditeur.Clear();
            nFichier = "";
            modif = false;
            rtbEditeur.Focus();
        }

        private void mcFichierOuvrir_Click(object sender, EventArgs e)
        {
            VerifierEnregistrement();
            if (dOuvrir.ShowDialog() == DialogResult.OK)
            {
                nFichier = dOuvrir.FileName;
                rtbEditeur.LoadFile(nFichier);
                modif = false;
            }
        }

        private void mcFichierEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void mcFichierQuitter_Click(object sender, EventArgs e)
        {
            VerifierEnregistrement();
            Close();
        }

        private void rtbEditeur_TextChanged(object sender, EventArgs e)
        {
            modif = true;
        }

        private void mcEditerCopier_Click(object sender, EventArgs e)
        {
            rtbEditeur.Copy();
        }

        private void mcEditerCouper_Click(object sender, EventArgs e)
        {
            rtbEditeur.Cut();
        }

        private void mcEditerColler_Click(object sender, EventArgs e)
        {
            rtbEditeur.Paste();
        }

        private void mcJustifierGauche_Click(object sender, EventArgs e)
        {
            rtbEditeur.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mcJustifierDroite_Click(object sender, EventArgs e)
        {
            rtbEditeur.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mcjustifierCentre_Click(object sender, EventArgs e)
        {
            rtbEditeur.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mcFormaterPolice_Click(object sender, EventArgs e)
        {
            if (dPolice.ShowDialog() == DialogResult.OK)
                rtbEditeur.SelectionFont = new Font(dPolice.Font, dPolice.Font.Style);
        }

        private void mcCaractèreGras_Click(object sender, EventArgs e)
        {
            Font PoliceActuelle = rtbEditeur.SelectionFont;
            FontStyle NouveauStyle;
            NouveauStyle = PoliceActuelle.Style ^ FontStyle.Bold;
            rtbEditeur.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouveauStyle);
        }

        private void mcCaractèreItalique_Click(object sender, EventArgs e)
        {
            Font PoliceActuelle = rtbEditeur.SelectionFont;
            FontStyle NouveauStyle;
            NouveauStyle = PoliceActuelle.Style ^ FontStyle.Italic;
            rtbEditeur.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouveauStyle);
        }

        private void mcCaractèreSouligné_Click(object sender, EventArgs e)
        {
            Font PoliceActuelle = rtbEditeur.SelectionFont;
            FontStyle NouveauStyle;
            NouveauStyle = PoliceActuelle.Style ^ FontStyle.Underline;
            rtbEditeur.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouveauStyle);
        }

        private void mcCaractèreBarré_Click(object sender, EventArgs e)
        {
            Font PoliceActuelle = rtbEditeur.SelectionFont;
            FontStyle NouveauStyle;
            NouveauStyle = PoliceActuelle.Style ^ FontStyle.Strikeout;
            rtbEditeur.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouveauStyle);
        }
    }
}