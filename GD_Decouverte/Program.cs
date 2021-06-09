using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace GD_Decouverte
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!EstActif())
            {
                Application.Run(new EcranAcceuil());
            }
            else
                MessageBox.Show("Instance déjà ouverte");
        }
        public static bool EstActif()
        {
            Process pActu = Process.GetCurrentProcess();
            Process[] pActi = Process.GetProcesses();
            foreach (Process p in pActi)
                if (pActu.Id != p.Id)
                    if (p.ProcessName == pActu.ProcessName)
                        return true;
            return false;
        }
    }
}