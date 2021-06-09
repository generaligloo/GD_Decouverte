using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GD_Decouverte
{
    public partial class EcranExplorateur : Form
    {
        private TreeNode tnRacine;
        public EcranExplorateur()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string NomFichier(string nfComplet)
        {
            return nfComplet.Substring(1 + nfComplet.LastIndexOf("\\"));
        }

        private void TSBquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SBpetit_Click(object sender, EventArgs e)
        {
            LVfichier.View = View.SmallIcon;
        }

        private void SBgrand_Click(object sender, EventArgs e)
        {
            LVfichier.View = View.LargeIcon;
        }

        private void SBliste_Click(object sender, EventArgs e)
        {
            LVfichier.View = View.List;
        }

        private void SBdetail_Click(object sender, EventArgs e)
        {
            LVfichier.View = View.Details;
        }

        private void EcranExplorateur_Load(object sender, EventArgs e)
        {
            LireDisques();
        }
        private void LireDisques()
        {
            Cursor cursor = Cursor;
            Cursor = Cursors.WaitCursor;
            TSSLmessage.Text = "Rafraîchissement de l'affichage";
            tnRacine = new TreeNode("Ordinateur", 0, 0);
            TVrepertoire.Nodes.Clear();
            TVrepertoire.Nodes.Add(tnRacine);
            string[] Disques = Environment.GetLogicalDrives();
            foreach(string Disque in Disques)
            {
                TreeNode tmpDisque = new TreeNode(Disque, 1, 1);
                tnRacine.Nodes.Add(tmpDisque);
                LireRepertoire(Disque, tmpDisque.Nodes);
            }
            TSSLmessage.Text = "";
            Cursor = cursor;
        }
        private void LireRepertoire(string nd, TreeNodeCollection tnc)
        {
            if(Directory.Exists(nd))
            {
                try
                {
                    string[] Repertoires = Directory.GetDirectories(nd);
                    string s1 = "", s2 = "";
                    foreach(string Repertoire in Repertoires)
                    {
                        s1 = NomFichier(Repertoire);
                        s2 = s1.ToUpper();
                        TreeNode tnCourant;
                        if (s2 == "RECYCLED" || s2 == "RECYCLER" || s2 == "$RECYCLE.BIN")
                            tnCourant = new TreeNode(s1, 4, 4);
                        else
                            tnCourant = new TreeNode(s1, 2, 3);
                        tnc.Add(tnCourant);
                        //LireRepertoire(Repertoire, tnCourant.Nodes);
                    }
                    
                }
                catch { }
            }
        }

        private void LireFichier(string sRep)
        {
            Cursor cursor = Cursor;
            Cursor = Cursors.WaitCursor;
            TSSLmessage.Text = "Lecture de "+ sRep;
            LVfichier.Items.Clear();
            try
            {
                string[] Fichiers = Directory.GetFiles(sRep);
                string[] Col = new string[4];
                foreach(string Fichier in Fichiers)
                {
                    if(Fichier.ToUpper() != "PAGEFILE.SYS")
                    {
                        FileInfo fific = new FileInfo(Fichier);
                        long taFic = fific.Length;
                        Col[0] = NomFichier(Fichier);
                        if (taFic > 1024 * 1024 * 1024)
                            Col[1] = (taFic / (1024 * 1024 * 1024)).ToString() + " gb";
                        else if (taFic > 1024 * 1024)
                            Col[1] = (taFic / (1024 * 1024)).ToString() + " mb";
                        else if (taFic > 1024)
                            Col[1] = (taFic / (1024)).ToString() + " kb";
                        else
                            Col[1] = taFic.ToString() + " b";
                        Col[2] = fific.CreationTime.ToString("dd/MM/yyyy");
                        Col[3] = fific.LastWriteTime.ToString("dd/MM/yyyy");
                        LVfichier.Items.Add(new ListViewItem(Col, 0));
                    }
                }
            }
            catch(IOException faute)
            {
                MessageBox.Show("Erreur d'accès à " + sRep + " (" + faute.Message + ")");
            }
            TSSLmessage.Text = "";
            Cursor = cursor;
        }

        private void TVrepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node == tnRacine)
            {
                string[] sTmp = { "Ordinateur", "", "", "" };
                LVfichier.Items.Add(new ListViewItem(sTmp, 0));
            }
            else
            {
                string sRep = e.Node.FullPath;
                sRep = sRep.Remove(0, 1 + sRep.IndexOf(@"\"));
                try
                {
                    LVfichier.Items.Clear();
                    if(!Directory.Exists(sRep))
                    {
                        string[] sTmp = { "Non opérationnel", "", "", "" };
                        LVfichier.Items.Add(new ListViewItem(sTmp, 0));
                    }
                    else
                    {
                        LireFichier(sRep);
                    }
                }
                catch(IOException faute)
                {
                    MessageBox.Show("Erreur d'accès de " + sRep + " ("+ faute.Message +")");
                    TVrepertoire.Focus();
                }
            }
        }
    }
}
