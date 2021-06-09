using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace GD_Decouverte
{
    public partial class EcranSerial : Form
    {
        public EcranSerial()
        {
            InitializeComponent();
        }

        private void B_classePrepa_Click(object sender, EventArgs e)
        {
            PersonneSerialisable ps = new PersonneSerialisable(1, "Napoléon", "Bonaparte", new DateTime(1769, 8, 15));
            ps.Lst.Add("Espagne");
            ps.Lst.Add("Autriche");
            ps.Lst.Add("Italie");
            ps.Lst.Add("Prusse");
            ps.SerialFichier("ClassePrepa.xml");

            PersonneSerialisable psBis = PersonneSerialisable.DeserialFichier("ClassePrepa.xml");
            MessageBox.Show("Vérif: " + psBis.Prénom + " " + psBis.Nom);
            for(int i = 0;i<psBis.Lst.Count;i++)
            {
                MessageBox.Show("il a conquis : " + psBis.Lst[i]);
            }
        }
        private void B_hardSerial_Click(object sender, EventArgs e)
        {
            Personne ps = new Personne(1, "Napoléon", "Bonaparte", new DateTime(1769, 8, 15));
            ps.Lst.Add("Espagne");
            ps.Lst.Add("Autriche");
            ps.Lst.Add("Italie");
            ps.Lst.Add("Prusse");
            SerialHard("Hard.xml", ps);

            Personne pBis = DeSerialHard("Hard.xml");
            MessageBox.Show("Vérif: " + pBis.Prénom + " " + pBis.Nom);
            for (int i = 0; i < pBis.Lst.Count; i++)
            {
                MessageBox.Show("il a conquis : " + pBis.Lst[i]);
            }
        }
        private void B_rapidSerial_Click(object sender, EventArgs e)
        {
            Personne ps = new Personne(1, "Napoléon", "Bonaparte", new DateTime(1769, 8, 15));
            ps.Lst.Add("Espagne");
            ps.Lst.Add("Autriche");
            ps.Lst.Add("Italie");
            ps.Lst.Add("Prusse");
            RapidSerial("Rapide.xml", ps);

            Personne pBis = RapidDeSerial("Rapide.xml");
            MessageBox.Show("Vérif: " + pBis.Prénom + " " + pBis.Nom);
            for (int i = 0; i < pBis.Lst.Count; i++)
            {
                MessageBox.Show("il a conquis : " + pBis.Lst[i]);
            }
        }
        private void B_univerSerial_Click(object sender, EventArgs e)
        {
            List<Personne> pListe = new List<Personne>();
            Personne p = new Personne(1, "Napoléon", "Bonaparte", new DateTime(1769, 8, 15));
            p.Lst.Add("Espagne");
            p.Lst.Add("Autriche");
            p.Lst.Add("Italie");
            p.Lst.Add("Prusse");
            pListe.Add(p);

            p = new Personne(2, "Jules", "César", new DateTime(400,1,1));
            p.Lst.Add("italie");
            p.Lst.Add("Corse");
            p.Lst.Add("Hispanie");
            p.Lst.Add("La Gaule ? non pas toute");
            pListe.Add(p);

            UtilitaireSerialisation.UnivSerial<List<Personne>>("univer.xml", pListe);

            List<Personne> pListeBis = UtilitaireSerialisation.UnivDeSerial<List<Personne>>("univer.xml");

            foreach (Personne pb in pListeBis)
            {
                MessageBox.Show("Vérif: " + pb.Prénom + " " + pb.Nom);
                for (int i = 0; i < pb.Lst.Count; i++)
                {
                    MessageBox.Show("il a conquis : " + pb.Lst[i]);
                }
            }
        }



        public void RapidSerial(string sFichier, Personne aPer)
        {
            XmlSerializer xs = new XmlSerializer(aPer.GetType());
            StreamWriter sw = new StreamWriter(sFichier);
            xs.Serialize(sw, aPer);
            sw.Close();
        }

        public Personne RapidDeSerial(string sFichier)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Personne));
            StreamReader sr = new StreamReader(sFichier);
            Personne pRep = (Personne)xs.Deserialize(sr);
            sr.Close();
            return pRep;
        }

        public void SerialHard(string sFichier, Personne aPer)
        {
            using (XmlTextWriter xw = new XmlTextWriter(sFichier, Encoding.UTF8)) 
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("Personne");
                xw.WriteAttributeString("Identifiant", aPer.ID.ToString());
                xw.WriteElementString("Prénom", aPer.Prénom);
                xw.WriteElementString("Nom", aPer.Nom);
                xw.WriteStartElement("Liste");
                foreach (string c in aPer.Lst)
                {
                    xw.WriteElementString("Conquête", c);
                }
                xw.WriteEndElement();
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Close();
            }
        }

        public Personne DeSerialHard(string sFichier)
        {
            Personne pRep = new Personne();
            using (XmlTextReader xr = new XmlTextReader(sFichier))
            {
                while(xr.Read())
                {
                    if(xr.Name == "Personne")
                    {
                        xr.MoveToAttribute("Identifiant");
                        pRep.ID = xr.ReadContentAsInt();
                        xr.Read();
                        pRep.Prénom = xr.ReadElementContentAsString();
                        pRep.Nom = xr.ReadElementContentAsString();
                        if(xr.Name=="Liste" && !xr.IsEmptyElement)
                        {
                            xr.Read();
                            while (xr.Name == "Conquête")
                                pRep.Lst.Add(xr.ReadElementContentAsString());
                        }
                        xr.Read();
                    }
                }
                xr.Close();
            }
            return pRep;
        }

        [Serializable]
        [XmlRoot()]
        public class PersonneSerialisable
        {
            [XmlAttribute("Identifiant")]
            public int ID { get; set; }
            [XmlElement("Prénom")]
            public string Prénom { get; set; }
            [XmlElement("Nom")]
            public string Nom { get; set; }
            [XmlIgnore()]
            //[XmlElement("Date")]
            public DateTime Naissance { get; set; }
            [XmlArray("Liste")]
            [XmlArrayItem("Conquête")]
            public List<string> Lst { get; set; }
            public PersonneSerialisable()
            { Lst = new List<string>(); }
            public PersonneSerialisable(int ID_, string Pre_, string Nom_, DateTime Nai_) : this()
            {
                ID = ID_;
                Prénom = Pre_;
                Nom = Nom_;
                Naissance = Nai_;
            }

            public void SerialFichier (string sFichier)
            {
                using (StreamWriter sw = new StreamWriter(sFichier))
                {
                    XmlSerializer xs = new XmlSerializer(this.GetType());
                    xs.Serialize(sw, this);
                    sw.Close();
                }
            }
            public static PersonneSerialisable DeserialFichier(string sFichier)
            {
                using (StreamReader sr = new StreamReader(sFichier))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(PersonneSerialisable));
                    PersonneSerialisable oTmp = (PersonneSerialisable)xs.Deserialize(sr);
                    sr.Close();
                    return oTmp;
                }
            }
        }
        public class Personne
        {
            public int ID { get; set; }
            public string Prénom { get; set; }
            public string Nom { get; set; }
            public DateTime Naissance { get; set; }
            public List<string> Lst { get; set; }
            public Personne()
            { Lst = new List<string>(); }
            public Personne(int ID_,string Pre_, string Nom_, DateTime Nai_):this()
            {
                ID = ID_;
                Prénom = Pre_;
                Nom = Nom_;
                Naissance = Nai_;
            }
        }

        public class UtilitaireSerialisation
        {
            public static void UnivSerial<T>(string sFichier, T tArg)
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                StreamWriter sw = new StreamWriter(sFichier);
                xs.Serialize(sw, tArg);
                sw.Close();
            }

            public static T UnivDeSerial<T>(string sFichier)
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                StreamReader sr = new StreamReader(sFichier);
                T pRep = (T)xs.Deserialize(sr);
                sr.Close();
                return pRep;
            }

        }
    }
}
