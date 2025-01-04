using Billar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billar
{
    public partial class MesasForm : Form
    {
        public ClubPoolContext context = new ClubPoolContext();

        public MesasForm()
        {
            InitializeComponent();
        }



        void CargarData()
        {
            using (var context = new ClubPoolContext())
            {
                // Obtener los productos de la base de datos
                var mesas = context.Mesa.ToList();
                // Asignar los productos al DataGridView
                dgvMesas.AutoGenerateColumns = false;
                dgvMesas.DataSource = mesas;


            }
        }
        private void Mesas_Load(object sender, EventArgs e)
        {
            CargarData();
        }

      

        private void MesasForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvMesas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvMesas.SelectedRows[0];

                // Obtener los valores actuales del Precio Hora y Precio Minimo
                int IdMesa = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);


                // Abrir la ventana de edición
                MesaEditForm editarMesaForm = new MesaEditForm(IdMesa);

                // Mostrar el formulario y esperar a que se cierre
                if (editarMesaForm.ShowDialog() == DialogResult.OK)
                {
                    CargarData();
                    //// Actualizar los valores de la fila seleccionada
                    //filaSeleccionada.Cells["PrecioHora"].Value = editarMesaForm.PrecioHora;
                    //filaSeleccionada.Cells["PrecioMinimo"].Value = editarMesaForm.PrecioMinimo;

                    //// Opcional: Aquí puedes guardar los cambios en la base de datos si es necesario
                    //MessageBox.Show("Datos actualizados correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una mesa para editar.");
            }
        }
    }
}
