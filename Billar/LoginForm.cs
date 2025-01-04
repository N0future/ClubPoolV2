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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new ClubPoolContext())
            {
                // Buscar el usuario en la base de datos
                var usuarioEncontrado = context.Usuario
                    .FirstOrDefault(u => u.NombreUsuario == usuario && u.Password == password && u.Estado == true);

                // Si se encuentra el usuario y está activo (Estado = true)
                if (usuarioEncontrado != null)
                {
                    // Mostrar el MainForm y ocultar la ventana de login
                    MainForm mainForm = new MainForm(usuarioEncontrado.Id, usuarioEncontrado.Nombre);
                    mainForm.Show();
                    this.Hide(); // Ocultar la ventana de login

                    //// Si es necesario, puedes pasar información del usuario al MainForm, como el nombre.
                    //mainForm.SetUsuarioActual(usuarioEncontrado.Nombre + " " + usuarioEncontrado.Apellido);
                }
                else
                {
                    // Mostrar un mensaje de error si el login falla
                    MessageBox.Show("Usuario o contraseña incorrecta, o el usuario está inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
