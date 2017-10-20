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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            panelDibujo.Controls.Clear();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            // Y = A*seno(x * n * 2π /p)
            double a = 2 * Math.PI;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            label2.BackColor = colorDialog1.Color;

            label2.ForeColor = colorDialog1.Color;


        }
    }
}
