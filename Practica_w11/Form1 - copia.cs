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
    public partial class PracticaW11 : Form
    {
        Point[] puntos = null;
        Color colorPanel, colorTrazo;
        Pen pen;
        float grosor;
        int aY = 0;
        float numCiclos = 0;
        float numFases = 0;

        public static class Grafico
        {
           // public  Point[] puntos;

            //public static Grafico(Point[] puntos)
            //{
            //    this.puntos = puntos;
            //}


        }

        

        public PracticaW11()
        {
            InitializeComponent();
        }
        # region  Propriedades
        public Point[] Puntos
        {
            get { return puntos; }
            set {

                Form2 form2 = new Form2();
                // Hago que éste sea su propietario
                form2.Owner = this;

                // Por probar otra forma, lo lanzamos simplemente
                form2.Show();

                int aY = trkbAmplitud.Value;

                for (int i = 0; i < form2.PanelDibujo.Width; i++)
                {
                    puntos[i].X = i;
                    puntos[i].Y = form2.PanelDibujo.Height / 2 - (int)(aY * Math.Sin(((double)nudDesfase.Value * Math.PI / 180) + i * (double)nudCiclos.Value * 2 * Math.PI / form2.PanelDibujo.Width)) + (int)nudOffset.Value;

                }



               // puntos = value;
            }
        }
        public Color ColorPanel
        {
            get { return colorPanel; }
            set { colorPanel = value; }
        }
        public Color ColorTrazo
        {
            get { return colorTrazo; }
            set { colorTrazo = value; }
        }
        public float Grosor
        {
            get { return grosor; }
            set { grosor = value; }
        }
        public int AY
        {
            get { return aY; }
            set { aY = value; }
        }
        public float NumCiclos
        {
            get { return numCiclos; }
            set { numCiclos = value; }
        }
        public float NumFases
        {
            get { return numFases; }
            set { numFases = value; }
        }
        public Pen Pen
        {
            get { return pen; }
            set { pen = new Pen(lbColorTrazo.BackColor, (float)(cbGrosor.SelectedItem)); }
        }
        #endregion

        Graphics grafico;
        int showLine = 0;

        private void btnBorrar_Click(object sender, EventArgs e)
        {
              // grafico = form2.PanelDibujo.CreateGraphics();
              // grafico.Clear(form2.PanelDibujo.BackColor);
            showLine = 0;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // Hago que éste sea su propietario
            form2.Owner = this;

            // Por probar otra forma, lo lanzamos simplemente
            form2.Show();

           //  puntos = new Point[form2.PanelDibujo.Width];

           //// grafico = panelDibujo.CreateGraphics();


           // int aY = trkbAmplitud.Value;

           // for (int i = 0; i < form2.PanelDibujo.Width; i++)
           // {
           //     puntos[i].X = i;
           //     puntos[i].Y = form2.PanelDibujo.Height / 2 - (int)(aY * Math.Sin(((double)nudDesfase.Value * Math.PI / 180) + i * (double)nudCiclos.Value * 2 * Math.PI / form2.PanelDibujo.Width)) + (int)nudOffset.Value;

           // }
           // //if (showLine == 0)
           // //{
           // //    Pen pen1 = new Pen(lbColorTrazo.BackColor, (float)(cbGrosor.SelectedItem));
           // //    grafico.DrawLine(pen1, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);
           // //    showLine = 1;

           // //}

           // grosor = (float)(cbGrosor.SelectedItem);
           // colorTrazo = lbColorTrazo.BackColor;

           // pen = new Pen(lbColorTrazo.BackColor, (float)(cbGrosor.SelectedItem));

          //  grafico.DrawLines(pen,puntos);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            lbColorTrazo.BackColor = colorDialog1.Color;

            lbColorTrazo.ForeColor = colorDialog1.Color;

            colorTrazo = lbColorTrazo.BackColor;

        }

        private void rbBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlanco.Checked)
                colorPanel = Color.White;
            else if (rbNegro.Checked)
                colorPanel = Color.Black;
            else if (rbRojo.Checked)
                colorPanel = Color.Red;
            else if (rbVerde.Checked)
                colorPanel = Color.Green;
            else if (rbAzul.Checked)
                colorPanel = Color.Blue;

        }

        private void PracticaW11_Load(object sender, EventArgs e)
        {
            for (int i = 2; i < 11; i++)
            {
                cbGrosor.Items.Add(i/2F);
            }

            cbGrosor.SelectedIndex = 3;

        }

        private void cbGrosor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grosor = (float)(cbGrosor.SelectedItem);

        }

        private void nudCiclos_ValueChanged(object sender, EventArgs e)
        {
            numCiclos = (float)nudCiclos.Value;
        }

        private void nudDesfase_ValueChanged(object sender, EventArgs e)
        {
            numFases = (float)nudDesfase.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float pos = (265 - (trkbAmplitud.Value) * 0.9F);
            lbAmplitud.Text = trkbAmplitud.Value.ToString();
            lbAmplitud.Location = (new Point(54, (int)pos));

            aY = trkbAmplitud.Value;

        }


    }
}
