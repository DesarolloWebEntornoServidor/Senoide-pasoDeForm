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

        Pen penRecibe;
        Point[] puntosRecibe;

        Color colorPanel, colorTrazo;
        float grosor;

        int amplitud;
        public Form2(Color colorTr, float gr, Color colorFon, Point[] puntos, int aY)
        {
            InitializeComponent();

            this.colorTrazo = colorTr;
            this.colorPanel = colorFon;
            this.grosor = gr;
            this.puntosRecibe = puntos;
            this.amplitud = aY;

            grafico = panelDibujo.CreateGraphics();

            button1.Hide();

            txtMensaje.Visible = false;

        }


        private void Form2_Load(object sender, EventArgs e)
        {

            if (amplitud != 0)
            {
                grafico = panelDibujo.CreateGraphics();

                panelDibujo.BackColor = colorPanel;

                Pen pen = new Pen(colorTrazo, grosor);

                grafico.DrawLine(pen, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);

                grafico.DrawLines(pen, puntosRecibe);
            }
            else
            {
                txtMensaje.Visible = true;
                txtMensaje.Text = "El Valor de Amplitud,. no puede ser Cero !!!";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            grafico = panelDibujo.CreateGraphics();

           // panelDibujo.BackColor = colorPanel;

            //textBox1.Text = aYRecibe.ToString();

            Pen pen = new Pen(colorTrazo, grosor);

            grafico.DrawLine(pen, 0, panelDibujo.Height / 2, panelDibujo.Width, panelDibujo.Height / 2);

            grafico.DrawLines(pen, puntosRecibe);

            int a = 0;
        }
    }
}
