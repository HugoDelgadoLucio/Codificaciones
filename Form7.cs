using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codificaciones
{
    public partial class Form7 : Form
    {
        private string cad = "";

        public Form7()
        {
            InitializeComponent();
            /*Bitmap bmp = new Bitmap(this.panelCodi.Width, this.panelCodi.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawLine(Pens.Cyan, 10, 50, this.panelCodi.Width, 50);
                g.DrawLine(Pens.Cyan, 10, 100, this.panelCodi.Width, 100);
                g.DrawLine(Pens.Cyan, 10, 150, this.panelCodi.Width, 150);
            }
            panelCodi.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            panelCodi.Controls.Add(pb);*/
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
                Diferencial(g, aux);
            }

            panelCodi.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            panelCodi.Controls.Add(pb);
            panelCodi.AutoScrollMinSize = new Size(ancho, alto);
        }

        private void Diferencial(Graphics g, string bits)
        {
            bool ban = true;

            int x = 10;
            int bit1 = 50;
            int bit0 = 100;
            int ancho = 25;

            int bitPrev;
            int bitContr;
            if (bits[0] == '1')
            {
                bitPrev = bit0;
                bitContr = bit1;
                ban = !ban;
            }
            else
            {
                bitPrev = bit1;
                bitContr = bit0;
            }
            
            g.DrawLine(Pens.Black, x, bitPrev, x + ancho, bitPrev);
            g.DrawLine(Pens.Black, x + ancho, bitPrev, x + ancho, bitContr);
            g.DrawLine(Pens.Black, x + ancho, bitContr, x + (ancho * 2), bitContr);
            x += (ancho * 2);

            for (int i = 1; i < bits.Length; i++)
            {
                int bitAct;
                int aux;
                if (bits[i] == '1')
                {
                    if (ban)
                    {
                        bitAct = bit0;
                        aux = bit1;
                        ban = !ban;
                    }
                    else
                    {
                        bitAct = bit1;
                        aux = bit0;
                        ban = !ban;
                    }
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
                g.DrawLine(Pens.Black, x + ancho, aux, x + (ancho * 2), aux);

                bitPrev = bitAct;
                x += (ancho * 2);
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
