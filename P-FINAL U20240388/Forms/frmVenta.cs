using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_FINAL_U20240388.Forms
{
    public partial class frmVenta : Form
    {
        private TextBox txtNombreCliente;


        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo2_TextChanged(object sender, EventArgs e)
        {
            //Validar que solo se ingresen numeros
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodigo2.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor ingrese solo números en el campo Código Producto.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo2.Text = string.Empty;
            }
            //Buscar el producto por su código y mostrar su información en los campos correspondientes

            if (txtCodigo2.Text == "1001") // Simulación de búsqueda de producto
            {
                txtNombreCliente2.Text = "Producto de Ejemplo";
                txtCategoria2.Text = "Categoría de Ejemplo";
                txtPrecioUnitario2.Text = "50.00";
                txtCantidad2.Text = "10";
            }
            else
            {
                txtNombreCliente2.Text = string.Empty;
                txtCategoria2.Text = string.Empty;
                txtPrecioUnitario2.Text = string.Empty;
                txtCantidad2.Text = string.Empty;
            }

            //Colocar el cursor al final del texto
            txtCodigo2.SelectionStart = txtCodigo2.Text.Length;

            //Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtCodigo2.Text))
            {
                MessageBox.Show("El campo Código Producto no puede estar vacío.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtPrecioUnitario2_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo se ingresen números y un punto decimal
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrecioUnitario2.Text, @"^\d*\.?\d*$"))
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido en el campo Precio Unitario.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnitario2.Text = string.Empty;
            }
            // Colocar el cursor al final del texto
            txtPrecioUnitario2.SelectionStart = txtPrecioUnitario2.Text.Length;
            // Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtPrecioUnitario2.Text))
            {
                MessageBox.Show("El campo Precio Unitario no puede estar vacío.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Verificar que el precio unitario no sea negativo
            if (decimal.TryParse(txtPrecioUnitario2.Text, out decimal precioUnitario) && precioUnitario < 0)
            {
                MessageBox.Show("El Precio Unitario no puede ser negativo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnitario2.Text = string.Empty;
            }

            // Colocar el cursor al final del texto nuevamente
            txtPrecioUnitario2.SelectionStart = txtPrecioUnitario2.Text.Length;

            // Verificar que el precio unitario no exceda un valor razonable (por ejemplo, 10000)
            if (decimal.TryParse(txtPrecioUnitario2.Text, out decimal precioUnitarioMax) && precioUnitarioMax > 10000)
            {
                MessageBox.Show("El Precio Unitario no puede exceder de 10,000.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnitario2.Text = string.Empty;
            }


        }

        private void btnAgregaraVenta_Click(object sender, EventArgs e)
        {
            // Lógica para agregar el producto a la venta
            MessageBox.Show("Producto agregado a la venta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Limpiar los campos después de agregar
            txtCodigo2.Text = string.Empty;
            txtNombreCliente2.Text = string.Empty;
            txtCategoria2.Text = string.Empty;
            txtPrecioUnitario2.Text = string.Empty;
            txtCantidad2.Text = string.Empty;

            // Colocar el cursor en el campo Código Producto
            txtCodigo2.Focus();
            

           






        }

        private void btnGrabaryTransmitir_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente2_TextChanged(object sender, EventArgs e)
        {
            // No permitir la edición del campo Nombre Cliente
            txtNombreCliente2.ReadOnly = true;
            txtCategoria2.ReadOnly = true;
            txtPrecioUnitario2.ReadOnly = true;

            txtCantidad2.ReadOnly = true;
            txtCodigo2.ReadOnly = true;
            txtPrecioUnitario2.ReadOnly = true;

            // Colocar el cursor al final del texto
            txtCantidad2.ReadOnly = true;
            txtCodigo2.ReadOnly = true;
            txtPrecioUnitario2.ReadOnly = true; txtCantidad2.ReadOnly = true;

        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            //Validar que solo se ingresen numeros
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodCliente.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor ingrese solo números en el campo Código Cliente.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCliente.Text = string.Empty;
            }
            //Colocar el cursor al final del texto
            txtCodCliente.SelectionStart = txtCodCliente.Text.Length;
            //Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                MessageBox.Show("El campo Código Cliente no puede estar vacío.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Si el codigo ya existe, mostrar el nombre del cliente y sus datos
            if (txtCodCliente.Text == "2001") // Simulación de búsqueda de cliente
            {
                txtNombreCliente.Text = "Cliente de Ejemplo";
            }
            else
            {
                txtNombreCliente.Text = string.Empty;

            }

        }
        private void txtPrecioTotal_TextChanged(object sender, EventArgs e)
        {
            // No permitir la edición del campo Precio Total
            txtPrecioTotal.ReadOnly = true;
            //Precio total será igual a precio unitario por cantidad
            if (decimal.TryParse(txtPrecioUnitario2.Text, out decimal precioUnitario) &&
                int.TryParse(txtCantidad2.Text, out int cantidad))
            {
                decimal precioTotal = precioUnitario * cantidad;
                txtPrecioTotal.Text = precioTotal.ToString("F2");
            }
            else
            {
                txtPrecioTotal.Text = "0.00";
            }

            txtPrecioTotal.ReadOnly = false;

            // Colocar el cursor al final del texto
            txtPrecioTotal.SelectionStart = txtPrecioTotal.Text.Length;






        }








        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar3_Click(object sender, EventArgs e)
        {
            //Limpiar los campos del formulario y mostrar mensaje de cancelación

            txtCodCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtCodigo2.Text = string.Empty;
            txtNombreCliente2.Text = string.Empty;
            txtPrecioTotal.ReadOnly = false;
            txtCategoria2.Text = string.Empty;
            txtPrecioUnitario2.Text = string.Empty;
            txtCantidad2.Text = string.Empty;
            MessageBox.Show("Operación cancelada. Los campos han sido limpiados.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}