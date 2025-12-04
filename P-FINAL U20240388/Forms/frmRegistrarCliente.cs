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
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }


        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            //Validar que solo se ingresen numeros
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodigoCliente.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor ingrese solo números en el campo Código Cliente.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoCliente.Text = string.Empty;
            }

            //Limitar a 8 caracteres
            if (txtCodigoCliente.Text.Length > 8)
            {
                MessageBox.Show("El Código Cliente no puede exceder los 8 caracteres.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoCliente.Text = txtCodigoCliente.Text.Substring(0, 8);
            }

            //Colocar el cursor al final del texto
            txtCodigoCliente.SelectionStart = txtCodigoCliente.Text.Length;

            //Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text))
            {
                MessageBox.Show("El campo Código Cliente no puede estar vacío.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Verificar que el codigo no haya sido registrado previamente
            if (txtCodigoCliente.Text == "12345678") // Simulación de código ya registrado
            {
                MessageBox.Show("El Código Cliente ya ha sido registrado previamente. Por favor ingrese uno nuevo", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //El codigo 0 pertenercera a clientes varios
            if (txtCodigoCliente.Text == "0")
            {
                MessageBox.Show("El código 0 está reservado para clientes varios y no puede ser utilizado.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txtDUICliente_TextChanged(object sender, EventArgs e)
        {
            //Validar que solo ingresen numeros
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDUICliente.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor ingrese solo números en el campo DUI Cliente.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDUICliente.Text = string.Empty;
            }
            //Limitar a 9 caracteres
            if (txtDUICliente.Text.Length > 9)
            {
                MessageBox.Show("El DUI Cliente no puede exceder los 9 caracteres.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDUICliente.Text = txtDUICliente.Text.Substring(0, 9);
            }
            //Colocar el cursor al final del texto
            txtDUICliente.SelectionStart = txtDUICliente.Text.Length;
            //Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtDUICliente.Text))
            {
                MessageBox.Show("El campo DUI Cliente no puede estar vacío.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Despues de 8 caracteres, agregar un guion automaticamente
            if (txtDUICliente.Text.Length == 8 && !txtDUICliente.Text.Contains("-"))
            {
                txtDUICliente.Text += "-";
                txtDUICliente.SelectionStart = txtDUICliente.Text.Length;
            }
            //Verificar que el DUI no haya sido registrado previamente
            if (txtDUICliente.Text == "987654321") // Simulación de DUI ya registrado
            {
                MessageBox.Show("El DUI Cliente ya ha sido registrado previamente. Por favor ingrese uno nuevo", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnGuardar10_Click(object sender, EventArgs e)
        {
            //Validar que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txtCodigoCliente.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(txtDUICliente.Text))

            {
                MessageBox.Show("Por favor complete todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Simular guardado exitoso
            MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Limpiar los campos despues de guardar
            txtCodigoCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtDUICliente.Text = string.Empty;
            

        }
    }
}
