using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_w11
{
    public partial class Form2 : Form
    {

        Graphics grafico;

        PracticaW11 form1;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form1 = ((PracticaW11)(this.Owner));

            Point[] puntos = new Point[PanelDibujo.Width]; 
            Color colorForm2 = form1.ColorPanel;
            Pen pen = new Pen(form1.ColorTrazo, form1.Grosor);
            int aY = form1.AY;
            float nudCiclos = form1.NumCiclos;
            float nudDesfase = form1.NumFases;

            grafico = panelDibujo.CreateGraphics();

            panelDibujo.BackColor = colorForm2;

            for (int i = 0; i < PanelDibujo.Width; i++)
            {
                puntos[i].X = i;
                puntos[i].Y = PanelDibujo.Height / 2 - (int)(aY * Math.Sin(((double)nudDesfase * Math.PI / 180) + i * (double)nudCiclos * 2 * Math.PI / PanelDibujo.Width));

            }

            grafico.DrawLine(pen, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);

            grafico.DrawLines(pen, puntos);

            int a = 0;

        }

        public Panel PanelDibujo
        {
            get { return panelDibujo; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] puntos = new Point[PanelDibujo.Width];
            Color colorForm2 = form1.ColorPanel;
            Pen pen = new Pen(form1.ColorTrazo, form1.Grosor);
            int aY = form1.AY;
            float nudCiclos = form1.NumCiclos;
            float nudDesfase = form1.NumFases;

            grafico = panelDibujo.CreateGraphics();

            panelDibujo.BackColor = colorForm2;

            for (int i = 0; i < PanelDibujo.Width; i++)
            {
                puntos[i].X = i;
                puntos[i].Y = PanelDibujo.Height / 2 - (int)(aY * Math.Sin(((double)nudDesfase * Math.PI / 180) + i * (double)nudCiclos * 2 * Math.PI / PanelDibujo.Width));

            }

            grafico.DrawLine(pen, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);

            grafico.DrawLines(pen, puntos);
        }
    }
}
