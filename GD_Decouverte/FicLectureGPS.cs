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
    public partial class EcranGPS : Form
    {
        public EcranGPS()
        {
            InitializeComponent();
        }

        private void Bconnecter_Click(object sender, EventArgs e)
        {
            if(CBportCOM.SelectedIndex >= 0)
                try 
                {
                    if(SPgps.IsOpen)
                    {
                        Tchrono.Stop();
                        SPgps.Close();
                    }
                    SPgps.PortName = CBportCOM.Text;
                    SPgps.Open();
                    Tchrono.Start();
                    Blecture.Text = "Arrêter lecture";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problème : " + ex.Message);
                }
        }

        private void Blecture_Click(object sender, EventArgs e)
        {
            Tchrono.Enabled = !Tchrono.Enabled;
            if(Tchrono.Enabled)
            {
                Blecture.Text = "Arrêter lecture";
            } else
            {
                Blecture.Text = "Débuter lecture";
            }
        }

        private void Bafficher_Click(object sender, EventArgs e)
        {
            if (TBlatitude.Text == "" || TBlongitude.Text == "")
            {
                MessageBox.Show("Pas de bras pas de nutella ... zut c'est pas ça!");

            }
            else
            {
                EcranCarte fcarte = new EcranCarte(TBlatitude.Text, TBlongitude.Text);
                fcarte.ShowDialog();
            }
        }

        private void Tchrono_Tick(object sender, EventArgs e)
        {
            if(SPgps.IsOpen)
            {
                string sData = SPgps.ReadExisting();
                string[] sTrames = sData.Split('$');
                for(int i = 0; i<sTrames.Length;i++)
                {
                    string[] sContenu = sTrames[i].Split(',');
                    if(sContenu[0] == "GPGGA" && sContenu.Length== 15)
                    {
                        double lat = double.Parse(sContenu[2].Replace('.', ',')); //lat: 4807,038
                        lat /= 100; //48 deg 07.038
                        TBlatitude.Text = sContenu[3] + ((int)lat).ToString(); // N48
                        lat -= (int)lat; // 0,07038
                        lat = lat * 100 / 60; //0,1173
                        TBlatitude.Text += lat.ToString().Substring(1).Replace(',', '.'); //text = N48.1173
                        double lon = double.Parse(sContenu[4].Replace('.', ',')); //lon: 01131,324
                        lon /= 100; //11 deg 31.324
                        TBlongitude.Text = sContenu[5] + ((int)lon).ToString();
                        lon -= (int)lon;
                        lon = lon * 100 / 60;
                        TBlongitude.Text += lon.ToString().Substring(1).Replace(',', '.');
                    }
                }
                    /* 123519 = Acquisition du FIX à 12:35:19 UTC
                        4807.038,N = Latitude 48 deg 07.038' N
                        01131.324,E = Longitude 11 deg 31.324' E
                        1 = Fix qualification : (0 = non valide, 1 = Fix GPS, 2 = Fix DGPS)
                        08 = Nombre de satellites en poursuite.
                        0.9 = DOP (Horizontal dilution of position) Dilution horizontale.
                        545.4,M = Altitude, en Mètres, au dessus du MSL (mean see level) niveau moyen des Océans.
                        46.9,M = Correction de la hauteur de la géoïde en Mètres par rapport à l'ellipsoïde WGS84 (MSL).
                        (Champ vide) = nombre de secondes écoulées depuis la dernière mise à jour DGPS.
                        (Champ vide) = Identification de la station DGPS.
                        *42 = Checksum
                     */
            }
        }

        private void EcranGPS_Load(object sender, EventArgs e)
        {

        }
    }
}
