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
         Point[] puntos;
        Color colorPanel;
        Color colorTrazo;
         Pen pen;
        float grosor;
        float numCiclos = 0;
        float numFases = 0;
        int aY = 0;


        public PracticaW11()
        {
            InitializeComponent();

            btnBorrar.Hide();

            colorPanel = Color.White;
        }


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
            Form2 form2 = new Form2(colorTrazo, grosor, colorPanel, puntos, aY);

            pen = new Pen(lbColorTrazo.BackColor, (float)(cbGrosor.SelectedItem));

            puntos = new Point[form2.panelDibujo.Width];

             aY = trkbAmplitud.Value;

            int i = 0;

            for (i = 0; i < form2.panelDibujo.Width; i++)
            {
                puntos[i].X = i;
                puntos[i].Y = form2.panelDibujo.Height / 2 - (int)(aY * Math.Sin(((double)nudDesfase.Value * Math.PI / 180) + i * (double)nudCiclos.Value * 2 * Math.PI / form2.panelDibujo.Width)) + (int)nudOffset.Value;

            }

            grosor = (float)(cbGrosor.SelectedItem);
            colorTrazo = lbColorTrazo.BackColor;

            form2 = new Form2(colorTrazo, grosor, colorPanel, puntos, aY);

            form2.Show();

            grafico = form2.panelDibujo.CreateGraphics();

            form2.panelDibujo.BackColor = colorPanel;

            if(aY > 0)
                grafico.DrawLine(pen, 0, form2.panelDibujo.Height / 2, form2.panelDibujo.Width, form2.panelDibujo.Height / 2);

            grafico.DrawLines(pen, puntos);



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
            //if (rbBlanco.Checked)
            //    lbColor.BackColor = Color.White;
            //else if (rbNegro.Checked)
            //    lbColor.BackColor = Color.Black;
            //else if (rbRojo.Checked)
            //    lbColor.BackColor = Color.Red;
            //else if (rbVerde.Checked)
            //    lbColor.BackColor = Color.Green;
            //else if (rbAzul.Checked)
            //    lbColor.BackColor = Color.Blue;


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
