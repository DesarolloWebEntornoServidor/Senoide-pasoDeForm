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
        public PracticaW11()
        {
            InitializeComponent();
        }

        private void lbOffset_Click(object sender, EventArgs e)
        {

        }

        private void cbRojo_CheckedChanged(object sender, EventArgs e)
        {

        }


        Graphics grafico;
        int showLine = 0;

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grafico = panelDibujo.CreateGraphics();
            grafico.Clear(panelDibujo.BackColor);
            showLine = 0;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {


            Point[] puntos = new Point[panelDibujo.Width];

            grafico = panelDibujo.CreateGraphics();


            int aY = trkbAmplitud.Value;

            for (int i = 0; i < panelDibujo.Width; i++)
            {
                puntos[i].X = i;
                puntos[i].Y = panelDibujo.Height / 2 - (int)(aY * Math.Sin(((double)nudDesfase.Value * Math.PI / 180) + i * (double)nudCiclos.Value * 2 * Math.PI / panelDibujo.Width)) + (int)nudOffset.Value;

            }
            if (showLine == 0)
            {
                Pen pen1 = new Pen(lbColorTrazo.BackColor, (float)(cbGrosor.SelectedItem));
                grafico.DrawLine(pen1, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);
                showLine = 1;
                
            }


            Pen pen = new Pen(lbColorTrazo.BackColor, (float)(cbGrosor.SelectedItem));

            grafico.DrawLines(pen,puntos);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            lbColorTrazo.BackColor = colorDialog1.Color;

            lbColorTrazo.ForeColor = colorDialog1.Color;


        }

        private void rbBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlanco.Checked)
                panelDibujo.BackColor = Color.White;
            else if (rbNegro.Checked)
                panelDibujo.BackColor = Color.Black;
            else if (rbRojo.Checked)
                panelDibujo.BackColor = Color.Red;
            else if (rbVerde.Checked)
                panelDibujo.BackColor = Color.Green;
            else if (rbAzul.Checked)
                panelDibujo.BackColor = Color.Blue;

        }

        private void PracticaW11_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                cbGrosor.Items.Add(i/2F);
            }

            cbGrosor.SelectedIndex = 4;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float pos = (265 - (trkbAmplitud.Value) * 0.9F);
            lbAmplitud.Text = trkbAmplitud.Value.ToString();
            lbAmplitud.Location = (new Point(54, (int)pos));
        }


    }
}
