namespace Billar
{
    partial class MesaDetalleForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesaDetalleForm));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            label1 = new Label();
            lblIdMesa = new Label();
            label2 = new Label();
            lblEstado = new Label();
            label3 = new Label();
            lblHoraLlegada = new Label();
            label6 = new Label();
            lblTiempoTranscurrido = new Label();
            dgvProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            btnSumarItem = new Button();
            btnRestarItem = new Button();
            btnEstadoMesa = new Button();
            dgvConsumo = new DataGridView();
            Id2 = new DataGridViewTextBoxColumn();
            Descripcion2 = new DataGridViewTextBoxColumn();
            Precio2 = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblValorMesa = new Label();
            label10 = new Label();
            lblTotalConsumido = new Label();
            lblTotalMesa = new Label();
            groupBox2 = new GroupBox();
            btnCancelarPagos = new Button();
            btnPagar = new Button();
            lblMontoPendiente = new Label();
            label5 = new Label();
            lblTotalPagado = new Label();
            label4 = new Label();
            dgvPagos = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            PagoCon = new DataGridViewTextBoxColumn();
            vuelto = new DataGridViewTextBoxColumn();
            label12 = new Label();
            label18 = new Label();
            lblTotal = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnPararTiempo = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsumo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 1;
            label1.Text = "Mesa ";
            // 
            // lblIdMesa
            // 
            lblIdMesa.AutoSize = true;
            lblIdMesa.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdMesa.ForeColor = SystemColors.Control;
            lblIdMesa.Location = new Point(231, 40);
            lblIdMesa.Name = "lblIdMesa";
            lblIdMesa.Size = new Size(20, 23);
            lblIdMesa.TabIndex = 2;
            lblIdMesa.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(41, 111);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 3;
            label2.Text = "Estado ";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.Control;
            lblEstado.Location = new Point(231, 114);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(134, 23);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Mesa Ocupada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(41, 151);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 11;
            label3.Text = "Hora Llegada ";
            // 
            // lblHoraLlegada
            // 
            lblHoraLlegada.AutoSize = true;
            lblHoraLlegada.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoraLlegada.ForeColor = SystemColors.Control;
            lblHoraLlegada.Location = new Point(231, 151);
            lblHoraLlegada.Name = "lblHoraLlegada";
            lblHoraLlegada.Size = new Size(20, 23);
            lblHoraLlegada.TabIndex = 12;
            lblHoraLlegada.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(41, 188);
            label6.Name = "label6";
            label6.Size = new Size(184, 23);
            label6.TabIndex = 13;
            label6.Text = "Tiempo Transcurrido";
            // 
            // lblTiempoTranscurrido
            // 
            lblTiempoTranscurrido.AutoSize = true;
            lblTiempoTranscurrido.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTiempoTranscurrido.ForeColor = SystemColors.Control;
            lblTiempoTranscurrido.Location = new Point(231, 188);
            lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            lblTiempoTranscurrido.Size = new Size(20, 23);
            lblTiempoTranscurrido.TabIndex = 14;
            lblTiempoTranscurrido.Text = "0";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeight = 40;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Precio });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(43, 336);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(716, 488);
            dgvProductos.TabIndex = 16;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n0";
            Precio.DefaultCellStyle = dataGridViewCellStyle2;
            Precio.FillWeight = 30F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // btnSumarItem
            // 
            btnSumarItem.BackColor = Color.White;
            btnSumarItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSumarItem.Image = (Image)resources.GetObject("btnSumarItem.Image");
            btnSumarItem.Location = new Point(785, 336);
            btnSumarItem.Name = "btnSumarItem";
            btnSumarItem.Size = new Size(142, 51);
            btnSumarItem.TabIndex = 17;
            btnSumarItem.UseVisualStyleBackColor = false;
            btnSumarItem.Click += btnSumarItem_Click;
            // 
            // btnRestarItem
            // 
            btnRestarItem.BackColor = Color.White;
            btnRestarItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestarItem.Image = (Image)resources.GetObject("btnRestarItem.Image");
            btnRestarItem.Location = new Point(785, 393);
            btnRestarItem.Name = "btnRestarItem";
            btnRestarItem.Size = new Size(142, 51);
            btnRestarItem.TabIndex = 18;
            btnRestarItem.UseVisualStyleBackColor = false;
            btnRestarItem.Click += btnRestarItem_Click;
            // 
            // btnEstadoMesa
            // 
            btnEstadoMesa.BackColor = Color.PaleGreen;
            btnEstadoMesa.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstadoMesa.ForeColor = Color.WhiteSmoke;
            btnEstadoMesa.Location = new Point(785, 31);
            btnEstadoMesa.Name = "btnEstadoMesa";
            btnEstadoMesa.Size = new Size(142, 58);
            btnEstadoMesa.TabIndex = 19;
            btnEstadoMesa.Text = "Abrir Mesa";
            btnEstadoMesa.UseVisualStyleBackColor = false;
            btnEstadoMesa.Click += btnEstadoMesa_Click_1;
            // 
            // dgvConsumo
            // 
            dgvConsumo.AllowUserToAddRows = false;
            dgvConsumo.AllowUserToDeleteRows = false;
            dgvConsumo.AllowUserToResizeColumns = false;
            dgvConsumo.AllowUserToResizeRows = false;
            dgvConsumo.BackgroundColor = Color.White;
            dgvConsumo.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvConsumo.ColumnHeadersHeight = 40;
            dgvConsumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsumo.Columns.AddRange(new DataGridViewColumn[] { Id2, Descripcion2, Precio2, Cantidad, Subtotal });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvConsumo.DefaultCellStyle = dataGridViewCellStyle9;
            dgvConsumo.EnableHeadersVisualStyles = false;
            dgvConsumo.Location = new Point(955, 336);
            dgvConsumo.MultiSelect = false;
            dgvConsumo.Name = "dgvConsumo";
            dgvConsumo.ReadOnly = true;
            dgvConsumo.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvConsumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvConsumo.RowHeadersVisible = false;
            dgvConsumo.RowTemplate.Height = 25;
            dgvConsumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsumo.Size = new Size(716, 488);
            dgvConsumo.TabIndex = 20;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n0";
            Precio2.DefaultCellStyle = dataGridViewCellStyle6;
            Precio2.FillWeight = 30F;
            Precio2.HeaderText = "Precio";
            Precio2.Name = "Precio2";
            Precio2.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "n0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle8;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblValorMesa);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblIdMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblHoraLlegada);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblTiempoTranscurrido);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(43, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 265);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Mesa";
            // 
            // lblValorMesa
            // 
            lblValorMesa.AutoSize = true;
            lblValorMesa.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorMesa.ForeColor = SystemColors.Control;
            lblValorMesa.Location = new Point(231, 77);
            lblValorMesa.Name = "lblValorMesa";
            lblValorMesa.Size = new Size(20, 23);
            lblValorMesa.TabIndex = 16;
            lblValorMesa.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(41, 74);
            label10.Name = "label10";
            label10.Size = new Size(107, 23);
            label10.TabIndex = 15;
            label10.Text = "Valor Mesa ";
            // 
            // lblTotalConsumido
            // 
            lblTotalConsumido.AutoSize = true;
            lblTotalConsumido.BackColor = SystemColors.InactiveCaptionText;
            lblTotalConsumido.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalConsumido.ForeColor = SystemColors.Control;
            lblTotalConsumido.Location = new Point(129, 215);
            lblTotalConsumido.Name = "lblTotalConsumido";
            lblTotalConsumido.RightToLeft = RightToLeft.Yes;
            lblTotalConsumido.Size = new Size(76, 23);
            lblTotalConsumido.TabIndex = 14;
            lblTotalConsumido.Text = "320.000";
            lblTotalConsumido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalMesa
            // 
            lblTotalMesa.AutoSize = true;
            lblTotalMesa.BackColor = SystemColors.InfoText;
            lblTotalMesa.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalMesa.ForeColor = SystemColors.Control;
            lblTotalMesa.Location = new Point(375, 215);
            lblTotalMesa.Name = "lblTotalMesa";
            lblTotalMesa.RightToLeft = RightToLeft.Yes;
            lblTotalMesa.Size = new Size(20, 23);
            lblTotalMesa.TabIndex = 17;
            lblTotalMesa.Text = "0";
            lblTotalMesa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnCancelarPagos);
            groupBox2.Controls.Add(btnPagar);
            groupBox2.Controls.Add(lblTotalMesa);
            groupBox2.Controls.Add(lblMontoPendiente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblTotalPagado);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dgvPagos);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblTotalConsumido);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(955, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(716, 265);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Venta";
            // 
            // btnCancelarPagos
            // 
            btnCancelarPagos.BackgroundImage = (Image)resources.GetObject("btnCancelarPagos.BackgroundImage");
            btnCancelarPagos.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelarPagos.FlatAppearance.BorderSize = 0;
            btnCancelarPagos.FlatStyle = FlatStyle.Flat;
            btnCancelarPagos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarPagos.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelarPagos.Location = new Point(602, 102);
            btnCancelarPagos.Name = "btnCancelarPagos";
            btnCancelarPagos.Size = new Size(94, 46);
            btnCancelarPagos.TabIndex = 36;
            btnCancelarPagos.UseVisualStyleBackColor = false;
            btnCancelarPagos.Click += btnCancelarPagos_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackgroundImage = (Image)resources.GetObject("btnPagar.BackgroundImage");
            btnPagar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = SystemColors.ActiveCaptionText;
            btnPagar.Location = new Point(602, 37);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(94, 46);
            btnPagar.TabIndex = 28;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Visible = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblMontoPendiente
            // 
            lblMontoPendiente.AutoSize = true;
            lblMontoPendiente.BackColor = SystemColors.InactiveCaptionText;
            lblMontoPendiente.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoPendiente.ForeColor = SystemColors.Control;
            lblMontoPendiente.Location = new Point(565, 175);
            lblMontoPendiente.Name = "lblMontoPendiente";
            lblMontoPendiente.Size = new Size(20, 23);
            lblMontoPendiente.TabIndex = 35;
            lblMontoPendiente.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(30, 215);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 28;
            label5.Text = "Consumo";
            // 
            // lblTotalPagado
            // 
            lblTotalPagado.AutoSize = true;
            lblTotalPagado.BackColor = SystemColors.InfoText;
            lblTotalPagado.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPagado.ForeColor = SystemColors.Control;
            lblTotalPagado.Location = new Point(375, 175);
            lblTotalPagado.Name = "lblTotalPagado";
            lblTotalPagado.Size = new Size(20, 23);
            lblTotalPagado.TabIndex = 34;
            lblTotalPagado.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(243, 215);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 27;
            label4.Text = "Mesa";
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.AllowUserToResizeColumns = false;
            dgvPagos.AllowUserToResizeRows = false;
            dgvPagos.BackgroundColor = Color.White;
            dgvPagos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle11.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvPagos.ColumnHeadersHeight = 25;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, PagoCon, vuelto });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvPagos.DefaultCellStyle = dataGridViewCellStyle15;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.Location = new Point(30, 37);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvPagos.RowHeadersVisible = false;
            dgvPagos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPagos.RowTemplate.Height = 25;
            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagos.Size = new Size(566, 126);
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
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "n0";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn3.FillWeight = 62.9159737F;
            dataGridViewTextBoxColumn3.HeaderText = "Monto";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PagoCon
            // 
            PagoCon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            PagoCon.DefaultCellStyle = dataGridViewCellStyle13;
            PagoCon.HeaderText = "Pago";
            PagoCon.Name = "PagoCon";
            PagoCon.ReadOnly = true;
            // 
            // vuelto
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "n0";
            vuelto.DefaultCellStyle = dataGridViewCellStyle14;
            vuelto.HeaderText = "Vuelto";
            vuelto.Name = "vuelto";
            vuelto.ReadOnly = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(243, 175);
            label12.Name = "label12";
            label12.Size = new Size(125, 23);
            label12.TabIndex = 33;
            label12.Text = "Total Pagado ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(462, 175);
            label18.Name = "label18";
            label18.Size = new Size(93, 23);
            label18.TabIndex = 26;
            label18.Text = "Pendiente";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.InactiveCaptionText;
            lblTotal.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(129, 175);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 23);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "999.999";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(30, 175);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 16;
            label7.Text = "Total ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnPararTiempo
            // 
            btnPararTiempo.BackColor = Color.Transparent;
            btnPararTiempo.BackgroundImage = (Image)resources.GetObject("btnPararTiempo.BackgroundImage");
            btnPararTiempo.BackgroundImageLayout = ImageLayout.Center;
            btnPararTiempo.Enabled = false;
            btnPararTiempo.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPararTiempo.ForeColor = Color.Cyan;
            btnPararTiempo.Location = new Point(785, 114);
            btnPararTiempo.Name = "btnPararTiempo";
            btnPararTiempo.Size = new Size(142, 85);
            btnPararTiempo.TabIndex = 25;
            btnPararTiempo.UseVisualStyleBackColor = false;
            btnPararTiempo.Click += btnPararTiempo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(43, 293);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(549, 33);
            txtBuscar.TabIndex = 26;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // MesaDetalleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1717, 845);
            Controls.Add(txtBuscar);
            Controls.Add(btnPararTiempo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvConsumo);
            Controls.Add(btnEstadoMesa);
            Controls.Add(btnRestarItem);
            Controls.Add(btnSumarItem);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MesaDetalleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DETALLE VENTA MESA";
            Load += MesaDetalleForm_Load;
            Paint += MesaDetalleForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsumo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblIdMesa;
        private Label label2;
        private Label lblEstado;
        private Label label3;
        private Label lblHoraLlegada;
        private Label label6;
        private Label lblTiempoTranscurrido;
        private DataGridView dgvProductos;
        private Button btnSumarItem;
        private Button btnRestarItem;
        private Button btnEstadoMesa;
        private DataGridView dgvConsumo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblTotalConsumido;
        private Label lblValorMesa;
        private Label label10;
        private Label lblTotal;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Label lblTotalMesa;
        private Label label18;
        private Button btnPagar;
        private Label label12;
        private DataGridView dgvPagos;
        private Label lblTotalPagado;
        private Label lblMontoPendiente;
        private Button btnPararTiempo;
        private TextBox txtBuscar;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Id2;
        private DataGridViewTextBoxColumn Descripcion2;
        private DataGridViewTextBoxColumn Precio2;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn PagoCon;
        private DataGridViewTextBoxColumn vuelto;
        private Button btnCancelarPagos;
    }
}