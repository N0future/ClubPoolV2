using Billar.Context;
using Billar.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Billar
{
    public partial class MesaEditForm : Form
    {
        private readonly ClubPoolContext context = new ClubPoolContext();
        public int IdMesa { get; set; }

        public MesaEditForm(int idMesa)
        {
            InitializeComponent();
            IdMesa = idMesa;
        }

        private void MesaEditForm_Load(object sender, EventArgs e)
        {
            // Asociar los eventos KeyPress
            txtPrecioHora.KeyPress += Utils.SoloNumeros;
            txtPrecioMinimo.KeyPress += Utils.SoloNumeros;

            // Cargar datos de la mesa
            CargarDatosMesa();
        }

        private void CargarDatosMesa()
        {
            try
            {
                using (var context = new ClubPoolContext())
                {
                    Mesa mesa = context.Mesa.SingleOrDefault(m => m.Id == IdMesa);
                    if (mesa != null)
                    {
                        txtPrecioHora.Text = mesa.Precio.ToString("n0");
                        txtPrecioMinimo.Text = mesa.PrecioMin.ToString("n0");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la mesa especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de la mesa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarCambios();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtPrecioHora.Text))
            {
                MessageBox.Show("El precio por hora no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioMinimo.Text))
            {
                MessageBox.Show("El precio mínimo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void GuardarCambios()
        {
            try
            {
                using (var context = new ClubPoolContext())
                {
                    Mesa mesa = context.Mesa.SingleOrDefault(m => m.Id == IdMesa);

                    if (mesa != null)
                    {
                        // Actualizar los valores de la mesa
                        mesa.Precio = Convert.ToInt32(txtPrecioHora.Text.Replace(".", ""));
                        mesa.PrecioMin = Convert.ToInt32(txtPrecioMinimo.Text.Replace(".", ""));

                        // Guardar los cambios en la base de datos
                        context.SaveChanges();
                        MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cerrar el formulario con éxito
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la mesa especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
