namespace Billar
{
    partial class DetalleAperturaCierreForm
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dgvAperturasYCierres = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha_Apertura = new DataGridViewTextBoxColumn();
            Fecha_Cierre = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            MontoInicio = new DataGridViewTextBoxColumn();
            MontoFinal = new DataGridViewTextBoxColumn();
            TotalVentasEfectivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAperturasYCierres).BeginInit();
            SuspendLayout();
            // 
            // dgvAperturasYCierres
            // 
            dgvAperturasYCierres.AllowUserToAddRows = false;
            dgvAperturasYCierres.AllowUserToDeleteRows = false;
            dgvAperturasYCierres.AllowUserToResizeColumns = false;
            dgvAperturasYCierres.AllowUserToResizeRows = false;
            dgvAperturasYCierres.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAperturasYCierres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAperturasYCierres.ColumnHeadersHeight = 40;
            dgvAperturasYCierres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAperturasYCierres.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha_Apertura, Fecha_Cierre, NombreUsuario, MontoInicio, MontoFinal, TotalVentasEfectivo });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvAperturasYCierres.DefaultCellStyle = dataGridViewCellStyle8;
            dgvAperturasYCierres.EnableHeadersVisualStyles = false;
            dgvAperturasYCierres.Location = new Point(24, 55);
            dgvAperturasYCierres.MultiSelect = false;
            dgvAperturasYCierres.Name = "dgvAperturasYCierres";
            dgvAperturasYCierres.ReadOnly = true;
            dgvAperturasYCierres.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvAperturasYCierres.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvAperturasYCierres.RowHeadersVisible = false;
            dgvAperturasYCierres.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAperturasYCierres.RowTemplate.Height = 25;
            dgvAperturasYCierres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAperturasYCierres.Size = new Size(1345, 645);
            dgvAperturasYCierres.TabIndex = 19;
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
            // Fecha_Apertura
            // 
            Fecha_Apertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha_Apertura.DataPropertyName = "Fecha_Apertura";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fecha_Apertura.DefaultCellStyle = dataGridViewCellStyle2;
            Fecha_Apertura.FillWeight = 30F;
            Fecha_Apertura.HeaderText = "Fecha Apertura";
            Fecha_Apertura.Name = "Fecha_Apertura";
            Fecha_Apertura.ReadOnly = true;
            // 
            // Fecha_Cierre
            // 
            Fecha_Cierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha_Cierre.DataPropertyName = "Fecha_Cierre";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fecha_Cierre.DefaultCellStyle = dataGridViewCellStyle3;
            Fecha_Cierre.FillWeight = 30F;
            Fecha_Cierre.HeaderText = "Fecha Cierre";
            Fecha_Cierre.Name = "Fecha_Cierre";
            Fecha_Cierre.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreUsuario.DataPropertyName = "NombreUsuario";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            NombreUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            NombreUsuario.FillWeight = 25F;
            NombreUsuario.HeaderText = "Usuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // MontoInicio
            // 
            MontoInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoInicio.DataPropertyName = "MontoInicio";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n0";
            MontoInicio.DefaultCellStyle = dataGridViewCellStyle5;
            MontoInicio.FillWeight = 25F;
            MontoInicio.HeaderText = "Monto Inicio";
            MontoInicio.Name = "MontoInicio";
            MontoInicio.ReadOnly = true;
            // 
            // MontoFinal
            // 
            MontoFinal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoFinal.DataPropertyName = "MontoFinal";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n0";
            MontoFinal.DefaultCellStyle = dataGridViewCellStyle6;
            MontoFinal.FillWeight = 25F;
            MontoFinal.HeaderText = "Monto Final";
            MontoFinal.Name = "MontoFinal";
            MontoFinal.ReadOnly = true;
            // 
            // TotalVentasEfectivo
            // 
            TotalVentasEfectivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalVentasEfectivo.DataPropertyName = "TotalVentasEfectivo";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n0";
            TotalVentasEfectivo.DefaultCellStyle = dataGridViewCellStyle7;
            TotalVentasEfectivo.FillWeight = 25F;
            TotalVentasEfectivo.HeaderText = "Ventas Efectivo";
            TotalVentasEfectivo.Name = "TotalVentasEfectivo";
            TotalVentasEfectivo.ReadOnly = true;
            // 
            // DetalleAperturaCierreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1393, 724);
            Controls.Add(dgvAperturasYCierres);
            Name = "DetalleAperturaCierreForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetalleAperturaCierreForm";
            Load += DetalleAperturaCierreForm_Load;
            Paint += DetalleAperturaCierreForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvAperturasYCierres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAperturasYCierres;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha_Apertura;
        private DataGridViewTextBoxColumn Fecha_Cierre;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn MontoInicio;
        private DataGridViewTextBoxColumn MontoFinal;
        private DataGridViewTextBoxColumn TotalVentasEfectivo;
    }
}