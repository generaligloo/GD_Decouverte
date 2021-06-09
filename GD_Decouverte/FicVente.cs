using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace GD_Decouverte
{
    public partial class EcranVente : Form
    {
        private int nbTicket, nbVendeur, nbVendu;
        private int[,] ChargeVendeurs;
        List<int> lListe;
        private Mutex mListe;
        private StreamWriter sw;
        public EcranVente()
        {
            InitializeComponent();
        }

        private void B_simulation_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter("VerifVente.txt");
            lListe = new List<int>();
            Thread tAppel = new Thread(appel);
            Thread[] tVendeurs;
            int nSomme = 0;
            LB_console.Items.Clear();
            nbVendeur = TRB_nbVendeurs.Value;
            nbTicket = TRB_tickets.Value;
            nbVendu = 0;
            ChargeVendeurs = new int[nbVendeur, 2];
            tVendeurs = new Thread[nbVendeur];
            mListe = new Mutex();

            for(int i =0;i<nbVendeur;i++)
            {
                ParameterizedThreadStart pts = new ParameterizedThreadStart(vente);
                tVendeurs[i] = new Thread(pts);
                tVendeurs[i].Start(i);
            }
            tAppel.Start();
            for (int i = 0; i < nbVendeur; i++)
                tVendeurs[i].Join();
            for (int i = 0; i < nbVendeur; i++)
            {
                LB_console.Items.Add("Vendeur" + (1 + i).ToString() + " : " + ChargeVendeurs[i,0].ToString() + " ("+ ((double)ChargeVendeurs[i, 1]/ ChargeVendeurs[i, 0]).ToString("N2") +") ");
                nSomme += ChargeVendeurs[i, 0];
            }
            LB_console.Items.Add("Total : " + nSomme.ToString());
            sw.Close();
        }
        private void appel()
        {
            Random rAppel = new Random();
            while(true)
            {
                mListe.WaitOne();
                if (nbVendu == nbTicket)
                {
                    mListe.ReleaseMutex();
                    break;
                }
                nbVendu++;
                lListe.Add(nbVendu);
                sw.WriteLine("Appel : " + nbVendu.ToString());
                mListe.ReleaseMutex();
                System.Threading.Thread.Sleep(rAppel.Next(5, 20));
            }
        }
        private void vente(object i)
        {
            Random rTrai = new Random();
            int tTraitement = 0;
            while(true)
            {
                mListe.WaitOne();
                if(lListe.Count>0)
                {
                    tTraitement = rTrai.Next(60, 100);
                    ChargeVendeurs[(int)i, 0]++;
                    ChargeVendeurs[(int)i, 1]+= tTraitement;
                    lListe.RemoveAt(0);
                    sw.WriteLine("Vente : " + ((int)i).ToString());
                }
                else
                {
                    if(nbVendu==nbTicket)
                    {
                        mListe.ReleaseMutex();
                        break;
                    }
                    tTraitement = 1;
                }
                mListe.ReleaseMutex();
                Thread.Sleep(tTraitement);
            }
        }
    }
}
