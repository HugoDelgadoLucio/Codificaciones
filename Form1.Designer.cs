namespace Codificaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnSalir = new Button();
            btnSele = new Button();
            comboBoxTipo = new ComboBox();
            labelTipo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnSele);
            panel1.Controls.Add(comboBoxTipo);
            panel1.Controls.Add(labelTipo);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 1000);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.DarkGoldenrod;
            btnSalir.Location = new Point(331, 123);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(144, 53);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSele
            // 
            btnSele.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSele.ForeColor = Color.DarkGoldenrod;
            btnSele.Location = new Point(116, 123);
            btnSele.Name = "btnSele";
            btnSele.Size = new Size(144, 53);
            btnSele.TabIndex = 15;
            btnSele.Text = "Seleccionar";
            btnSele.UseVisualStyleBackColor = true;
            btnSele.Click += btnSele_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxTipo.ForeColor = Color.DarkGoldenrod;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "NRZ-L", "NRZ-I", "Bipolar AMI", "Pseudoternario", "Manchester", "Codigo Diferencial" });
            comboBoxTipo.Location = new Point(384, 51);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(157, 26);
            comboBoxTipo.TabIndex = 6;
            comboBoxTipo.Text = "--Codificacion--";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.BorderStyle = BorderStyle.Fixed3D;
            labelTipo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.ForeColor = SystemColors.ButtonHighlight;
            labelTipo.Location = new Point(51, 50);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(327, 27);
            labelTipo.TabIndex = 3;
            labelTipo.Text = "Escoge el tipo de codificacion:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 215);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codificaciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
        private Button btnSele;
        private Button btnSalir;
    }
}
