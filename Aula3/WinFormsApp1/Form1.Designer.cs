namespace WinFormsApp1
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
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            btnDepositar = new Button();
            btnSacar = new Button();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.Location = new Point(339, 71);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(67, 30);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(306, 130);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(143, 36);
            txtSaldo.TabIndex = 1;
            txtSaldo.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.Location = new Point(322, 187);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(118, 49);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSacar.Location = new Point(322, 256);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(118, 49);
            btnSacar.TabIndex = 3;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldo;
        private TextBox txtSaldo;
        private Button btnDepositar;
        private Button btnSacar;
    }
}