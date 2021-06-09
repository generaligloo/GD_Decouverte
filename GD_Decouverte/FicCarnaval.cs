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
    public partial class EcranCarnaval : Form
    {
        public EcranCarnaval()
        {
            InitializeComponent();
        }
        private void DefinirFenetre()
        {
            GraphicsPath gp = new GraphicsPath();
            Point[] pts = new Point[]
            {
                new Point(5,5),
                new Point(5, Size.Height - 5),
                new Point(Size.Width / 4, 4 * Size.Height / 5),
                new Point(Size.Width / 2, Size.Height - 5),
                new Point(3 * Size.Width / 4, 4 * Size.Height / 5),
                new Point(Size.Width - 5, Size.Height - 5),
                new Point(Size.Width - 5, 5),
            };
            gp.AddClosedCurve(pts);
            Region = new Region(gp);
        }
        private void DefinirBTexte()
        {
            GraphicsPath gp = new GraphicsPath();
            StringFormat sf = new StringFormat(StringFormat.GenericDefault);
            sf.Alignment = StringAlignment.Center;
            gp.AddString("! cliquons !", new FontFamily("Arial Black"), (int)FontStyle.Bold, 24, new Point(bTexte.Width / 2, 0), sf);
            bTexte.Region = new Region(gp);
        }
        private void DefinirBGeometrique()
        {
            int w = bGeometrique.Width;
            int h = bGeometrique.Height;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(0, 0, w / 2, h));
            gp.AddEllipse(w / 4, h / 2, w / 6, h / 3);
            gp.AddEllipse(new Rectangle(w/2, 0, w / 2, h));
            gp.AddEllipse(3 * w / 4 - w / 6, h / 2, w / 6, h / 3);
            bGeometrique.Region = new Region(gp);
        }
        private void bGeometrique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clic sur le bouton géométrique");
        }

        private void bTexte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clic sur le bouton texte");
        }

        private void EcranCarnaval_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void EcranCarnaval_Paint(object sender, PaintEventArgs e)
        {
            DefinirFenetre();
            bTexte.Size = new Size(ClientSize.Width - 24, ClientSize.Height);
            DefinirBTexte();
            bGeometrique.Size = new Size(ClientSize.Width - 24, ClientSize.Height / 4);
            DefinirBGeometrique();
        }
    }
}
