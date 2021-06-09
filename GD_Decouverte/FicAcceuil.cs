using System;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranAcceuil : Form
    {
        private bool button1 = false;

        public EcranAcceuil()
        {
            InitializeComponent();
        }

        private void BPermuter_Click(object sender, EventArgs e)
        {
            if (button1 == false)
            {
                MessageBox.Show("Le videur devient fou ! ", "Attention");
                Pimage.Image = GD_Decouverte.Properties.Resources.EsMM5qLXIAAiuUV;
                //Picturebox.Image = lien vers la ressource;
                button1 = true;
            }
            else
            {
                MessageBox.Show("Le videur se calme ! ", "Pfiou");
                Pimage.Image = GD_Decouverte.Properties.Resources.Eq_9MX_XEAQDhii;
                //Picturebox.Image = lien vers la ressource;
                button1 = false;
            }
        }

        private void EcranAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Souhaitez vous réellement partir ?", "Je suis triste là ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BEntrée_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show("le videur te laisse passer ", "Tu es chanceux");
            EcranPrincipal fprinc = new EcranPrincipal();
            fprinc.ShowDialog();
            this.Show();
        }

        private void EcranAcceuil_Load(object sender, EventArgs e)
        {

        }
    }
}