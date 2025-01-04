namespace Billar
{
    partial class AgregarProductoForm
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
            txtDescripcion = new TextBox();
            label13 = new Label();
            label1 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(223, 98);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(258, 33);
            txtDescripcion.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(63, 98);
            label13.Name = "label13";
            label13.Size = new Size(112, 25);
            label13.TabIndex = 14;
            label13.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 160);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 16;
            label1.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(223, 160);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(258, 33);
            txtPrecio.TabIndex = 15;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 228);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 18;
            label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(223, 228);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(258, 33);
            txtCantidad.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 299);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 20;
            label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(223, 299);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(258, 33);
            txtCodigo.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(256, 392);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 46);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AgregarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(636, 537);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(label13);
            Controls.Add(txtDescripcion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarProductoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProductoForm";
            Load += AgregarProductoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label13;
        private Label label1;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private TextBox txtCodigo;
        private Button btnGuardar;
    }
}