using System;
using System.Windows.Forms;

namespace GD_Decouverte
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void MImplementation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("en construction");
        }

        private void MCQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAIPropos_Click(object sender, EventArgs e)
        {
            this.Hide();
            EcranPropos fPropos = new EcranPropos();
            fPropos.ShowDialog();
            this.Show();
        }

        private void MCProgression_Click(object sender, EventArgs e)
        {
            EcranProgression fProg = new EcranProgression();
            fProg.ShowDialog();
        }

        private void MCListe_Click(object sender, EventArgs e)
        {
            EcranListe flist = new EcranListe();
            flist.ShowDialog();
        }

        private void MAEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur fedit = new EcranEditeur();
            fedit.ShowDialog();
        }

        private void maSpirographe_Click(object sender, EventArgs e)
        {
            EcranSpirographe fspyro = new EcranSpirographe();
            fspyro.ShowDialog();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranHorloge fhorlo = new EcranHorloge();
            fhorlo.ShowDialog();
        }

        private void MAhisto_Click(object sender, EventArgs e)
        {
            EcranHisto fhisto = new EcranHisto();
            fhisto.ShowDialog();
        }

        private void MACarnaval_Click(object sender, EventArgs e)
        {
            EcranCarnaval fcarna = new EcranCarnaval();
            fcarna.ShowDialog();
        }

        private void MAClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris fcla = new EcranClavierSouris();
            fcla.ShowDialog();
        }

        private void MAedf_Click(object sender, EventArgs e)
        {
            EcranExplorateur fedf = new EcranExplorateur();
            fedf.ShowDialog();
        }

        private void MAgps_Click(object sender, EventArgs e)
        {
            EcranGPS fgps = new EcranGPS();
            fgps.ShowDialog();
        }

        private void MAbddirect_Click(object sender, EventArgs e)
        {
            EcranBDD fbdd = new EcranBDD();
            fbdd.ShowDialog();
        }

        private void MAbddataset_Click(object sender, EventArgs e)
        {
            EcranBDDataset fdts = new EcranBDDataset();
            fdts.ShowDialog();
        }

        private void MABDCouches_Click(object sender, EventArgs e)
        {
            EcranBDCouches fbdc = new EcranBDCouches();
            fbdc.ShowDialog();
        }

        private void MAexpressionregu_Click(object sender, EventArgs e)
        {
            EcranExpressionRegu feer = new EcranExpressionRegu();
            feer.ShowDialog();
        }

        private void MAintégration_Click(object sender, EventArgs e)
        {
            EcranIntegration fid = new EcranIntegration();
            fid.ShowDialog();
        }

        private void MA_Processus_Click(object sender, EventArgs e)
        {
            EcranProcessus fproc = new EcranProcessus();
            fproc.ShowDialog();
        }

        private void MA_philo_Click(object sender, EventArgs e)
        {
            EcranPhilo fphilo = new EcranPhilo();
            fphilo.ShowDialog();
        }

        private void MA_vente_Click(object sender, EventArgs e)
        {
            EcranVente fVente = new EcranVente();
            fVente.ShowDialog();
        }

        private void MA_Sérialisation_Click(object sender, EventArgs e)
        {
            EcranSerial fserial = new EcranSerial();
            fserial.ShowDialog();
        }

        private void EcranPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}