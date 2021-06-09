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
    public partial class EcranIntegration : Form
    {
        static private double fctPoly(double x)
        { return x * x + 1; }
        static private double fcttrigo(double x)
        { return Math.Cos(x); }

        delegate double Fctaintegrer(double x);
        public EcranIntegration()
        {
            InitializeComponent();
        }
        private double integrationTra(Fctaintegrer f, double bg, double bd, int n)
        {
            double Aire = f(bg) + f(bd);
            double p = (bd - bg) / n;
            double x = bg + p;
            for (int j = 0; j < n - 1; j++)
            {
                Aire += 2 * f(x);
                x += p;
            }
            return Aire * p / 2;
        }

        private void B_poly_Click(object sender, EventArgs e)
        {
            double a, b;
            int nbint;
            if(double.TryParse(TB_gauche.Text, out a) && double.TryParse(TB_droite.Text, out b) && int.TryParse(TB_int.Text, out nbint))
            {
                LBO_resultat.Items.Clear();
                LBO_resultat.Items.Add("Méthode des trapèzes");
                LBO_resultat.Items.Add(" Polynôme : x² + 1");
                for (int i = 0; i < 5; i++)
                {
                    LBO_resultat.Items.Add(" Nb int : " + nbint.ToString() + " => " + integrationTra(fctPoly, a,b,nbint).ToString());
                    nbint *= 2;
                }
            }

        }

        private void B_trigono_Click(object sender, EventArgs e)
        {
            double a, b;
            int nbint;
            if (double.TryParse(TB_gauche.Text, out a) && double.TryParse(TB_droite.Text, out b) && int.TryParse(TB_int.Text, out nbint))
            {
                LBO_resultat.Items.Clear();
                LBO_resultat.Items.Add("Méthode des trapèzes");
                LBO_resultat.Items.Add("Trigonométrie : cos(x)");
                for (int i = 0; i < 5; i++)
                {
                    LBO_resultat.Items.Add(" Nb int : " + nbint.ToString() + " => " + integrationTra(fcttrigo, a, b, nbint).ToString());
                    nbint *= 2;
                }
            }
        }
    }
}
