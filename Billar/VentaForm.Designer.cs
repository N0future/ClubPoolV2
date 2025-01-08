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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
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
            dgvPagos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle17.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvPagos.ColumnHeadersHeight = 35;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, PagoCon, vuelto });
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = SystemColors.Window;
            dataGridViewCellStyle21.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = Color.White;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = Color.Black;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.False;
            dgvPagos.DefaultCellStyle = dataGridViewCellStyle21;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.Location = new Point(35, 40);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Control;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
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
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "n0";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn3.FillWeight = 62.9159737F;
            dataGridViewTextBoxColumn3.HeaderText = "Monto";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PagoCon
            // 
            PagoCon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
            PagoCon.DefaultCellStyle = dataGridViewCellStyle19;
            PagoCon.HeaderText = "Pago";
            PagoCon.Name = "PagoCon";
            PagoCon.ReadOnly = true;
            // 
            // vuelto
            // 
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "n0";
            vuelto.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dgvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dgvConsumo.ColumnHeadersHeight = 40;
            dgvConsumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsumo.Columns.AddRange(new DataGridViewColumn[] { Id2, Descripcion2, Precio2, Cantidad, Subtotal });
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = SystemColors.Window;
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
            dgvConsumo.DefaultCellStyle = dataGridViewCellStyle27;
            dgvConsumo.EnableHeadersVisualStyles = false;
            dgvConsumo.Location = new Point(795, 364);
            dgvConsumo.MultiSelect = false;
            dgvConsumo.Name = "dgvConsumo";
            dgvConsumo.ReadOnly = true;
            dgvConsumo.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Control;
            dataGridViewCellStyle28.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            dgvConsumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
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
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "n0";
            Precio2.DefaultCellStyle = dataGridViewCellStyle24;
            Precio2.FillWeight = 30F;
            Precio2.HeaderText = "Precio";
            Precio2.Name = "Precio2";
            Precio2.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle25;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "n0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle26;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
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
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle29.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = Color.White;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle29.SelectionForeColor = Color.White;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dgvProductos.ColumnHeadersHeight = 40;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Precio });
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = SystemColors.Window;
            dataGridViewCellStyle31.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle31.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle31;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(38, 360);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = SystemColors.Control;
            dataGridViewCellStyle32.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle32.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
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
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "n0";
            Precio.DefaultCellStyle = dataGridViewCellStyle30;
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
            Controls.Add(groupBox2);
            Controls.Add(dgvConsumo);
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