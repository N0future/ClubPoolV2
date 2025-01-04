using Billar.Context;
using Billar.Models;
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
    public partial class AgregarProductoForm : Form
    {

        public int selectedProductId;
        public AgregarProductoForm(int productId)
        {
            selectedProductId = productId;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Validaciones de los campos
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ClubPoolContext())
            {
                // Verificar si es una inserción o una actualización
                if (selectedProductId == 0)
                {
                    // Crear un nuevo producto
                    Producto nuevoProducto = new Producto
                    {
                        Descripcion = txtDescripcion.Text.Trim(),
                        Precio = Convert.ToInt32(precio),
                        Codigo = txtCodigo.Text.Trim(),
                        Cantidad = cantidad,
                        Estado = true
                    };

                    // Agregar el nuevo producto al contexto
                    context.Producto.Add(nuevoProducto);
                    MessageBox.Show("Producto agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizar el producto existente
                    var productoExistente = context.Producto.Find(selectedProductId);
                    if (productoExistente != null)
                    {
                        productoExistente.Descripcion = txtDescripcion.Text.Trim();
                        productoExistente.Precio = Convert.ToInt32(precio);
                        productoExistente.Codigo = txtCodigo.Text.Trim();
                        productoExistente.Cantidad = cantidad;
                        productoExistente.Estado = true;

                        MessageBox.Show("Producto actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Guardar los cambios en la base de datos
                context.SaveChanges();
            }


        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
        void cargarDataEditar()
        {
            using (var context = new ClubPoolContext())
            {
                // Obtener los productos de la base de datos
                var producto = context.Producto.ToList().Where(p=>p.Id == selectedProductId).FirstOrDefault();

                txtPrecio.Text = Convert.ToString(producto.Precio);
                txtDescripcion.Text = Convert.ToString(producto.Descripcion);
                txtCantidad.Text = Convert.ToString(producto.Cantidad);
                txtCodigo.Text = Convert.ToString(producto.Codigo);
            }
        }
        private void AgregarProductoForm_Load(object sender, EventArgs e)
        {

            if (selectedProductId != 0)
            {
                cargarDataEditar();
            }

            txtCantidad.KeyPress += Utils.SoloNumeros;
            txtPrecio.KeyPress += Utils.SoloNumeros;
        }
    }
}
