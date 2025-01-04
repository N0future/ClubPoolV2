namespace Billar
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnEntrar = new Button();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LightGreen;
            btnEntrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(115, 354);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(193, 46);
            btnEntrar.TabIndex = 26;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 243);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 25;
            label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(82, 278);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 33);
            txtPassword.TabIndex = 24;
            txtPassword.Text = "1234";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 173);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 23;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(82, 207);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(258, 33);
            txtUsuario.TabIndex = 22;
            txtUsuario.Text = "obaeza";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 137);
            label1.TabIndex = 27;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(423, 506);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PoolSystem 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsuario;
        private Label label1;
    }
}