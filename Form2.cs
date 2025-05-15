using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codificaciones
{
    public partial class Form2 : Form
    {
        private string cad = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string asd = " ";
            if (radioBtn0.Checked)
                this.cad += radioBtn0.Text;
            else
                this.cad += radioBtn1.Text;

            char[] auxiliar = this.cad.ToCharArray();
            foreach (char c in auxiliar)
            {
                asd = asd + c + "        ";
            }

            this.labelCad.Text = asd;

            string aux = this.cad;

            int bit = 50;
            int alto = panelCodi.Height;
            int ancho = aux.Length * bit + 20;

            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                NRZL(g, aux);
            }

            panelCodi.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            panelCodi.Controls.Add(pb);
            panelCodi.AutoScrollMinSize = new Size(ancho, alto);

        }

        private void NRZL(Graphics g, string bits)
        {
            int x = 10;
            int bit1 = 50;
            int bit0 = 100;
            int ancho = 50;

            int yPrev = bits[0] == '1' ? bit1 : bit0;
            g.DrawLine(Pens.Black, x, yPrev, x + ancho, yPrev);
            x += ancho;

            for (int i = 1; i < bits.Length; i++)
            {
                int yCurr = bits[i] == '1' ? bit1 : bit0;

                if (yCurr != yPrev)
                {
                    g.DrawLine(Pens.Black, x, yPrev, x, yCurr);
                }

                g.DrawLine(Pens.Black, x, yCurr, x + ancho, yCurr);
                yPrev = yCurr;
                x += ancho;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReini_Click(object sender, EventArgs e)
        {
            panelCodi.Controls.Clear();
            this.cad = "";
            this.labelCad.Text = "";
        }
    }
}
