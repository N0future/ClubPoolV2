namespace Billar
{
    partial class MesaEditForm
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
            lblEfectivoPagado = new Label();
            label1 = new Label();
            txtPrecioHora = new TextBox();
            txtPrecioMinimo = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblEfectivoPagado
            // 
            lblEfectivoPagado.AutoSize = true;
            lblEfectivoPagado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEfectivoPagado.ForeColor = Color.White;
            lblEfectivoPagado.Location = new Point(38, 94);
            lblEfectivoPagado.Name = "lblEfectivoPagado";
            lblEfectivoPagado.Size = new Size(122, 25);
            lblEfectivoPagado.TabIndex = 12;
            lblEfectivoPagado.Text = "Precio Hora :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 11;
            label1.Text = "Precio Minimo :";
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioHora.Location = new Point(241, 94);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(159, 33);
            txtPrecioHora.TabIndex = 10;
            // 
            // txtPrecioMinimo
            // 
            txtPrecioMinimo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioMinimo.Location = new Point(241, 37);
            txtPrecioMinimo.Name = "txtPrecioMinimo";
            txtPrecioMinimo.Size = new Size(159, 33);
            txtPrecioMinimo.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(264, 156);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 46);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // MesaEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(475, 263);
            Controls.Add(btnGuardar);
            Controls.Add(lblEfectivoPagado);
            Controls.Add(label1);
            Controls.Add(txtPrecioHora);
            Controls.Add(txtPrecioMinimo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MesaEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Valores Mesa";
            Load += MesaEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEfectivoPagado;
        private Label label1;
        private TextBox txtPrecioHora;
        private TextBox txtPrecioMinimo;
        private Button btnGuardar;
    }
}