namespace Billar
{
    partial class TiempoForm
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
            pickerTiempo = new DateTimePicker();
            btnConfirmar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbPersonalizada = new RadioButton();
            rbHoraActual = new RadioButton();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pickerTiempo
            // 
            pickerTiempo.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pickerTiempo.Format = DateTimePickerFormat.Time;
            pickerTiempo.Location = new Point(115, 31);
            pickerTiempo.Name = "pickerTiempo";
            pickerTiempo.ShowUpDown = true;
            pickerTiempo.Size = new Size(210, 23);
            pickerTiempo.TabIndex = 19;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(55, 248);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(213, 74);
            btnConfirmar.TabIndex = 20;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pickerTiempo);
            groupBox1.Location = new Point(55, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 76);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbPersonalizada);
            groupBox2.Controls.Add(rbHoraActual);
            groupBox2.Location = new Point(55, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 100);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // rbPersonalizada
            // 
            rbPersonalizada.AutoSize = true;
            rbPersonalizada.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbPersonalizada.ForeColor = Color.White;
            rbPersonalizada.Location = new Point(235, 37);
            rbPersonalizada.Name = "rbPersonalizada";
            rbPersonalizada.Size = new Size(195, 29);
            rbPersonalizada.TabIndex = 1;
            rbPersonalizada.TabStop = true;
            rbPersonalizada.Text = "Hora personalizada";
            rbPersonalizada.UseVisualStyleBackColor = true;
            rbPersonalizada.CheckedChanged += rbPersonalizada_CheckedChanged;
            // 
            // rbHoraActual
            // 
            rbHoraActual.AutoSize = true;
            rbHoraActual.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbHoraActual.ForeColor = Color.White;
            rbHoraActual.Location = new Point(30, 37);
            rbHoraActual.Name = "rbHoraActual";
            rbHoraActual.Size = new Size(132, 29);
            rbHoraActual.TabIndex = 0;
            rbHoraActual.TabStop = true;
            rbHoraActual.Text = "Hora Actual";
            rbHoraActual.UseVisualStyleBackColor = true;
            rbHoraActual.CheckedChanged += rbHoraActual_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(301, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(213, 74);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TiempoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(566, 363);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnConfirmar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TiempoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmar";
            Load += TiempoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker pickerTiempo;
        private Button btnConfirmar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbPersonalizada;
        private RadioButton rbHoraActual;
        private Button btnCancelar;
    }
}