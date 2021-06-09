using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GD_Decouverte
{
    public partial class EcranBDD : Form
    {
        string sChConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\gdocq\Downloads\perso.mdb";
        public EcranBDD()
        {
            InitializeComponent();
            Binsérer.Enabled = false;
            Bdenombrer.Enabled = false;
        }

        private void Bconsulter_Click(object sender, EventArgs e)
        {
            OleDbConnection oConn = new OleDbConnection(sChConn);
            oConn.Open();
            Binsérer.Enabled = true;
            Bdenombrer.Enabled = true;
            OleDbCommand oComm = new OleDbCommand("SELECT PRE, NOM FROM Client ORDER BY NOM", oConn);
            OleDbDataReader dr = oComm.ExecuteReader();
            while(dr.Read())
            {
                LBconsole.Items.Add(dr[0].ToString() + " " + dr["NOM"]);
            }
            dr.Close();
            oConn.Close();
        }

        private void Bdenombrer_Click(object sender, EventArgs e)
        {
            OleDbConnection oConn = new OleDbConnection(sChConn);
            oConn.Open();
            OleDbCommand oComm = new OleDbCommand("SELECT COUNT(NUMCLI) FROM Client", oConn);
            int nb = (int)oComm.ExecuteScalar();
            LBconsole.Items.Add("Nombre d'enregistrement : " + nb.ToString());
            oConn.Close();
        }

        private void Binsérer_Click(object sender, EventArgs e)
        {
            OleDbConnection oConn = new OleDbConnection(sChConn);
            oConn.Open();
            OleDbCommand oComm = new OleDbCommand("INSERT INTO Client(NOM,PRE) VALUES('"+TBnom.Text+"','"+TBpre.Text+"')", oConn);
            int nb = (int)oComm.ExecuteNonQuery();
            if(nb==1)
                LBconsole.Items.Add("Ajout confirmé !");
            else
                LBconsole.Items.Add("problème à l'ajout");
            oConn.Close();
        }
    }
}
