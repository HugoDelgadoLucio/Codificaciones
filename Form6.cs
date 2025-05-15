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
    public partial class Form6 : Form
    {
        private string cad = "";

        public Form6()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string asd = "          ";
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
                Manchester(g, aux);
            }

            panelCodi.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            panelCodi.Controls.Add(pb);
            panelCodi.AutoScrollMinSize = new Size(ancho, alto);
        }

        private void Manchester(Graphics g, string bits)
        {
            int x = 10;
            int bit1 = 50;
            int bit0 = 100;
            int ancho = 25;

            int bitPrev = bits[0] == '1' ? bit0 : bit1;
            int bitContr = bits[0] == '1' ? bit1 : bit0;
            g.DrawLine(Pens.Black, x, bitPrev, x + ancho, bitPrev);
            g.DrawLine(Pens.Black, x + ancho, bitPrev, x + ancho, bitContr);
            g.DrawLine(Pens.Black, x + ancho, bitContr, x + (ancho * 2), bitContr);
            x += (ancho*2);

            for (int i = 1; i < bits.Length; i++)
            {
                int bitAct;
                int aux;
                if (bits[i] == '1')
                {
                    bitAct = bit0;
                    aux = bit1;
                }
                else
                {
                    bitAct = bit1;
                    aux = bit0;
                }
                if (bitAct == bitPrev)
                {
                    g.DrawLine(Pens.Black, x, bit1, x, bit0);
                }
                g.DrawLine(Pens.Black, x, bitAct, x + ancho, bitAct);
                g.DrawLine(Pens.Black, x + ancho, bit1, x + ancho, bit0);
                g.DrawLine(Pens.Black, x + ancho, aux, x + (ancho*2), aux);

                bitPrev = bitAct;
                x += (ancho*2);
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
