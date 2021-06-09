using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GD_Decouverte
{
    public partial class EcranProcessus : Form
    {
        private Process pProcessus = null;
        public EcranProcessus()
        {
            InitializeComponent();
        }

        private void B_Processus1_Click(object sender, EventArgs e)
        {
            LB_message.Items.Insert(0, "-------------------");
            LB_message.Items.Insert(0, "Chargement du bloc-note");
            Process.Start("notepad");
            LB_message.Items.Insert(0, "bloc-note chargé");
        }

        private void B_Processus2_Click(object sender, EventArgs e)
        {
            if(pProcessus == null || pProcessus.HasExited)
            {
                LB_message.Items.Insert(0, "-------------------");
                LB_message.Items.Insert(0, "Chargement avancé du bloc-note");
                pProcessus = new Process();
                pProcessus.StartInfo.FileName = "notepad";
                pProcessus.EnableRaisingEvents = true;
                pProcessus.Exited += new EventHandler(SortieProcessus);
                pProcessus.Start();
                LB_message.Items.Insert(0, "bloc-note chargé");
                pProcessus.WaitForExit(); 
            }
        }

        private void B_Processus3_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Users\gdocq\source\repos\processus\bin\Debug\processus.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            LB_message.Items.Insert(0, "-------------------");
            try
            {
                LB_message.Items.Insert(0, "chargement du programme : " + p.StartInfo.FileName);
                p.Start();
                LB_message.Items.Insert(0, "exécution du programme : " + p.StartInfo.FileName);
                LB_message.Items.Insert(0, p.StandardOutput.ReadToEnd());
              
            } 
            catch
            {
                LB_message.Items.Insert(0, "problème d'exécution du programme : " + p.StartInfo.FileName);
            }
        }

        private void EcranProcessus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(pProcessus != null && !pProcessus.HasExited)
            {
                pProcessus.Kill();
                pProcessus.WaitForExit();
            }
        }
        private void SortieProcessus( object sender, EventArgs e)
        {
            LB_message.Items.Insert(0, "Durée:" + (pProcessus.ExitTime - pProcessus.StartTime));
            LB_message.Items.Insert(0, "Fin:" + pProcessus.ExitTime);
            LB_message.Items.Insert(0, "Début" + pProcessus.StartTime);
        }

        private void EcranProcessus_Load(object sender, EventArgs e)
        {

        }
    }
}
