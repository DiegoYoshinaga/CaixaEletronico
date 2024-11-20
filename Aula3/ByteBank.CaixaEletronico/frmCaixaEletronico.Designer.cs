namespace ByteBank.CaixaEletronico
{
    partial class frmCaixaEletronico
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
            groupBox1 = new GroupBox();
            btnExtrato = new Button();
            button10 = new Button();
            btn0 = new Button();
            button12 = new Button();
            btnSaldo = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDepositar = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSacar = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            groupBox3 = new GroupBox();
            txtValor = new TextBox();
            groupBox4 = new GroupBox();
            txtConsole = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(btnExtrato);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(btnSaldo);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btnDepositar);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btnSacar);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Location = new Point(40, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 380);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // btnExtrato
            // 
            btnExtrato.BackColor = SystemColors.ControlDark;
            btnExtrato.BackgroundImage = Properties.Resources.extrato;
            btnExtrato.BackgroundImageLayout = ImageLayout.Stretch;
            btnExtrato.FlatStyle = FlatStyle.Flat;
            btnExtrato.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnExtrato.ForeColor = SystemColors.ControlDark;
            btnExtrato.Location = new Point(350, 286);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Size = new Size(125, 82);
            btnExtrato.TabIndex = 31;
            btnExtrato.UseVisualStyleBackColor = false;
            btnExtrato.Click += btnOperacao_Click;
            btnExtrato.MouseDown += btn_MouseDown;
            btnExtrato.MouseUp += btn_MouseUp;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlDark;
            button10.BackgroundImage = Properties.Resources.empty;
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlDark;
            button10.Location = new Point(238, 286);
            button10.Name = "button10";
            button10.Size = new Size(106, 82);
            button10.TabIndex = 30;
            button10.UseVisualStyleBackColor = false;
            button10.MouseDown += btn_MouseDown;
            button10.MouseUp += btn_MouseUp;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.BackgroundImage = Properties.Resources._0;
            btn0.BackgroundImageLayout = ImageLayout.Stretch;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.ControlDark;
            btn0.Location = new Point(126, 286);
            btn0.Name = "btn0";
            btn0.Size = new Size(106, 82);
            btn0.TabIndex = 29;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumero_Click;
            btn0.MouseDown += btn_MouseDown;
            btn0.MouseUp += btn_MouseUp;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlDark;
            button12.BackgroundImage = Properties.Resources.empty;
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ControlDark;
            button12.Location = new Point(14, 286);
            button12.Name = "button12";
            button12.Size = new Size(106, 82);
            button12.TabIndex = 28;
            button12.UseVisualStyleBackColor = false;
            button12.MouseDown += btn_MouseDown;
            button12.MouseUp += btn_MouseUp;
            // 
            // btnSaldo
            // 
            btnSaldo.BackColor = SystemColors.ControlDark;
            btnSaldo.BackgroundImage = Properties.Resources.saldo;
            btnSaldo.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaldo.FlatStyle = FlatStyle.Flat;
            btnSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaldo.ForeColor = SystemColors.ControlDark;
            btnSaldo.Location = new Point(350, 197);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(125, 82);
            btnSaldo.TabIndex = 27;
            btnSaldo.UseVisualStyleBackColor = false;
            btnSaldo.Click += btnOperacao_Click;
            btnSaldo.MouseDown += btn_MouseDown;
            btnSaldo.MouseUp += btn_MouseUp;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.BackgroundImage = Properties.Resources._9;
            btn9.BackgroundImageLayout = ImageLayout.Stretch;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ControlDark;
            btn9.Location = new Point(238, 198);
            btn9.Name = "btn9";
            btn9.Size = new Size(106, 82);
            btn9.TabIndex = 26;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumero_Click;
            btn9.MouseDown += btn_MouseDown;
            btn9.MouseUp += btn_MouseUp;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.BackgroundImage = Properties.Resources._8;
            btn8.BackgroundImageLayout = ImageLayout.Stretch;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ControlDark;
            btn8.Location = new Point(126, 198);
            btn8.Name = "btn8";
            btn8.Size = new Size(106, 82);
            btn8.TabIndex = 25;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumero_Click;
            btn8.MouseDown += btn_MouseDown;
            btn8.MouseUp += btn_MouseUp;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDark;
            btn7.BackgroundImage = Properties.Resources._7;
            btn7.BackgroundImageLayout = ImageLayout.Stretch;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ControlDark;
            btn7.Location = new Point(14, 198);
            btn7.Name = "btn7";
            btn7.Size = new Size(106, 82);
            btn7.TabIndex = 24;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumero_Click;
            btn7.MouseDown += btn_MouseDown;
            btn7.MouseUp += btn_MouseUp;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = SystemColors.ControlDark;
            btnDepositar.BackgroundImage = Properties.Resources.depositar1;
            btnDepositar.BackgroundImageLayout = ImageLayout.Stretch;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositar.ForeColor = SystemColors.ControlDark;
            btnDepositar.Location = new Point(350, 109);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(125, 82);
            btnDepositar.TabIndex = 23;
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnOperacao_Click;
            btnDepositar.MouseDown += btn_MouseDown;
            btnDepositar.MouseUp += btn_MouseUp;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDark;
            btn6.BackgroundImage = Properties.Resources._6;
            btn6.BackgroundImageLayout = ImageLayout.Stretch;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ControlDark;
            btn6.Location = new Point(238, 110);
            btn6.Name = "btn6";
            btn6.Size = new Size(106, 82);
            btn6.TabIndex = 22;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumero_Click;
            btn6.MouseDown += btn_MouseDown;
            btn6.MouseUp += btn_MouseUp;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDark;
            btn5.BackgroundImage = Properties.Resources._5;
            btn5.BackgroundImageLayout = ImageLayout.Stretch;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ControlDark;
            btn5.Location = new Point(126, 110);
            btn5.Name = "btn5";
            btn5.Size = new Size(106, 82);
            btn5.TabIndex = 21;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumero_Click;
            btn5.MouseDown += btn_MouseDown;
            btn5.MouseUp += btn_MouseUp;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.BackgroundImage = Properties.Resources._4;
            btn4.BackgroundImageLayout = ImageLayout.Stretch;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ControlDark;
            btn4.Location = new Point(14, 110);
            btn4.Name = "btn4";
            btn4.Size = new Size(106, 82);
            btn4.TabIndex = 20;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumero_Click;
            btn4.MouseDown += btn_MouseDown;
            btn4.MouseUp += btn_MouseUp;
            // 
            // btnSacar
            // 
            btnSacar.BackColor = SystemColors.ControlDark;
            btnSacar.BackgroundImage = Properties.Resources.sacar1;
            btnSacar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSacar.FlatStyle = FlatStyle.Flat;
            btnSacar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSacar.ForeColor = SystemColors.ControlDark;
            btnSacar.Location = new Point(350, 21);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(125, 82);
            btnSacar.TabIndex = 19;
            btnSacar.UseVisualStyleBackColor = false;
            btnSacar.Click += btnOperacao_Click;
            btnSacar.MouseDown += btn_MouseDown;
            btnSacar.MouseUp += btn_MouseUp;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.BackgroundImage = Properties.Resources._3;
            btn3.BackgroundImageLayout = ImageLayout.Stretch;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ControlDark;
            btn3.Location = new Point(238, 22);
            btn3.Name = "btn3";
            btn3.Size = new Size(106, 82);
            btn3.TabIndex = 18;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumero_Click;
            btn3.MouseDown += btn_MouseDown;
            btn3.MouseUp += btn_MouseUp;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.BackgroundImage = Properties.Resources._2;
            btn2.BackgroundImageLayout = ImageLayout.Stretch;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ControlDark;
            btn2.Location = new Point(126, 22);
            btn2.Name = "btn2";
            btn2.Size = new Size(106, 82);
            btn2.TabIndex = 17;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumero_Click;
            btn2.MouseDown += btn_MouseDown;
            btn2.MouseUp += btn_MouseUp;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.BackgroundImage = Properties.Resources._1;
            btn1.BackgroundImageLayout = ImageLayout.Stretch;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ControlDark;
            btn1.Location = new Point(14, 21);
            btn1.Name = "btn1";
            btn1.Size = new Size(106, 82);
            btn1.TabIndex = 16;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumero_Click;
            btn1.MouseDown += btn_MouseDown;
            btn1.MouseUp += btn_MouseUp;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(txtValor);
            groupBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(40, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(492, 92);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtValor.BackColor = Color.Black;
            txtValor.Font = new Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtValor.ForeColor = Color.White;
            txtValor.Location = new Point(17, 31);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(458, 45);
            txtValor.TabIndex = 0;
            txtValor.TextAlign = HorizontalAlignment.Right;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtConsole);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(12);
            groupBox4.Size = new Size(942, 769);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            // 
            // txtConsole
            // 
            txtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConsole.BackColor = Color.Black;
            txtConsole.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtConsole.ForeColor = Color.LightGreen;
            txtConsole.Location = new Point(12, 28);
            txtConsole.Multiline = true;
            txtConsole.Name = "txtConsole";
            txtConsole.ReadOnly = true;
            txtConsole.ScrollBars = ScrollBars.Vertical;
            txtConsole.Size = new Size(918, 224);
            txtConsole.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ByteBank_esq1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 489);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.ByteBank_dir2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(759, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 489);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(942, 511);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(183, 19);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(576, 489);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            // 
            // frmCaixaEletronico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(942, 769);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            MinimumSize = new Size(958, 808);
            Name = "frmCaixaEletronico";
            Text = "ByteBank - Caixa Eletrônico";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button10;
        private Button btn0;
        private Button button12;
        private Button btnSaldo;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDepositar;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSacar;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private GroupBox groupBox3;
        private TextBox txtValor;
        private GroupBox groupBox4;
        private TextBox txtConsole;
        private Button btnExtrato;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
    }
}