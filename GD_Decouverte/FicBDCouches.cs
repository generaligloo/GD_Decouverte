using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ISET2018_CouClasses;
using ISET2018_CouGestion;

namespace GD_Decouverte
{
    public partial class EcranBDCouches : Form
    {
        //GD_Decouverte.Properties.Settings.BDConnectionString_Couches
        string sConnexion;
        private DataTable dtPersonne;
        private BindingSource bsPersonne;
        public EcranBDCouches()
        {
            InitializeComponent();
        }

        private void RemplirDGV()
        {
            dtPersonne = new DataTable();
            dtPersonne.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtPersonne.Columns.Add(new DataColumn("Afficher"));
            List<C_Personne> lTmp =  new G_Personne(sConnexion).Lire("Nom");
            foreach(C_Personne p in lTmp)
            {
                dtPersonne.Rows.Add(p.ID, p.PRE + " " + p.NOM);
            }
            bsPersonne = new BindingSource();
            bsPersonne.DataSource = dtPersonne;
            DGVpersonne.DataSource = bsPersonne;
        }
        private void Activer(bool Pr)
        {
            DGVpersonne.Enabled = Pr;
            Bajouter.Enabled = Bediter.Enabled = Bsupprimer.Enabled = Pr;
            TBpre.Enabled = TBnom.Enabled = DTPnai.Enabled = !Pr;
            Bconfirmer.Enabled = Bannuler.Enabled = !Pr;
        }
        private void EcranBDCouches_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["GD_Decouverte.Properties.Settings.BDConnectionString_Couches"].ConnectionString;
            RemplirDGV();
            if(DGVpersonne.Rows.Count>0)
            {
                Activer(true);
            }
            else
            {
                Activer(false);
            }
        }

        private void Bajouter_Click(object sender, EventArgs e)
        {
            TBid.Text = TBpre.Text = TBnom.Text = "";
            DTPnai.Value = DateTime.Today;
            Activer(false);
            TBpre.Focus();
        }

        private void Bediter_Click(object sender, EventArgs e)
        {
            if (DGVpersonne.SelectedRows.Count > 0)
            {
                TBid.Text = DGVpersonne.SelectedRows[0].Cells["cID"].Value.ToString();
                C_Personne pTmp = new G_Personne(sConnexion).Lire_ID(int.Parse(TBid.Text));
                TBpre.Text = pTmp.PRE;
                TBnom.Text = pTmp.NOM;
                DTPnai.Value = pTmp.NAI == null ? DateTime.Today : (DateTime)pTmp.NAI;
                Activer(false);
            }
            else
            {
                MessageBox.Show("choisis un truc là");
            }
        }

        private void Bsupprimer_Click(object sender, EventArgs e)
        {
            if (DGVpersonne.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                {
                    int iID = (int)DGVpersonne.SelectedRows[0].Cells["cID"].Value;
                    new G_Personne(sConnexion).Supprimer(iID);
                    bsPersonne.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("choisis un truc là");
            }
        }

        private void Bconfirmer_Click(object sender, EventArgs e)
        {
            if(TBnom.Text.Trim() == "")
            {
                MessageBox.Show("renseigner le nom !");
            }
            else
            {
                if(TBid.Text == "")
                {
                    int iID = new G_Personne(sConnexion).Ajouter(TBnom.Text, TBpre.Text, DTPnai.Value);
                    TBid.Text = iID.ToString();
                    dtPersonne.Rows.Add(iID, TBpre.Text + " " + TBnom.Text);
                }
                else
                {
                    new G_Personne(sConnexion).Modifier(int.Parse(TBid.Text), TBnom.Text, TBpre.Text, DTPnai.Value);
                    DGVpersonne.SelectedRows[0].Cells["cAffiche"].Value = TBpre.Text + " " + TBnom.Text;
                    bsPersonne.EndEdit();

                }
                Activer(true);
            }
        }

        private void Bannuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
    }
}
