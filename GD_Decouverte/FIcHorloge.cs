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

namespace GD_Decouverte
{
    public partial class EcranHorloge : Form
    {
        public EcranHorloge()
        {
            InitializeComponent();
        }

        private void Chrono_Tick(object sender, EventArgs e)
        {
            Invalidate();
            DateTime dtn = DateTime.Now;
            Text = dtn.Hour.ToString() + ":" + dtn.Minute.ToString() + ":" + dtn.Second.ToString();
        }

        private void FIcHorloge_Load(object sender, EventArgs e)
        {
            DateTime dtn = DateTime.Now;
            Text = dtn.Hour.ToString() + ":" + dtn.Minute.ToString() + ":" + dtn.Second.ToString();
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            int xc = ClientRectangle.Width / 2; //centre client
            int yc= ClientRectangle.Height / 2; 
            int ax = 3 * xc / 5;            //décalage horloge-centre
            int ay = 3 * yc / 5;
            int xs, ys, xm, ym, xh, yh, x, y;
            for (int i = 0; i < 12; i++)
            {
                x = xc + (int)(ax * Math.Cos(i * Math.PI / 6)); //Math/Pi = demi horloge = 6 heures donc 1h = math.pi/6
                y = yc + (int)(ay * Math.Sin(i * Math.PI / 6));  //debut cos(0) sin(0) donc (0,1) => droite de l'horloge
                if (i % 3 == 0)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.DarkCyan), x, y, 10, 10); //si l'heure est divisible par 3 gros point
                }
                else
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.DarkBlue), x, y, 5, 5); //sinon petit point
                }
            }
            DateTime dt = DateTime.Now;
            int sec = dt.Second;
            int min = dt.Minute;
            int hour = dt.Hour;     //récupère l'heure de mtn
            xs = xc + (int)(0.9 * ax * Math.Cos(sec * Math.PI / 30 - Math.PI / 2)); //position bout de l'aiguille seconde x et y
            ys = yc + (int)(0.9 * ay * Math.Sin(sec * Math.PI / 30 - Math.PI / 2)); //on fait seconde* 2*PI/60 (- pi / 2 parce que l'aiguille a un décalage de pi/2)
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 1), xc, yc, xs, ys); //dessin entre centre point calculé
            
            xm = xc + (int)(0.8 * ax * Math.Cos(min * Math.PI / 30 + sec * Math.PI / 1800 - Math.PI / 2)); // 2*PI/3600 nombre parcouru tout les secondes par l'aiguille des minutes
            ym = yc + (int)(0.8 * ay * Math.Sin(min * Math.PI / 30 + sec * Math.PI / 1800 - Math.PI / 2));
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 2), xc, yc, xm, ym);

            xh = xc + (int)(0.7 * ax * Math.Cos(hour * Math.PI / 6 + min * Math.PI / 360 - Math.PI / 2)); // 2*PI/720 nombre parcouru tout les minutes par l'aiguille des heures
            yh = yc + (int)(0.7 * ay * Math.Sin(hour * Math.PI / 6 + min * Math.PI / 360 - Math.PI / 2));
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 9), xc, yc, xh, yh);
        }
    }
}
