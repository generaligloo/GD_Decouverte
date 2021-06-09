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
    public partial class EcranHisto : Form
    {
        List<maison> Point_L = new List<maison>();
        private GraphicsPath GP_histo = null;
        private Color Trait;
        public EcranHisto()
        {
            InitializeComponent();
            Trait = Color.Red;
        }
        private void FicHisto_Load(object sender, EventArgs e)
        {
            Point_L.Clear();
            Point_L = Gen();
        }
        private List<maison> Gen()
        {
            List<maison> ListPoints = new List<maison>();
            Random Ran = new Random();
            int x = 0, y;
            int Max = Ran.Next(10, 26);
            for (int i = 0; i < Max; i++)
            {
                x = x + Ran.Next(5, 21);
                y = Ran.Next(-101, 101);
                ListPoints.Add(new maison(x, y));
            }

            return ListPoints;
        }
        private void histo(List<maison> Point_L)
        {
            int X_ecart = ClientRectangle.Width / Point_L[Point_L.Count - 1].x;
            int Y_ecart = ClientRectangle.Height / 200;

            GP_histo = new GraphicsPath();
            
            Rectangle R = new Rectangle(ClientRectangle.Location, ClientRectangle.Size);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Color.White), R);
            int X_gauche = ClientRectangle.Location.X;
            int Y_centre = ClientRectangle.Height/2;
            gr.DrawLine(new Pen(Trait), new Point(Point_L[0].x * X_ecart + X_gauche, Y_centre), new Point(Point_L[Point_L.Count - 1].x * X_ecart + X_gauche, Y_centre));

            for (int i = 1; i < Point_L.Count; i++)
            {
                gr.DrawLine(new Pen(Color.Black), new Point(Point_L[i - 1].x * X_ecart + X_gauche, Point_L[i - 1].y * Y_ecart + (Y_centre)), new Point(Point_L[i].x * X_ecart + X_gauche, Point_L[i - 1].y * Y_ecart + (Y_centre))); // _
                gr.DrawLine(new Pen(Color.Black), new Point(Point_L[i].x * X_ecart + X_gauche, Point_L[i - 1].y * Y_ecart + (Y_centre)), new Point(Point_L[i].x * X_ecart + X_gauche, Point_L[i].y * Y_ecart + (Y_centre))); // |
            }
        }
        private void EcranHisto_Paint(object sender, PaintEventArgs e)
        {
            if(GP_histo !=null)
            {
                Rectangle R = new Rectangle(ClientRectangle.Location, ClientRectangle.Size);
                e.Graphics.FillRectangle(new SolidBrush(Color.White), R);
                e.Graphics.DrawPath(new Pen(Trait), GP_histo);
            }
        }
        private void graph_Click(object sender, EventArgs e)
        {
            Point_L.Clear();
            Point_L = Gen();
            histo(Point_L);
        }
    }
}
