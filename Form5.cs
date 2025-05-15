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
    public partial class Form5 : Form
    {
        private string cad = "";

        public Form5()
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
                asd = asd + c + "|      ";
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
                Pseudoternario(g, aux);
            }

            panelCodi.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            panelCodi.Controls.Add(pb);
            panelCodi.AutoScrollMinSize = new Size(ancho, alto);
        }

        private void Pseudoternario(Graphics g, string bits)
        {
            int x = 10;
            int bit1 = 50;
            int bit0 = 100;
            int bitM1 = 150;
            int ancho = 50;

            bool ban = true;

            int yPrev;
            if (bits[0] == '0')
            {
                yPrev = bit1;
                ban = !ban;
            }
            else
            {
                yPrev = bit0;
            }

            g.DrawLine(Pens.Black, x, yPrev, x + ancho, yPrev);
            x += ancho;

            for (int i = 1; i < bits.Length; i++)
            {
                int yAct;
                if (bits[i] == '0')
                {
                    if (ban)
                    {
                        yAct = bit1;
                        ban = !ban;
                    }
                    else
                    {
                        yAct = bitM1;
                        ban = !ban;
                    }
                }
                else
                {
                    yAct = bit0;
                }

                if (yAct != yPrev)
                {
                    g.DrawLine(Pens.Black, x, yPrev, x, yAct);
                }

                g.DrawLine(Pens.Black, x, yAct, x + ancho, yAct);
                yPrev = yAct;
                x += ancho;
            }
        }

        private void btnReini_Click(object sender, EventArgs e)
        {
            panelCodi.Controls.Clear();
            this.cad = "";
            this.labelCad.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
