namespace Billar
{
    partial class AbrirCajaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirCajaForm));
            cmbCaja = new ComboBox();
            btnAbrirCaja = new Button();
            btnCerrarCaja = new Button();
            txtMontoInicio = new TextBox();
            label8 = new Label();
            lblMontoCierre = new Label();
            txtMontoCierre = new TextBox();
            label2 = new Label();
            lblEstadoCaja = new Label();
            gbContabilidad = new GroupBox();
            lblTotalConsumo = new Label();
            lblDiferencia = new Label();
            label11 = new Label();
            label6 = new Label();
            lblCantidadVentas = new Label();
            label7 = new Label();
            lblTotalVentas = new Label();
            lblMontoEfectivo = new Label();
            lblGananciasMesas = new Label();
            lblMontoTarjeta = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            lblCajero = new Label();
            btnDetallesAperturas = new Button();
            gbContabilidad.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCaja
            // 
            cmbCaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCaja.FormattingEnabled = true;
            cmbCaja.Location = new Point(637, 196);
            cmbCaja.Name = "cmbCaja";
            cmbCaja.Size = new Size(156, 33);
            cmbCaja.TabIndex = 4;
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = SystemColors.Control;
            btnAbrirCaja.BackgroundImage = (Image)resources.GetObject("btnAbrirCaja.BackgroundImage");
            btnAbrirCaja.BackgroundImageLayout = ImageLayout.Stretch;
            btnAbrirCaja.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirCaja.Location = new Point(620, 430);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(76, 77);
            btnAbrirCaja.TabIndex = 5;
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += btnAbrirCaja_Click;
            // 
            // btnCerrarCaja
            // 
            btnCerrarCaja.BackColor = SystemColors.Control;
            btnCerrarCaja.BackgroundImage = Properties.Resources.cancelar__1_;
            btnCerrarCaja.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarCaja.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarCaja.Location = new Point(717, 430);
            btnCerrarCaja.Name = "btnCerrarCaja";
            btnCerrarCaja.Size = new Size(76, 77);
            btnCerrarCaja.TabIndex = 6;
            btnCerrarCaja.UseVisualStyleBackColor = false;
            btnCerrarCaja.Click += btnCerrarCaja_Click;
            // 
            // txtMontoInicio
            // 
            txtMontoInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoInicio.Location = new Point(637, 260);
            txtMontoInicio.Name = "txtMontoInicio";
            txtMontoInicio.Size = new Size(156, 33);
            txtMontoInicio.TabIndex = 7;
            txtMontoInicio.TextChanged += txtMontoInicio_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(460, 262);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 11;
            label8.Text = "Efectivo Inicial ";
            // 
            // lblMontoCierre
            // 
            lblMontoCierre.AutoSize = true;
            lblMontoCierre.BackColor = Color.Transparent;
            lblMontoCierre.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoCierre.ForeColor = Color.White;
            lblMontoCierre.Location = new Point(460, 326);
            lblMontoCierre.Name = "lblMontoCierre";
            lblMontoCierre.Size = new Size(155, 25);
            lblMontoCierre.TabIndex = 13;
            lblMontoCierre.Text = "Efectivo Cierre ";
            // 
            // txtMontoCierre
            // 
            txtMontoCierre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoCierre.Location = new Point(637, 322);
            txtMontoCierre.Name = "txtMontoCierre";
            txtMontoCierre.Size = new Size(156, 33);
            txtMontoCierre.TabIndex = 12;
            txtMontoCierre.TextChanged += txtMontoCierre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(460, 199);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 14;
            label2.Text = "Caja ";
            // 
            // lblEstadoCaja
            // 
            lblEstadoCaja.AutoSize = true;
            lblEstadoCaja.BackColor = Color.Transparent;
            lblEstadoCaja.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstadoCaja.ForeColor = Color.White;
            lblEstadoCaja.Location = new Point(460, 37);
            lblEstadoCaja.Name = "lblEstadoCaja";
            lblEstadoCaja.Size = new Size(67, 25);
            lblEstadoCaja.TabIndex = 15;
            lblEstadoCaja.Text = "Caja :";
            // 
            // gbContabilidad
            // 
            gbContabilidad.BackColor = Color.Transparent;
            gbContabilidad.Controls.Add(lblTotalConsumo);
            gbContabilidad.Controls.Add(lblDiferencia);
            gbContabilidad.Controls.Add(label11);
            gbContabilidad.Controls.Add(label6);
            gbContabilidad.Controls.Add(lblCantidadVentas);
            gbContabilidad.Controls.Add(label7);
            gbContabilidad.Controls.Add(lblTotalVentas);
            gbContabilidad.Controls.Add(lblMontoEfectivo);
            gbContabilidad.Controls.Add(lblGananciasMesas);
            gbContabilidad.Controls.Add(lblMontoTarjeta);
            gbContabilidad.Controls.Add(label9);
            gbContabilidad.Controls.Add(label4);
            gbContabilidad.Controls.Add(label3);
            gbContabilidad.Controls.Add(label1);
            gbContabilidad.ForeColor = Color.White;
            gbContabilidad.Location = new Point(37, 91);
            gbContabilidad.Name = "gbContabilidad";
            gbContabilidad.Size = new Size(377, 441);
            gbContabilidad.TabIndex = 16;
            gbContabilidad.TabStop = false;
            gbContabilidad.Text = "Resumen";
            // 
            // lblTotalConsumo
            // 
            lblTotalConsumo.AutoSize = true;
            lblTotalConsumo.BackColor = SystemColors.InfoText;
            lblTotalConsumo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalConsumo.ForeColor = Color.White;
            lblTotalConsumo.Location = new Point(266, 185);
            lblTotalConsumo.Name = "lblTotalConsumo";
            lblTotalConsumo.RightToLeft = RightToLeft.Yes;
            lblTotalConsumo.Size = new Size(23, 25);
            lblTotalConsumo.TabIndex = 30;
            lblTotalConsumo.Text = "0";
            lblTotalConsumo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.BackColor = SystemColors.InfoText;
            lblDiferencia.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiferencia.ForeColor = Color.White;
            lblDiferencia.Location = new Point(267, 283);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.RightToLeft = RightToLeft.Yes;
            lblDiferencia.Size = new Size(23, 25);
            lblDiferencia.TabIndex = 28;
            lblDiferencia.Text = "0";
            lblDiferencia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(26, 283);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 27;
            label11.Text = "Diferencia ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 185);
            label6.Name = "label6";
            label6.Size = new Size(189, 25);
            label6.TabIndex = 29;
            label6.Text = "Total por Consumo";
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.BackColor = SystemColors.InfoText;
            lblCantidadVentas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadVentas.ForeColor = Color.White;
            lblCantidadVentas.Location = new Point(267, 331);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.RightToLeft = RightToLeft.Yes;
            lblCantidadVentas.Size = new Size(23, 25);
            lblCantidadVentas.TabIndex = 24;
            lblCantidadVentas.Text = "0";
            lblCantidadVentas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 331);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 23;
            label7.Text = "Ventas Realizadas";
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.BackColor = SystemColors.InfoText;
            lblTotalVentas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalVentas.ForeColor = Color.White;
            lblTotalVentas.Location = new Point(267, 235);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.RightToLeft = RightToLeft.Yes;
            lblTotalVentas.Size = new Size(23, 25);
            lblTotalVentas.TabIndex = 22;
            lblTotalVentas.Text = "0";
            lblTotalVentas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMontoEfectivo
            // 
            lblMontoEfectivo.AutoSize = true;
            lblMontoEfectivo.BackColor = SystemColors.InfoText;
            lblMontoEfectivo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMontoEfectivo.ForeColor = Color.White;
            lblMontoEfectivo.Location = new Point(266, 42);
            lblMontoEfectivo.Name = "lblMontoEfectivo";
            lblMontoEfectivo.RightToLeft = RightToLeft.Yes;
            lblMontoEfectivo.Size = new Size(23, 25);
            lblMontoEfectivo.TabIndex = 21;
            lblMontoEfectivo.Text = "0";
            lblMontoEfectivo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGananciasMesas
            // 
            lblGananciasMesas.AutoSize = true;
            lblGananciasMesas.BackColor = SystemColors.InfoText;
            lblGananciasMesas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGananciasMesas.ForeColor = Color.White;
            lblGananciasMesas.Location = new Point(266, 137);
            lblGananciasMesas.Name = "lblGananciasMesas";
            lblGananciasMesas.RightToLeft = RightToLeft.Yes;
            lblGananciasMesas.Size = new Size(23, 25);
            lblGananciasMesas.TabIndex = 26;
            lblGananciasMesas.Text = "0";
            lblGananciasMesas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMontoTarjeta
            // 
            lblMontoTarjeta.AutoSize = true;
            lblMontoTarjeta.BackColor = SystemColors.InfoText;
            lblMontoTarjeta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMontoTarjeta.ForeColor = Color.White;
            lblMontoTarjeta.Location = new Point(266, 90);
            lblMontoTarjeta.Name = "lblMontoTarjeta";
            lblMontoTarjeta.RightToLeft = RightToLeft.Yes;
            lblMontoTarjeta.Size = new Size(23, 25);
            lblMontoTarjeta.TabIndex = 20;
            lblMontoTarjeta.Text = "0";
            lblMontoTarjeta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 137);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 25;
            label9.Text = "Total por Mesas ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 235);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 19;
            label4.Text = "Total en Ventas ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 42);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 18;
            label3.Text = "Efectivo ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 90);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 17;
            label1.Text = "Tarjeta ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(460, 133);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 17;
            label5.Text = "Cajero ";
            // 
            // lblCajero
            // 
            lblCajero.AutoSize = true;
            lblCajero.BackColor = Color.Transparent;
            lblCajero.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCajero.ForeColor = Color.White;
            lblCajero.Location = new Point(637, 141);
            lblCajero.Name = "lblCajero";
            lblCajero.Size = new Size(0, 25);
            lblCajero.TabIndex = 18;
            // 
            // btnDetallesAperturas
            // 
            btnDetallesAperturas.BackColor = Color.DodgerBlue;
            btnDetallesAperturas.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetallesAperturas.ForeColor = SystemColors.ControlLightLight;
            btnDetallesAperturas.Location = new Point(37, 31);
            btnDetallesAperturas.Name = "btnDetallesAperturas";
            btnDetallesAperturas.Size = new Size(145, 39);
            btnDetallesAperturas.TabIndex = 26;
            btnDetallesAperturas.Text = "Detalles";
            btnDetallesAperturas.UseVisualStyleBackColor = false;
            btnDetallesAperturas.Click += btnDetallesAperturas_Click;
            // 
            // AbrirCajaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(847, 585);
            Controls.Add(btnDetallesAperturas);
            Controls.Add(lblCajero);
            Controls.Add(label5);
            Controls.Add(gbContabilidad);
            Controls.Add(label2);
            Controls.Add(lblMontoCierre);
            Controls.Add(txtMontoCierre);
            Controls.Add(label8);
            Controls.Add(txtMontoInicio);
            Controls.Add(lblEstadoCaja);
            Controls.Add(btnCerrarCaja);
            Controls.Add(btnAbrirCaja);
            Controls.Add(cmbCaja);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AbrirCajaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APERTURA Y CIERRE DE CAJA";
            Load += AbrirCajaForm_Load;
            Paint += AbrirCajaForm_Paint;
            gbContabilidad.ResumeLayout(false);
            gbContabilidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCaja;
        private Button btnAbrirCaja;
        private Button btnCerrarCaja;
        private TextBox txtMontoInicio;
        private Label label8;
        private Label lblMontoCierre;
        private TextBox txtMontoCierre;
        private Label label2;
        private Label lblEstadoCaja;
        private GroupBox gbContabilidad;
        private Label lblTotalVentas;
        private Label lblMontoEfectivo;
        private Label lblMontoTarjeta;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label lblCantidadVentas;
        private Label label7;
        private Label lblDiferencia;
        private Label label11;
        private Label lblGananciasMesas;
        private Label label9;
        private Label lblTotalConsumo;
        private Label label6;
        private Label lblCajero;
        private Button btnDetallesAperturas;
    }
}