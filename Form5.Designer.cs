namespace Codificaciones
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelNRZL = new Panel();
            panelSenal = new Panel();
            labelCad = new Label();
            panelCodi = new Panel();
            listBox1 = new ListBox();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            btnReini = new Button();
            radioBtn1 = new RadioButton();
            radioBtn0 = new RadioButton();
            btnEnter = new Button();
            labelPseudo = new Label();
            panel1.SuspendLayout();
            panelNRZL.SuspendLayout();
            panelSenal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(panelNRZL);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(labelPseudo);
            panel1.Location = new Point(-4, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 1000);
            panel1.TabIndex = 0;
            // 
            // panelNRZL
            // 
            panelNRZL.BorderStyle = BorderStyle.Fixed3D;
            panelNRZL.Controls.Add(panelSenal);
            panelNRZL.Controls.Add(panelCodi);
            panelNRZL.Controls.Add(listBox1);
            panelNRZL.Location = new Point(16, 165);
            panelNRZL.Name = "panelNRZL";
            panelNRZL.Size = new Size(1086, 329);
            panelNRZL.TabIndex = 15;
            // 
            // panelSenal
            // 
            panelSenal.AutoScroll = true;
            panelSenal.BackColor = SystemColors.ButtonHighlight;
            panelSenal.BorderStyle = BorderStyle.Fixed3D;
            panelSenal.Controls.Add(labelCad);
            panelSenal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelSenal.Location = new Point(41, 36);
            panelSenal.Name = "panelSenal";
            panelSenal.Size = new Size(1030, 62);
            panelSenal.TabIndex = 6;
            // 
            // labelCad
            // 
            labelCad.AutoSize = true;
            labelCad.ForeColor = Color.DarkGoldenrod;
            labelCad.Location = new Point(3, 13);
            labelCad.Name = "labelCad";
            labelCad.Size = new Size(0, 19);
            labelCad.TabIndex = 0;
            // 
            // panelCodi
            // 
            panelCodi.AutoScroll = true;
            panelCodi.AutoScrollMinSize = new Size(50, 0);
            panelCodi.BackColor = SystemColors.ButtonHighlight;
            panelCodi.BorderStyle = BorderStyle.Fixed3D;
            panelCodi.Location = new Point(41, 104);
            panelCodi.Name = "panelCodi";
            panelCodi.Size = new Size(1030, 209);
            panelCodi.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.DarkGoldenrod;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { " 1", " ", " ", " 0", "", "", "-1" });
            listBox1.Location = new Point(3, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(28, 137);
            listBox1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.DarkGoldenrod;
            btnSalir.Location = new Point(982, 11);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 53);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReini);
            groupBox1.Controls.Add(radioBtn1);
            groupBox1.Controls.Add(radioBtn0);
            groupBox1.Controls.Add(btnEnter);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(344, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 134);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresa 1's y 0's para empezar a codificar la señal";
            // 
            // btnReini
            // 
            btnReini.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReini.ForeColor = Color.DarkGoldenrod;
            btnReini.Location = new Point(283, 43);
            btnReini.Name = "btnReini";
            btnReini.Size = new Size(120, 53);
            btnReini.TabIndex = 11;
            btnReini.Text = "Reiniciar";
            btnReini.UseVisualStyleBackColor = true;
            btnReini.Click += btnReini_Click;
            // 
            // radioBtn1
            // 
            radioBtn1.AutoSize = true;
            radioBtn1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtn1.Location = new Point(35, 74);
            radioBtn1.Name = "radioBtn1";
            radioBtn1.Size = new Size(55, 43);
            radioBtn1.TabIndex = 4;
            radioBtn1.Text = "1";
            radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn0
            // 
            radioBtn0.AutoSize = true;
            radioBtn0.Checked = true;
            radioBtn0.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtn0.Location = new Point(35, 25);
            radioBtn0.Name = "radioBtn0";
            radioBtn0.Size = new Size(55, 43);
            radioBtn0.TabIndex = 3;
            radioBtn0.TabStop = true;
            radioBtn0.Text = "0";
            radioBtn0.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.DarkGoldenrod;
            btnEnter.Location = new Point(139, 43);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(120, 53);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // labelPseudo
            // 
            labelPseudo.AutoSize = true;
            labelPseudo.BorderStyle = BorderStyle.Fixed3D;
            labelPseudo.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPseudo.ForeColor = SystemColors.ButtonHighlight;
            labelPseudo.Location = new Point(16, 14);
            labelPseudo.Name = "labelPseudo";
            labelPseudo.Size = new Size(290, 44);
            labelPseudo.TabIndex = 10;
            labelPseudo.Text = "Pseudoternario";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 501);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pseudoternario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelNRZL.ResumeLayout(false);
            panelSenal.ResumeLayout(false);
            panelSenal.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelPseudo;
        private GroupBox groupBox1;
        private Button btnReini;
        private RadioButton radioBtn1;
        private RadioButton radioBtn0;
        private Button btnEnter;
        private Button btnSalir;
        private Panel panelNRZL;
        private Panel panelSenal;
        private Label labelCad;
        private Panel panelCodi;
        private ListBox listBox1;
    }
}