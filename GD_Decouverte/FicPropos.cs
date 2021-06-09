using System;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranPropos : Form
    {
        public EcranPropos()
        {
            InitializeComponent();
        }

        private void BRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}