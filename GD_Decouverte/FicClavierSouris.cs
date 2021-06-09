using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranClavierSouris : Form
    {
        private int nGauche, nDroit;
        private int ligneMax = 6;
        private int colonneMax = 6;
        public EcranClavierSouris()
        {
            InitializeComponent();
        }

        private void EcranClavierSouris_Load(object sender, EventArgs e)
        {
            nGauche = nDroit = 0;
            TBClicGauche.Text = TBClicDroit.Text = TBAbscisse.Text = TBOrdonné.Text = "0";
        }

        private void PaZoneSouris_MouseMove(object sender, MouseEventArgs e)
        {
            TBAbscisse.Text = e.X.ToString();
            TBOrdonné.Text = e.Y.ToString();
        }

        private void PaZoneSouris_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    TBClicGauche.Text =(++nGauche).ToString();
                    int HauteurPA = PaZoneSouris.Height;
                    int HauteurCase = HauteurPA / ligneMax;
                    int LongueurPA = PaZoneSouris.Width;
                    int LongueurCase = LongueurPA / colonneMax;
                    int caseH = (e.X+1) / LongueurCase;
                    int caseV = (e.Y+1) / HauteurCase;
                    LB_listeclavier.Items.Insert(0, "Case: " + caseV.ToString() + " - " + caseH.ToString());
                    break;
                case MouseButtons.Right:
                    TBClicDroit.Text = (++nDroit).ToString();
                    break;
                case MouseButtons.Middle:
                    MessageBox.Show("MILIEU");
                    break;
            }
        }

        private void bRAZ_Click(object sender, EventArgs e)
        {
            LB_listeclavier.Items.Clear();
            EcranClavierSouris_Load(null, null);
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            LB_listeclavier.Items.Insert(0, "Enfoncé : code=" + e.KeyCode + ", Valeur=" + e.KeyValue);
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            LB_listeclavier.Items.Insert(0, "Pressé : " + e.KeyChar);
        }

        private void PaZoneSouris_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = PaZoneSouris.CreateGraphics();
            Pen Noir = new Pen(Color.Black);
            int tileHeight = PaZoneSouris.Height / ligneMax;
            int tileWidth = PaZoneSouris.Width / colonneMax;
            for (int ligne = 0; ligne < ligneMax; ligne++)
            {
                int lignePosition = ligne * tileHeight;
                gr.DrawLine(Noir, 0, lignePosition, colonneMax * tileWidth, lignePosition);
            }
            for (int colonne = 0; colonne < colonneMax; colonne++)
            {
                int colonnePosition = colonne * tileWidth;
                gr.DrawLine(Noir, colonnePosition, 0, colonnePosition, ligneMax * tileHeight);
            }
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            LB_listeclavier.Items.Insert(0, "Relaché : code=" + e.KeyCode + ", Valeur=" + e.KeyValue);
        }
    }
}
