namespace Billar
{
    partial class MesasForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesasForm));
            dgvMesas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            PrecioMin = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMesas).BeginInit();
            SuspendLayout();
            // 
            // dgvMesas
            // 
            dgvMesas.AllowUserToAddRows = false;
            dgvMesas.AllowUserToDeleteRows = false;
            dgvMesas.AllowUserToResizeColumns = false;
            dgvMesas.AllowUserToResizeRows = false;
            dgvMesas.BackgroundColor = Color.White;
            dgvMesas.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMesas.ColumnHeadersHeight = 40;
            dgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMesas.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Precio, PrecioMin });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvMesas.DefaultCellStyle = dataGridViewCellStyle7;
            dgvMesas.EnableHeadersVisualStyles = false;
            dgvMesas.Location = new Point(45, 133);
            dgvMesas.MultiSelect = false;
            dgvMesas.Name = "dgvMesas";
            dgvMesas.ReadOnly = true;
            dgvMesas.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvMesas.RowHeadersVisible = false;
            dgvMesas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMesas.RowTemplate.Height = 25;
            dgvMesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMesas.Size = new Size(692, 488);
            dgvMesas.TabIndex = 17;
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
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle6.Format = "n0";
            Precio.DefaultCellStyle = dataGridViewCellStyle6;
            Precio.FillWeight = 50F;
            Precio.HeaderText = "Precio Hora";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // PrecioMin
            // 
            PrecioMin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrecioMin.DataPropertyName = "PrecioMin";
            PrecioMin.FillWeight = 50F;
            PrecioMin.HeaderText = "Precio Minimo";
            PrecioMin.Name = "PrecioMin";
            PrecioMin.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(603, 44);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 73);
            btnEditar.TabIndex = 21;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(45, 60);
            label2.Name = "label2";
            label2.Size = new Size(88, 33);
            label2.TabIndex = 23;
            label2.Text = "Mesas";
            // 
            // MesasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(840, 694);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(dgvMesas);
            Name = "MesasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesas";
            Load += Mesas_Load;
            Paint += MesasForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvMesas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMesas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn PrecioMin;
        private Button btnEditar;
        private Label label2;
    }
}