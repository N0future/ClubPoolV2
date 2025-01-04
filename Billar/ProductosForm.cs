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
    public partial class ProductosForm : Form
    {
        public ClubPoolContext context = new ClubPoolContext();

        public ProductosForm()
        {
            InitializeComponent();
            CargarData();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm(0);
            agregarProductoForm.ShowDialog();
            CargarData();

        }

        int ObtenerProductoSeleccionado()
        {
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = dgvProducto.CurrentRow;

            // Obtener el Id del producto desde la celda "Id"
            int idProducto = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            return idProducto;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var Id = ObtenerProductoSeleccionado();
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm(Id);
            agregarProductoForm.ShowDialog();
            CargarData();
        }
        void CargarData()
        {
            using (var context = new ClubPoolContext())
            {
                // Obtener los productos de la base de datos
                var productos = context.Producto.Where(p => p.Estado == true).ToList();
                // Asignar los productos al DataGridView
                dgvProducto.AutoGenerateColumns = false;
                dgvProducto.DataSource = productos;


            }
        }
        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el Id del producto seleccionado
            int idProducto = ObtenerProductoSeleccionado();

            if (idProducto != -1)
            {
                // Confirmar si el usuario realmente quiere eliminar el producto
                DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                             "Confirmar Eliminación",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var context = new ClubPoolContext())
                    {
                        // Buscar el producto por Id
                        var producto = context.Producto.SingleOrDefault(p => p.Id == idProducto);

                        if (producto != null)
                        {
                            // Cambiar el estado del producto a false (o 0)
                            producto.Estado = false;

                            // Guardar los cambios en la base de datos
                            context.SaveChanges();

                            MessageBox.Show("Producto eliminado correctamente.");

                            // Actualizar la lista de productos en el DataGridView después de eliminar
                            CargarData();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower(); // Convertir a minúsculas para búsqueda insensible a mayúsculas

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {

                CargarData();
            }
            else
            {

                using (var context = new ClubPoolContext())
                {
                    // Obtener los productos de la base de datos
                    var productos = context.Producto.Where(p => p.Descripcion.ToLower().Contains(textoBusqueda) ||
                                p.Codigo.ToLower().Contains(textoBusqueda)) // Puedes agregar más condiciones aquí si es necesario
                    .ToList();


                    // Asignar los productos al DataGridView
                    dgvProducto.AutoGenerateColumns = false;
                    dgvProducto.DataSource = productos;
                }



            }
        }

        private void ProductosForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }
    }
}
