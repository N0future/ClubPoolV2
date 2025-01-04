namespace Billar
{
    partial class VentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            btnPararTiempo = new Button();
            groupBox2 = new GroupBox();
            btnCancelarPagos = new Button();
            btnVenta = new Button();
            dgvPagos = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            PagoCon = new DataGridViewTextBoxColumn();
            vuelto = new DataGridViewTextBoxColumn();
            btnPagar = new Button();
            lblTotal = new Label();
            label7 = new Label();
            lblMontoPendiente = new Label();
            lblTotalPagado = new Label();
            label12 = new Label();
            label18 = new Label();
            dgvConsumo = new DataGridView();
            Id2 = new DataGridViewTextBoxColumn();
            Descripcion2 = new DataGridViewTextBoxColumn();
            Precio2 = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnEstadoMesa = new Button();
            btnRestarItem = new Button();
            btnSumarItem = new Button();
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsumo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnPararTiempo
            // 
            btnPararTiempo.BackColor = Color.DodgerBlue;
            btnPararTiempo.Enabled = false;
            btnPararTiempo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPararTiempo.ForeColor = SystemColors.ControlLightLight;
            btnPararTiempo.Location = new Point(613, 770);
            btnPararTiempo.Name = "btnPararTiempo";
            btnPararTiempo.Size = new Size(142, 58);
            btnPararTiempo.TabIndex = 36;
            btnPararTiempo.Text = "Parar Tiempo";
            btnPararTiempo.UseVisualStyleBackColor = false;
            btnPararTiempo.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnCancelarPagos);
            groupBox2.Controls.Add(btnVenta);
            groupBox2.Controls.Add(dgvPagos);
            groupBox2.Controls.Add(btnPagar);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblMontoPendiente);
            groupBox2.Controls.Add(lblTotalPagado);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label18);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(38, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1288, 282);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Venta";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnCancelarPagos
            // 
            btnCancelarPagos.BackgroundImage = (Image)resources.GetObject("btnCancelarPagos.BackgroundImage");
            btnCancelarPagos.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelarPagos.FlatAppearance.BorderSize = 0;
            btnCancelarPagos.FlatStyle = FlatStyle.Flat;
            btnCancelarPagos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarPagos.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelarPagos.Location = new Point(888, 139);
            btnCancelarPagos.Name = "btnCancelarPagos";
            btnCancelarPagos.Size = new Size(104, 60);
            btnCancelarPagos.TabIndex = 43;
            btnCancelarPagos.UseVisualStyleBackColor = false;
            btnCancelarPagos.Click += btnCancelarPagos_Click;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.Maroon;
            btnVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.ForeColor = SystemColors.ControlLightLight;
            btnVenta.Location = new Point(1098, 216);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(168, 49);
            btnVenta.TabIndex = 42;
            btnVenta.Text = "Cerrar Venta";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.AllowUserToResizeColumns = false;
            dgvPagos.AllowUserToResizeRows = false;
            dgvPagos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPagos.ColumnHeadersHeight = 35;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, PagoCon, vuelto });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPagos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.Location = new Point(35, 40);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPagos.RowHeadersVisible = false;
            dgvPagos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPagos.RowTemplate.Height = 25;
            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagos.Size = new Size(812, 182);
            dgvPagos.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "metodo";
            dataGridViewTextBoxColumn2.FillWeight = 58.33182F;
            dataGridViewTextBoxColumn2.HeaderText = "Tipo Pago";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "monto";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n0";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.FillWeight = 62.9159737F;
            dataGridViewTextBoxColumn3.HeaderText = "Monto";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PagoCon
            // 
            PagoCon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            PagoCon.DefaultCellStyle = dataGridViewCellStyle3;
            PagoCon.HeaderText = "Pago";
            PagoCon.Name = "PagoCon";
            PagoCon.ReadOnly = true;
            // 
            // vuelto
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            vuelto.DefaultCellStyle = dataGridViewCellStyle4;
            vuelto.HeaderText = "Vuelto";
            vuelto.Name = "vuelto";
            vuelto.ReadOnly = true;
            // 
            // btnPagar
            // 
            btnPagar.BackgroundImage = (Image)resources.GetObject("btnPagar.BackgroundImage");
            btnPagar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = SystemColors.ActiveCaptionText;
            btnPagar.Location = new Point(900, 49);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(79, 59);
            btnPagar.TabIndex = 28;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.InfoText;
            lblTotal.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(124, 242);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(20, 23);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(35, 242);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 16;
            label7.Text = "Total";
            // 
            // lblMontoPendiente
            // 
            lblMontoPendiente.AutoSize = true;
            lblMontoPendiente.BackColor = SystemColors.InfoText;
            lblMontoPendiente.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoPendiente.ForeColor = Color.White;
            lblMontoPendiente.Location = new Point(592, 242);
            lblMontoPendiente.Name = "lblMontoPendiente";
            lblMontoPendiente.Size = new Size(20, 23);
            lblMontoPendiente.TabIndex = 35;
            lblMontoPendiente.Text = "0";
            // 
            // lblTotalPagado
            // 
            lblTotalPagado.AutoSize = true;
            lblTotalPagado.BackColor = SystemColors.InfoText;
            lblTotalPagado.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPagado.ForeColor = Color.White;
            lblTotalPagado.Location = new Point(375, 242);
            lblTotalPagado.Name = "lblTotalPagado";
            lblTotalPagado.Size = new Size(20, 23);
            lblTotalPagado.TabIndex = 34;
            lblTotalPagado.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(231, 242);
            label12.Name = "label12";
            label12.Size = new Size(125, 23);
            label12.TabIndex = 33;
            label12.Text = "Total Pagado ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(463, 242);
            label18.Name = "label18";
            label18.Size = new Size(93, 23);
            label18.TabIndex = 26;
            label18.Text = "Pendiente";
            // 
            // dgvConsumo
            // 
            dgvConsumo.AllowUserToAddRows = false;
            dgvConsumo.AllowUserToDeleteRows = false;
            dgvConsumo.AllowUserToResizeColumns = false;
            dgvConsumo.AllowUserToResizeRows = false;
            dgvConsumo.BackgroundColor = Color.White;
            dgvConsumo.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvConsumo.ColumnHeadersHeight = 40;
            dgvConsumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsumo.Columns.AddRange(new DataGridViewColumn[] { Id2, Descripcion2, Precio2, Cantidad, Subtotal });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvConsumo.DefaultCellStyle = dataGridViewCellStyle11;
            dgvConsumo.EnableHeadersVisualStyles = false;
            dgvConsumo.Location = new Point(795, 364);
            dgvConsumo.MultiSelect = false;
            dgvConsumo.Name = "dgvConsumo";
            dgvConsumo.ReadOnly = true;
            dgvConsumo.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvConsumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvConsumo.RowHeadersVisible = false;
            dgvConsumo.RowTemplate.Height = 25;
            dgvConsumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsumo.Size = new Size(531, 484);
            dgvConsumo.TabIndex = 31;
            // 
            // Id2
            // 
            Id2.DataPropertyName = "Id2";
            Id2.HeaderText = "Id2";
            Id2.Name = "Id2";
            Id2.ReadOnly = true;
            Id2.Visible = false;
            // 
            // Descripcion2
            // 
            Descripcion2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion2.DataPropertyName = "Descripcion";
            Descripcion2.FillWeight = 101.522842F;
            Descripcion2.HeaderText = "Descripcion";
            Descripcion2.Name = "Descripcion2";
            Descripcion2.ReadOnly = true;
            // 
            // Precio2
            // 
            Precio2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio2.DataPropertyName = "Precio2";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n0";
            Precio2.DefaultCellStyle = dataGridViewCellStyle8;
            Precio2.FillWeight = 30F;
            Precio2.HeaderText = "Precio";
            Precio2.Name = "Precio2";
            Precio2.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle9;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "n0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle10;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // btnEstadoMesa
            // 
            btnEstadoMesa.BackColor = Color.PaleGreen;
            btnEstadoMesa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstadoMesa.ForeColor = SystemColors.ControlLightLight;
            btnEstadoMesa.Location = new Point(613, 683);
            btnEstadoMesa.Name = "btnEstadoMesa";
            btnEstadoMesa.Size = new Size(142, 58);
            btnEstadoMesa.TabIndex = 30;
            btnEstadoMesa.Text = "Abrir Mesa";
            btnEstadoMesa.UseVisualStyleBackColor = false;
            btnEstadoMesa.Visible = false;
            // 
            // btnRestarItem
            // 
            btnRestarItem.BackColor = Color.White;
            btnRestarItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestarItem.Image = (Image)resources.GetObject("btnRestarItem.Image");
            btnRestarItem.Location = new Point(613, 419);
            btnRestarItem.Name = "btnRestarItem";
            btnRestarItem.Size = new Size(142, 43);
            btnRestarItem.TabIndex = 29;
            btnRestarItem.UseVisualStyleBackColor = false;
            btnRestarItem.Click += btnRestarItem_Click;
            // 
            // btnSumarItem
            // 
            btnSumarItem.BackColor = Color.White;
            btnSumarItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSumarItem.Image = (Image)resources.GetObject("btnSumarItem.Image");
            btnSumarItem.Location = new Point(613, 360);
            btnSumarItem.Name = "btnSumarItem";
            btnSumarItem.Size = new Size(142, 43);
            btnSumarItem.TabIndex = 28;
            btnSumarItem.UseVisualStyleBackColor = false;
            btnSumarItem.Click += btnSumarItem_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(38, 321);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(541, 33);
            txtBuscar.TabIndex = 40;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvProductos.ColumnHeadersHeight = 40;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Precio });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle15;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(38, 360);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(541, 488);
            dgvProductos.TabIndex = 38;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.FillWeight = 101.522842F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "n0";
            Precio.DefaultCellStyle = dataGridViewCellStyle14;
            Precio.FillWeight = 30F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1380, 874);
            Controls.Add(txtBuscar);
            Controls.Add(dgvProductos);
            Controls.Add(btnPararTiempo);
            Controls.Add(groupBox2);
            Controls.Add(dgvConsumo);
            Controls.Add(btnEstadoMesa);
            Controls.Add(btnRestarItem);
            Controls.Add(btnSumarItem);
            Name = "VentaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VentaForm";
            Load += VentaForm_Load;
            Paint += VentaForm_Paint;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsumo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPararTiempo;
        private GroupBox groupBox2;
        private Label lblMontoPendiente;
        private Label lblTotalPagado;
        private DataGridView dgvPagos;
        private Button btnPagar;
        private Label label12;
        private Label label18;
        private Label lblTotal;
        private Label label7;
        private DataGridView dgvConsumo;
        private Button btnEstadoMesa;
        private Button btnRestarItem;
        private Button btnSumarItem;
        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Button btnVenta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn PagoCon;
        private DataGridViewTextBoxColumn vuelto;
        private DataGridViewTextBoxColumn Id2;
        private DataGridViewTextBoxColumn Descripcion2;
        private DataGridViewTextBoxColumn Precio2;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private Button btnCancelarPagos;
    }
}