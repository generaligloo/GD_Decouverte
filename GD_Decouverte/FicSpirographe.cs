using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace GD_Decouverte
{
    public partial class EcranSpirographe : Form
    {
        private Color cTrait, cFond;
        private GraphicsPath gpSauveDessin;
        public EcranSpirographe()
        {
            InitializeComponent();
            cTrait = Color.Cyan;
            cFond = Color.DarkBlue;
        }
        private double dist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        private void bTrait_Click(object sender, EventArgs e)
        {
            dCouleur.Color = cTrait;
            if(dCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = dCouleur.Color;
                Invalidate(false);
            }
        }

        private void bExecuter_Click(object sender, EventArgs e)
        {
            int i;
            int nSom = tbSommet.Value;
            int nDens = tbDensite.Value;
            int nProf = 100 - tbProfondeur.Value;
            gpSauveDessin = new GraphicsPath();
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(cFond), new Rectangle(new Point(2 + gbParametres.Width, 0), ClientSize));
            int xc = 2 + gbParametres.Width + (ClientSize.Width - 2 - gbParametres.Width) / 2;
            int yc = ClientSize.Height / 2;
            int Rayon = 9 * Math.Min(ClientSize.Width - 2 - gbParametres.Width, ClientSize.Height) /20;
            int[] SX = new int[1 + nSom];
            int[] SY = new int[1 + nSom];
            for (i=0;i<nSom;i++)
            {
                SX[i] = (int)(xc + Rayon * Math.Cos(i * 2 * Math.PI / nSom));
                SY[i] = (int)(yc + Rayon * Math.Sin(i * 2 * Math.PI / nSom));
            }   
            SX[nSom] = SX[0];
            SY[nSom] = SY[0];
            int x1, y1, x2, y2;
            while (dist(SX[0], SY[0], xc, yc) > Rayon * nProf / 100) 
            {
                x1 = SX[0]; 
                y1 = SY[0];
                for(i=1;i<=nSom;i++)
                {
                    x2 = SX[i]; 
                    y2 = SY[i];
                    gr.DrawLine(new Pen(cTrait), x1, y1, x2, y2);
                    gpSauveDessin.AddLine(x1, y1, x2, y2);
                    x1 = x2; y1 = y2;
                    Application.DoEvents();
                    Thread.Sleep(15);
                }
                for (i = 0; i < nSom; i++)
                {
                    SX[i] = SX[i] + (SX[1 + i] - SX[i]) / nDens;
                    SY[i] = SY[i] + (SY[1 + i] - SY[i]) / nDens;
                }
                SX[nSom] = SX[0]; 
                SY[nSom] = SY[0];
            }
        }

        private void bFond_Click(object sender, EventArgs e)
        {
            dCouleur.Color = cFond;
            if (dCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = dCouleur.Color;
                Invalidate(false);
            }
        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (gpSauveDessin != null)
            {
                Rectangle R = new Rectangle(new Point(2 + gbParametres.Width, 0), ClientSize);
                e.Graphics.FillRectangle(new SolidBrush(cFond), R);
                e.Graphics.DrawPath(new Pen(cTrait), gpSauveDessin);
            }
        }

        private void EcranSpirographe_Load(object sender, EventArgs e)
        {

        }
    }
}
