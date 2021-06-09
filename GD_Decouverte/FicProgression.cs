using System;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranProgression : Form
    {
        private bool antistop = false;

        public EcranProgression()
        {
            InitializeComponent();
        }

        private void BQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bcopie_Click(object sender, EventArgs e)
        {
            int nbFich, pas, i, j;
            antistop = true;
            Random ran = new Random();
            Cursor basecursor = Cursor;
            Cursor = Cursors.WaitCursor;
            Bcopie.Enabled = BQuitter.Enabled = false;
            nbFich = ran.Next(5, 16); //16 exclu !!!!!!!!!!!!
            PBPrimaire.Maximum = nbFich;
            PBPrimaire.Value = 0;
            for (i = 0; i < nbFich; i++)
            {
                PBSecondaire.Value = 0;
                pas = 5 + 5 * ran.Next(10);
                for (j = 0; j < 20; j++)
                {
                    if (j <= 19)
                    {
                        PBSecondaire.Value = 1 + (1 + j) * 5;
                        PBSecondaire.Value = (1 + j) * 5;
                    }
                    else
                    {
                        PBSecondaire.Value = PBSecondaire.Maximum;
                    }
                    System.Threading.Thread.Sleep(pas);
                }
                PBPrimaire.Value++;
            }
            Bcopie.Enabled = BQuitter.Enabled = true;
            Cursor = basecursor;
            antistop = false;
        }

        private void EcranProgression_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (antistop == true)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void EcranProgression_Load(object sender, EventArgs e)
        {

        }
    }
}