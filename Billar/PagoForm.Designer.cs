namespace Billar
{
    partial class PagoForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoForm));
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            label2 = new Label();
            btnPagar = new Button();
            lblEfectivoPagado = new Label();
            label1 = new Label();
            txtPagado = new TextBox();
            txtMonto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbEfectivo.ForeColor = SystemColors.ActiveCaptionText;
            rbEfectivo.Location = new Point(457, 23);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(96, 29);
            rbEfectivo.TabIndex = 2;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbTarjeta.ForeColor = SystemColors.ActiveCaptionText;
            rbTarjeta.Location = new Point(457, 149);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(86, 29);
            rbTarjeta.TabIndex = 3;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnPagar);
            groupBox1.Controls.Add(lblEfectivoPagado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPagado);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 283);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.InfoText;
            lblTotal.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ControlLightLight;
            lblTotal.Location = new Point(203, 47);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 37);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InfoText;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(100, 47);
            label2.Name = "label2";
            label2.Size = new Size(97, 37);
            label2.TabIndex = 11;
            label2.Text = "Total : ";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.SpringGreen;
            btnPagar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(140, 195);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(127, 47);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblEfectivoPagado
            // 
            lblEfectivoPagado.AutoSize = true;
            lblEfectivoPagado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEfectivoPagado.ForeColor = SystemColors.ActiveCaptionText;
            lblEfectivoPagado.Location = new Point(229, 108);
            lblEfectivoPagado.Name = "lblEfectivoPagado";
            lblEfectivoPagado.Size = new Size(152, 25);
            lblEfectivoPagado.TabIndex = 8;
            lblEfectivoPagado.Text = "Efectivo pagado ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(42, 108);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 7;
            label1.Text = "Monto a pagar";
            // 
            // txtPagado
            // 
            txtPagado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagado.Location = new Point(229, 136);
            txtPagado.MaxLength = 10;
            txtPagado.Name = "txtPagado";
            txtPagado.Size = new Size(159, 33);
            txtPagado.TabIndex = 5;
            txtPagado.TextChanged += txtPagado_TextChanged;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.Location = new Point(42, 136);
            txtMonto.MaxLength = 10;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(159, 33);
            txtMonto.TabIndex = 4;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(447, 55);
            label4.Name = "label4";
            label4.Size = new Size(106, 88);
            label4.TabIndex = 10;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(447, 197);
            label3.Name = "label3";
            label3.Size = new Size(106, 88);
            label3.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PagoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(575, 309);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rbEfectivo);
            Controls.Add(rbTarjeta);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PagoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESTABLECER PAGO";
            Load += Pago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private GroupBox groupBox1;
        private TextBox txtMonto;
        private Button btnPagar;
        private Label lblEfectivoPagado;
        private Label label1;
        private TextBox txtPagado;
        private Label label4;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblTotal;
        private Label label2;
    }
}