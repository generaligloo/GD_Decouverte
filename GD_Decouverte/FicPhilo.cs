﻿using System;
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
    public partial class EcranPhilo : Form
    {
        #region Données propres
        public int nbPhilosophes;
        private Philosophes[] philosophes;
        private Thread[] gestion;
        public Mutex[] baguettes;
        public StreamWriter foc;
        #endregion
        public EcranPhilo()
        {
            InitializeComponent();
            this.nbPhilosophes = 8;
            foc = new StreamWriter("Trace.txt");
            this.philosophes = new Philosophes[this.nbPhilosophes];
            this.gestion = new Thread[this.nbPhilosophes];
            this.baguettes = new Mutex[this.nbPhilosophes];
            for (int i = 0; i < this.nbPhilosophes; i++)
            {
                this.philosophes[i] = new Philosophes(i, this);
                gestion[i] = new Thread(new ThreadStart(this.philosophes[i].ActionPhilosophe));
                this.baguettes[i] = new Mutex(false);
            }
            for (int i = 0; i < this.nbPhilosophes; i++)
                this.gestion[i].Start();
        }
        private void EcranDinerPhilosophes_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics gr = CreateGraphics();
            int xc = this.ClientSize.Width / 2;
            int yc = this.ClientSize.Height / 2;
            gr.FillEllipse(new SolidBrush(Color.Brown), xc - 80, yc - 80, 160, 160);
            for (int i = 0; i < this.nbPhilosophes; i++)
            {
                gr.FillEllipse(new SolidBrush(Color.White)
                 , xc + (int)(60 * Math.Cos(i * 2 * Math.PI / this.nbPhilosophes)) - 15
                 , yc - (int)(60 * Math.Sin(i * 2 * Math.PI / this.nbPhilosophes)) - 15
                 , 30, 30);
                gr.DrawLine(new Pen(Color.Silver, 3)
                 , xc + (int)(50 * Math.Cos((i * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
                 , yc - (int)(50 * Math.Sin((i * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
                 , xc + (int)(75 * Math.Cos((i * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
                 , yc - (int)(75 * Math.Sin((i * 2 * Math.PI + Math.PI) / this.nbPhilosophes)));
                gr.FillEllipse(new SolidBrush(Color.Navy)
                 , xc + (int)(160 * Math.Cos(i * 2 * Math.PI / this.nbPhilosophes)) - 25
                 , yc - (int)(160 * Math.Sin(i * 2 * Math.PI / this.nbPhilosophes)) - 25
                 , 50, 50);
                gr.FillEllipse(new SolidBrush(Color.Salmon)
                 , xc + (int)(160 * Math.Cos(i * 2 * Math.PI / this.nbPhilosophes)) - 15
                 , yc - (int)(160 * Math.Sin(i * 2 * Math.PI / this.nbPhilosophes)) - 15
                 , 30, 30);
            }
        }
        public void Avancer(int numero)
        {
            foc.WriteLine("Philosophe " + numero.ToString() + " veut manger");
            Graphics gr = CreateGraphics();
            int xc = this.ClientSize.Width / 2;
            int yc = this.ClientSize.Height / 2;
            gr.FillEllipse(new SolidBrush(this.BackColor)
             , xc + (int)(160 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , yc - (int)(160 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , 50, 50);
            gr.FillEllipse(new SolidBrush(Color.Navy)
             , xc + (int)(110 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , yc - (int)(110 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , 50, 50);
            gr.FillEllipse(new SolidBrush(Color.Salmon)
             , xc + (int)(110 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 15
             , yc - (int)(110 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 15
             , 30, 30);
        }
        public void Reculer(int numero)
        {
            foc.WriteLine("Philosophe " + numero.ToString() + " a fini de manger");
            Graphics gr = CreateGraphics();
            int xc = this.ClientSize.Width / 2;
            int yc = this.ClientSize.Height / 2;
            gr.FillEllipse(new SolidBrush(this.BackColor)
             , xc + (int)(110 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , yc - (int)(110 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , 50, 50);
            gr.FillEllipse(new SolidBrush(Color.Navy)
             , xc + (int)(160 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , yc - (int)(160 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 25
             , 50, 50);
            gr.FillEllipse(new SolidBrush(Color.Salmon)
             , xc + (int)(160 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 15
             , yc - (int)(160 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 15
             , 30, 30);
        }
        public void PeutManger(int numero)
        {
            Graphics gr = CreateGraphics();
            int xc = this.ClientSize.Width / 2;
            int yc = this.ClientSize.Height / 2;
            this.baguettes[numero].WaitOne();
            this.baguettes[(numero + 1) % nbPhilosophes].WaitOne();
            foc.WriteLine("Entrée en Lock de " + numero.ToString());
            gr.FillEllipse(new SolidBrush(Color.Red)
             , xc + (int)(60 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 10
             , yc - (int)(60 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 10
             , 20, 20);
            gr.DrawLine(new Pen(Color.Brown, 3)
             , xc + (int)(45 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(45 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , xc + (int)(70 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(70 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes)));
            gr.DrawLine(new Pen(Color.Brown, 3)
             , xc + (int)(45 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(45 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , xc + (int)(70 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(70 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes)));
            gr.DrawLine(new Pen(Color.Silver, 3)
             , xc + (int)(55 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(55 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , xc + (int)(80 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(80 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes)));
            gr.DrawLine(new Pen(Color.Silver, 3)
             , xc + (int)(55 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(55 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , xc + (int)(80 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(80 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes)));
            foc.WriteLine("Philosophe " + numero.ToString() + " mange");
        }
        public void Deposerbaguettes(int numero)
        {
            Graphics gr = CreateGraphics();
            int xc = this.ClientSize.Width / 2;
            int yc = this.ClientSize.Height / 2;
            gr.FillEllipse(new SolidBrush(Color.White)
             , xc + (int)(60 * Math.Cos(numero * 2 * Math.PI / this.nbPhilosophes)) - 10
             , yc - (int)(60 * Math.Sin(numero * 2 * Math.PI / this.nbPhilosophes)) - 10
             , 20, 20);
            gr.DrawLine(new Pen(Color.Brown, 3)
             , xc + (int)(55 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(55 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , xc + (int)(80 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(80 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes)));
            gr.DrawLine(new Pen(Color.Brown, 3)
             , xc + (int)(55 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(55 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , xc + (int)(80 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(80 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes)));
            gr.DrawLine(new Pen(Color.Silver, 3)
             , xc + (int)(45 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(45 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , xc + (int)(70 * Math.Cos((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes))
             , yc - (int)(70 * Math.Sin((numero * 2 * Math.PI - Math.PI) / this.nbPhilosophes)));
            gr.DrawLine(new Pen(Color.Silver, 3)
             , xc + (int)(45 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(45 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , xc + (int)(70 * Math.Cos((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes))
             , yc - (int)(70 * Math.Sin((numero * 2 * Math.PI + Math.PI) / this.nbPhilosophes)));
            this.baguettes[numero].ReleaseMutex();
            this.baguettes[(numero + 1) % this.nbPhilosophes].ReleaseMutex();
            foc.WriteLine("Philosophe " + numero.ToString() + " a fini de manger");
        }
        private void EcranPhilosophes_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < this.nbPhilosophes; i++)
            {
                gestion[i].Abort();
            }
            Application.DoEvents();
            foc.Close();
        }

        private void EcranPhilo_Load(object sender, EventArgs e)
        {

        }
    }
    class Philosophes
    {
        private int data;
        private EcranPhilo fenetre;
        public Philosophes(int numero, EcranPhilo fen)
        {
            this.data = numero;
            this.fenetre = fen;
        }
        public void ActionPhilosophe()
        {
            while (true)
            {
                Penser();
                fenetre.PeutManger(this.data);
                Manger();
                fenetre.Deposerbaguettes(this.data);
            }
        }
        private void Manger()
        {
            Random alea = new Random();
            Application.DoEvents();
            Thread.Sleep(alea.Next(2000, 3000));
            fenetre.Reculer(this.data);
        }
        private void Penser()
        {
            Random alea = new Random();
            Application.DoEvents();
            Thread.Sleep(alea.Next(4000, 6000));
            fenetre.Avancer(this.data);
        }
    }
}
