namespace Billar
{
    partial class ReporteVentasForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasForm));
            dgvReporteVentas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            MesaNombre = new DataGridViewTextBoxColumn();
            MontoEfectivo = new DataGridViewTextBoxColumn();
            MontoTarjeta = new DataGridViewTextBoxColumn();
            MontoMesas = new DataGridViewTextBoxColumn();
            MontoConsumo = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            dpDesde = new DateTimePicker();
            dpHasta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            label3 = new Label();
            label4 = new Label();
            lblTotalEfectivo = new Label();
            lblTotalTarjeta = new Label();
            lblTotal = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            lblTotalConsumo = new Label();
            label7 = new Label();
            label5 = new Label();
            lblTotalMesas = new Label();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReporteVentas
            // 
            dgvReporteVentas.AllowUserToAddRows = false;
            dgvReporteVentas.AllowUserToDeleteRows = false;
            dgvReporteVentas.AllowUserToResizeColumns = false;
            dgvReporteVentas.AllowUserToResizeRows = false;
            dgvReporteVentas.BackgroundColor = Color.White;
            dgvReporteVentas.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporteVentas.ColumnHeadersHeight = 40;
            dgvReporteVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReporteVentas.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Usuario, MesaNombre, MontoEfectivo, MontoTarjeta, MontoMesas, MontoConsumo, Total });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvReporteVentas.DefaultCellStyle = dataGridViewCellStyle9;
            dgvReporteVentas.EnableHeadersVisualStyles = false;
            dgvReporteVentas.Location = new Point(29, 368);
            dgvReporteVentas.MultiSelect = false;
            dgvReporteVentas.Name = "dgvReporteVentas";
            dgvReporteVentas.ReadOnly = true;
            dgvReporteVentas.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvReporteVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvReporteVentas.RowHeadersVisible = false;
            dgvReporteVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvReporteVentas.RowTemplate.Height = 25;
            dgvReporteVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteVentas.Size = new Size(1332, 426);
            dgvReporteVentas.TabIndex = 17;
            dgvReporteVentas.CellDoubleClick += dgvReporteVentas_CellDoubleClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            Fecha.FillWeight = 30F;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Usuario.DataPropertyName = "Usuario";
            Usuario.FillWeight = 30F;
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // MesaNombre
            // 
            MesaNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MesaNombre.DataPropertyName = "MesaNombre";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MesaNombre.DefaultCellStyle = dataGridViewCellStyle3;
            MesaNombre.FillWeight = 30F;
            MesaNombre.HeaderText = "Origen";
            MesaNombre.Name = "MesaNombre";
            MesaNombre.ReadOnly = true;
            // 
            // MontoEfectivo
            // 
            MontoEfectivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoEfectivo.DataPropertyName = "MontoEfectivo";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            MontoEfectivo.DefaultCellStyle = dataGridViewCellStyle4;
            MontoEfectivo.FillWeight = 25F;
            MontoEfectivo.HeaderText = "Efectivo";
            MontoEfectivo.Name = "MontoEfectivo";
            MontoEfectivo.ReadOnly = true;
            // 
            // MontoTarjeta
            // 
            MontoTarjeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoTarjeta.DataPropertyName = "MontoTarjeta";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n0";
            MontoTarjeta.DefaultCellStyle = dataGridViewCellStyle5;
            MontoTarjeta.FillWeight = 25F;
            MontoTarjeta.HeaderText = "Tarjeta";
            MontoTarjeta.Name = "MontoTarjeta";
            MontoTarjeta.ReadOnly = true;
            // 
            // MontoMesas
            // 
            MontoMesas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoMesas.DataPropertyName = "MontoMesas";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n0";
            MontoMesas.DefaultCellStyle = dataGridViewCellStyle6;
            MontoMesas.FillWeight = 25F;
            MontoMesas.HeaderText = "Total Mesa";
            MontoMesas.Name = "MontoMesas";
            MontoMesas.ReadOnly = true;
            // 
            // MontoConsumo
            // 
            MontoConsumo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoConsumo.DataPropertyName = "MontoConsumo";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            MontoConsumo.DefaultCellStyle = dataGridViewCellStyle7;
            MontoConsumo.FillWeight = 30F;
            MontoConsumo.HeaderText = "Total Consumo";
            MontoConsumo.Name = "MontoConsumo";
            MontoConsumo.ReadOnly = true;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n0";
            Total.DefaultCellStyle = dataGridViewCellStyle8;
            Total.FillWeight = 30F;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // dpDesde
            // 
            dpDesde.Location = new Point(38, 46);
            dpDesde.Name = "dpDesde";
            dpDesde.Size = new Size(200, 23);
            dpDesde.TabIndex = 18;
            // 
            // dpHasta
            // 
            dpHasta.Location = new Point(309, 46);
            dpHasta.Name = "dpHasta";
            dpHasta.Size = new Size(200, 23);
            dpHasta.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 20;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(309, 18);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 21;
            label2.Text = "Hasta";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(532, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 34);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 34);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 23;
            label3.Text = "Total Efectivo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 79);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 24;
            label4.Text = "Total Tarjeta :";
            // 
            // lblTotalEfectivo
            // 
            lblTotalEfectivo.AutoSize = true;
            lblTotalEfectivo.BackColor = SystemColors.InfoText;
            lblTotalEfectivo.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalEfectivo.ForeColor = Color.White;
            lblTotalEfectivo.Location = new Point(247, 34);
            lblTotalEfectivo.Name = "lblTotalEfectivo";
            lblTotalEfectivo.Size = new Size(23, 25);
            lblTotalEfectivo.TabIndex = 25;
            lblTotalEfectivo.Text = "0";
            // 
            // lblTotalTarjeta
            // 
            lblTotalTarjeta.AutoSize = true;
            lblTotalTarjeta.BackColor = SystemColors.InfoText;
            lblTotalTarjeta.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalTarjeta.ForeColor = Color.White;
            lblTotalTarjeta.Location = new Point(247, 79);
            lblTotalTarjeta.Name = "lblTotalTarjeta";
            lblTotalTarjeta.Size = new Size(23, 25);
            lblTotalTarjeta.TabIndex = 26;
            lblTotalTarjeta.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.InfoText;
            lblTotal.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1175, 34);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(23, 25);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(959, 34);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 27;
            label6.Text = "Total Ventas :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblTotalConsumo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblTotalMesas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblTotalEfectivo);
            groupBox1.Controls.Add(lblTotalTarjeta);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(29, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1332, 197);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblTotalConsumo
            // 
            lblTotalConsumo.AutoSize = true;
            lblTotalConsumo.BackColor = SystemColors.InfoText;
            lblTotalConsumo.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalConsumo.ForeColor = Color.White;
            lblTotalConsumo.Location = new Point(726, 79);
            lblTotalConsumo.Name = "lblTotalConsumo";
            lblTotalConsumo.Size = new Size(23, 25);
            lblTotalConsumo.TabIndex = 32;
            lblTotalConsumo.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(478, 79);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 31;
            label7.Text = "Total Consumo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(478, 34);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 29;
            label5.Text = "Total Mesas";
            // 
            // lblTotalMesas
            // 
            lblTotalMesas.AutoSize = true;
            lblTotalMesas.BackColor = SystemColors.InfoText;
            lblTotalMesas.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalMesas.ForeColor = Color.White;
            lblTotalMesas.Location = new Point(726, 34);
            lblTotalMesas.Name = "lblTotalMesas";
            lblTotalMesas.Size = new Size(23, 25);
            lblTotalMesas.TabIndex = 30;
            lblTotalMesas.Text = "0";
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = (Image)resources.GetObject("btnExportar.BackgroundImage");
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Location = new Point(1309, 323);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(52, 39);
            btnExportar.TabIndex = 30;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // ReporteVentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1409, 821);
            Controls.Add(btnExportar);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dpHasta);
            Controls.Add(dpDesde);
            Controls.Add(dgvReporteVentas);
            Name = "ReporteVentasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteVentasForm";
            Load += ReporteVentasForm_Load;
            Paint += ReporteVentasForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporteVentas;
        private DateTimePicker dpDesde;
        private DateTimePicker dpHasta;
        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private Label label3;
        private Label label4;
        private Label lblTotalEfectivo;
        private Label lblTotalTarjeta;
        private Label lblTotal;
        private Label label6;
        private GroupBox groupBox1;
        private Label label5;
        private Label lblTotalMesas;
        private Label lblTotalConsumo;
        private Label label7;
        private Button btnExportar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn MesaNombre;
        private DataGridViewTextBoxColumn MontoEfectivo;
        private DataGridViewTextBoxColumn MontoTarjeta;
        private DataGridViewTextBoxColumn MontoMesas;
        private DataGridViewTextBoxColumn MontoConsumo;
        private DataGridViewTextBoxColumn Total;
    }
}