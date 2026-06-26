namespace Bot_Tutor_profesional
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
            panel1 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            button8 = new Button();
            button1 = new Button();
            button5 = new Button();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtPantallaInfo = new RichTextBox();
            panel3 = new Panel();
            btnVerificar = new Button();
            txtRespuesta = new TextBox();
            btnSalir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 661);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 52, 54);
            button6.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.CheckedBackColor = Color.Black;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 446);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(173, 33);
            button6.TabIndex = 6;
            button6.Text = "Exponentes";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 112);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(0, 40);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 4;
            label1.Text = "TUTOR ÁLGEBRA v2.0";
            label1.Click += label1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(45, 52, 54);
            button8.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.CheckedBackColor = Color.Black;
            button8.FlatAppearance.MouseDownBackColor = Color.Black;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(12, 561);
            button8.Name = "button8";
            button8.Padding = new Padding(20, 0, 0, 0);
            button8.Size = new Size(173, 33);
            button8.TabIndex = 7;
            button8.Text = "Funciones";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 52, 54);
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 135);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(173, 33);
            button1.TabIndex = 1;
            button1.Text = "Ecuaciones lineales";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(45, 52, 54);
            button5.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.CheckedBackColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 388);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(173, 33);
            button5.TabIndex = 5;
            button5.Text = "Desigualdades";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(45, 52, 54);
            button7.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.CheckedBackColor = Color.Black;
            button7.FlatAppearance.MouseDownBackColor = Color.Black;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(12, 505);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(173, 34);
            button7.TabIndex = 1;
            button7.Text = "Logaritmos";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 52, 54);
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 185);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(173, 54);
            button2.TabIndex = 2;
            button2.Text = "Ecuaciones cuadraticas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(45, 52, 54);
            button3.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 257);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(173, 33);
            button3.TabIndex = 3;
            button3.Text = "Factorizacion";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(45, 52, 54);
            button4.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 307);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(173, 52);
            button4.TabIndex = 4;
            button4.Text = "Sistemas de ecuaciones";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtPantallaInfo
            // 
            txtPantallaInfo.BackColor = Color.FromArgb(20, 27, 38);
            txtPantallaInfo.BorderStyle = BorderStyle.None;
            txtPantallaInfo.Dock = DockStyle.Fill;
            txtPantallaInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantallaInfo.ForeColor = Color.White;
            txtPantallaInfo.Location = new Point(206, 0);
            txtPantallaInfo.Name = "txtPantallaInfo";
            txtPantallaInfo.ReadOnly = true;
            txtPantallaInfo.Size = new Size(1152, 661);
            txtPantallaInfo.TabIndex = 1;
            txtPantallaInfo.Text = "";
            txtPantallaInfo.TextChanged += txtPantallaInfo_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 45, 59);
            panel3.Controls.Add(btnVerificar);
            panel3.Controls.Add(txtRespuesta);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(206, 531);
            panel3.Name = "panel3";
            panel3.Size = new Size(1152, 130);
            panel3.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(0, 192, 0);
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.ForeColor = Color.Black;
            btnVerificar.Location = new Point(853, 0);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(105, 36);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "VERIFICAR RESPUESTA";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRespuesta.Location = new Point(95, 3);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(661, 33);
            txtRespuesta.TabIndex = 3;
            txtRespuesta.TextChanged += txtRespuesta_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tomato;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(12, 616);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            ClientSize = new Size(1358, 661);
            Controls.Add(panel3);
            Controls.Add(txtPantallaInfo);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Tutor virtual de Algebra";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private Panel panel2;
        private Button button8;
        private RichTextBox txtPantallaInfo;
        private Panel panel3;
        private TextBox txtRespuesta;
        private Button btnVerificar;
        private Label label1;
        private Button btnSalir;
    }
}
