using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Codificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSele_Click(object sender, EventArgs e)
        {
            switch (this.comboBoxTipo.Text)
            {
                case "NRZ-L":
                    Form form2 = new Form2();
                    form2.ShowDialog();
                    break;
                case "NRZ-I":
                    Form form3 = new Form3();
                    form3.ShowDialog();
                    break;
                case "Bipolar AMI":
                    Form form4 = new Form4();
                    form4.ShowDialog();
                    break;
                case "Pseudoternario":
                    Form form5 = new Form5();
                    form5.ShowDialog();
                    break;
                case "Manchester":
                    Form form6 = new Form6();
                    form6.ShowDialog();
                    break;
                case "Codigo Diferencial":
                    Form form7 = new Form7();
                    form7.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Selecciona una opcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Estas seguro de salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
