namespace Billar
{
    partial class DetalleVentaReporteForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvAperturasYCierres = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
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
            dgvAperturasYCierres.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAperturasYCierres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAperturasYCierres.ColumnHeadersHeight = 40;
            dgvAperturasYCierres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAperturasYCierres.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Cantidad, Precio, Subtotal, Fecha });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvAperturasYCierres.DefaultCellStyle = dataGridViewCellStyle7;
            dgvAperturasYCierres.EnableHeadersVisualStyles = false;
            dgvAperturasYCierres.Location = new Point(38, 25);
            dgvAperturasYCierres.MultiSelect = false;
            dgvAperturasYCierres.Name = "dgvAperturasYCierres";
            dgvAperturasYCierres.ReadOnly = true;
            dgvAperturasYCierres.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvAperturasYCierres.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvAperturasYCierres.RowHeadersVisible = false;
            dgvAperturasYCierres.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAperturasYCierres.RowTemplate.Height = 25;
            dgvAperturasYCierres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAperturasYCierres.Size = new Size(952, 578);
            dgvAperturasYCierres.TabIndex = 18;
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
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            Descripcion.FillWeight = 30F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            Cantidad.FillWeight = 30F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n0";
            Precio.DefaultCellStyle = dataGridViewCellStyle4;
            Precio.FillWeight = 25F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle5;
            Subtotal.FillWeight = 25F;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            Fecha.DefaultCellStyle = dataGridViewCellStyle6;
            Fecha.FillWeight = 25F;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // DetalleVentaReporteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1022, 624);
            Controls.Add(dgvAperturasYCierres);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetalleVentaReporteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetalleVentaReporteForm";
            Paint += DetalleVentaReporteForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvAperturasYCierres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAperturasYCierres;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Fecha;
    }
}