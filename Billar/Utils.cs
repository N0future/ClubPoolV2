using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace Billar
{
    public static class Utils
    {
        public static void ValidarYFormatear(TextBox textBox)
        {
            // Si el campo está vacío o contiene solo ceros, limpiar el campo
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "0" || textBox.Text.StartsWith("00"))
            {
                textBox.Text = string.Empty;
                return;
            }

            // Intentar convertir el valor ingresado a un número entero
            if (int.TryParse(textBox.Text.TrimStart('0'), out int valor))
            {
                // Si el valor es válido, formatearlo con separadores de miles (n0)
                textBox.Text = valor.ToString("n0");
            }
            else
            {
                // Si la conversión falla, limpiar el campo
                textBox.Text = string.Empty;
            }
        }


        public static void SetBackground(Form form, PaintEventArgs e, Color colorInicio, Color colorFin, float angle = 65f)
        {
            Graphics graphics = e.Graphics;

            // Definimos el rectángulo que será del tamaño del formulario
            Rectangle gradientRectangle = new Rectangle(0, 0, form.Width, form.Height);

            // Creamos un pincel de degradado lineal
            using (Brush b = new LinearGradientBrush(gradientRectangle, colorInicio, colorFin, angle))
            {
                // Aplicamos el degradado
                graphics.FillRectangle(b, gradientRectangle);
            }
        }

        public static void FormatearMiles(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text)) return;

            // Guarda la posición del cursor
            int selectionStart = txt.SelectionStart;

            // Elimina puntos existentes y convierte a número
            string numeroSinFormato = txt.Text.Replace(".", "");
            if (int.TryParse(numeroSinFormato, out int numero))
            {
                // Formatea el número con separadores de miles
                txt.Text = numero.ToString("N0");

                // Restaura la posición del cursor
                txt.SelectionStart = txt.Text.Length;
            }
        }
        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si no es un número o la tecla de retroceso, cancelar la tecla
            }
        }

    



    }
}
