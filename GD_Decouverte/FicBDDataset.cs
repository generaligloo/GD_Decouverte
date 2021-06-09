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
    public partial class EcranBDDataset : Form
    {
        public EcranBDDataset()
        {
            InitializeComponent();
        }

        private void Activer(bool lPrincipal)
        {
            DGVclient.Enabled = lPrincipal;
            Bediter.Enabled = Bajouter.Enabled = Bsupprimer.Enabled = lPrincipal;
            Bconfirmer.Enabled = Bannuler.Enabled =!lPrincipal;
            Bprecedent.Enabled = Bpremier.Enabled = Bsuivant.Enabled = Bdernier.Enabled = lPrincipal;
            TBpre.Enabled = TBnom.Enabled = DTPnaissance.Enabled = !lPrincipal;
        }

        private void Valider()
        {
            MessageBox.Show(clientTableAdapter.Update(persoDataSet.Client)+ "Mise(s) à jour effectuée(s) !");
            if(int.Parse(TBid.Text) <0)
            {
                int iTmp = (int)clientTableAdapter.nouvelleD();
                TBid.Text = iTmp.ToString();
            }
        }

        private void EcranBDDataset_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'persoDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.commandeTableAdapter.Fill(this.persoDataSet.Commande);
            // TODO: cette ligne de code charge les données dans la table 'persoDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.persoDataSet.Client);
            Activer(true);
            clientBindingSource.MoveLast();
            clientBindingSource.MoveFirst();
        }

        private void Bpremier_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst();
        }

        private void Bprecedent_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void Bsuivant_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }

        private void Bdernier_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
        }

        private void Bconfirmer_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            if(persoDataSet.HasChanges())
            {
                Valider();
            }
            else
            {
                MessageBox.Show("pas de modification");
            }
            Activer(true);
        }

        private void Bannuler_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit();
            Activer(true);
        }

        private void Bediter_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void Bajouter_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            Activer(false);
        }

        private void Bsupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Supprimer "+ TBpre.Text + " " +TBnom.Text+"?", "Supprimer", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                Valider();
            }
        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Bpremier.Enabled = Bprecedent.Enabled = clientBindingSource.Position > 0;
            Bsuivant.Enabled = Bdernier.Enabled = clientBindingSource.Position < clientBindingSource.Count - 1;
            LBposition.Text = (1 + clientBindingSource.Position).ToString() + "/" + (clientBindingSource.Count.ToString());
            int nID;
            if(int.TryParse(TBid.Text, out nID))
                commandeBindingSource.Filter = "NUMCLI=" + nID.ToString();
        }
    }
}
