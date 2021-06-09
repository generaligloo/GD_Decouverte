using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranListe : Form
    {
        private string sFichier;

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int lbLire = 0x0199;
        private const int lbEcrire = 0x019A;
        private int sl = -1;

        public EcranListe()
        {
            InitializeComponent();
        }

        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
            sFichier = "";
        }

        private void Activer(bool lPricipale)
        {
            lbPersonne.Enabled = lPricipale;
            bOuvrir.Enabled = bEnregrister.Enabled = bAjouter.Enabled = bSupprimer.Enabled = bModifier.Enabled = lPricipale;
            gbDetail.Enabled = !lPricipale;
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                char[] deli1 = { '[', ']' };
                sFichier = ofdOuvrir.FileName;
                lbPersonne.Items.Clear();
                StreamReader sr = new StreamReader(sFichier);
                string sLecture;
                while ((sLecture = sr.ReadLine()) != null)
                {
                    var lecsplit = sLecture.Split(deli1);
                    int lec = lbPersonne.Items.Add(lecsplit[0]);
                    SendMessage(lbPersonne.Handle, lbEcrire, lec, int.Parse(lecsplit[1]));
                }
                sr.Close();
                lFichier.Text = sFichier.Substring(1 + sFichier.LastIndexOf("\\"));
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Supprimez " + lbPersonne.Text + " ?", "Confimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int data;
                    int datasupp = SendMessage(lbPersonne.Handle, lbLire, lbPersonne.SelectedIndex, 0);
                    for (int i = 0; i < lbPersonne.Items.Count; i++)
                    {
                        data = SendMessage(lbPersonne.Handle, lbLire, i, 0); ;

                        if (data > datasupp)
                        {
                            data--;
                            SendMessage(lbPersonne.Handle, lbEcrire, i, data);
                        }
                    }
                    lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);
                }
            }
            else
                MessageBox.Show("Sélectionner une personne à supprimer");
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                char[] deli = { '(', ')' };
                string index = lbPersonne.GetItemText(lbPersonne.SelectedItem);
                string[] words = index.Split(deli);
                tbNom.Text = words[0];
                string quali = words[1];
                cbQualité.Text = quali;
                //int i=0;
                //while (i <= cbQualité.Items.Count)
                //{
                //    if (quali.Equals(cbQualité.GetItemText(i)))
                //    {
                //        cbQualité.Text = words[1];
                //        break;
                //    }
                //    i++;
                //}
                sl = lbPersonne.SelectedIndex;
                Activer(false);
            }
            else
                MessageBox.Show("Sélectionner une personne à modifier");
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            cbQualité.SelectedIndex = -1;
            tbNom.Text = "";
        }

        private void bEnregrister_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                sFichier = sfdEnregistrer.FileName;
                StreamWriter sw = new StreamWriter(sFichier);
                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    int sec = SendMessage(lbPersonne.Handle, lbLire, i, 0);
                    sw.WriteLine(lbPersonne.Items[i].ToString() + "[" + sec + "]");
                }
                sw.Close();
                lFichier.Text = sFichier.Substring(sFichier.LastIndexOf("\\"));
            }
        }

        #region Groupbox

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (sl != -1)
            {
                if (tbNom.Text == "")
                {
                    MessageBox.Show("Renseigner un nom");
                }
                else if (cbQualité.SelectedIndex == -1)
                {
                    MessageBox.Show("Renseigner la qualité");
                }
                else
                {
                    int n = SendMessage(lbPersonne.Handle, lbLire, sl, 0);
                    lbPersonne.Items.RemoveAt(sl);
                    int nPos = sl;
                    lbPersonne.Items.Add(tbNom.Text + " (" + cbQualité.Text + ")");
                    SendMessage(lbPersonne.Handle, lbEcrire, nPos, n);
                    Activer(true);
                    sl = -1;
                }
            }
            else
            {
                if (tbNom.Text == "")
                {
                    MessageBox.Show("Renseigner un nom");
                }
                else if (cbQualité.SelectedIndex == -1)
                {
                    MessageBox.Show("Renseigner la qualité");
                }
                else
                {
                    int nPos = lbPersonne.Items.Add(tbNom.Text + " (" + cbQualité.Text + ")");
                    SendMessage(lbPersonne.Handle, lbEcrire, nPos, lbPersonne.Items.Count);
                    Activer(true);
                }
            }
        }

        #endregion Groupbox

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            int nPos = SendMessage(lbPersonne.Handle, lbLire, lbPersonne.SelectedIndex, 0);
            MessageBox.Show(lbPersonne.Text + " en position:" + lbPersonne.SelectedIndex.ToString() + " (tri)" + nPos.ToString() + " (Encodage)");
        }
    }
}