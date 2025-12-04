using LAB3_U20240388.Repositorios;
using P_FINAL_U20240388.Clases;
using P_FINAL_U20240388.Forms;
using P_FINAL_U20240388.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_FINAL_U20240388.Forms
{
    public partial class frmRegistrarProducto : Form
    {
        private readonly ProductosRepository _productosRepository;
        private readonly string _connectionString;

        public frmRegistrarProducto()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
            _productosRepository = new ProductosRepository(_connectionString);

            txtPrecioUnitario.KeyPress += TxtNumericoDecimal_KeyPress;
            txtCantidad.KeyPress += TxtNumericoEntero_KeyPress;
        }

               private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarProductos();

        }

       //  Click  Boton Guardar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObligatorios())
            {
                return;
            }

            try
            {
                decimal precio = decimal.Parse(txtPrecioUnitario.Text, CultureInfo.CurrentCulture);
                int cantidad = int.Parse(txtCantidad.Text);
                Productos nuevoProducto = new Productos
                {
                    Nombre = txtNombre.Text.Trim(),
                    Codigo = txtCodigo.Text.Trim(),
                    Categoria = txtCategoria.Text.Trim(),
                    PrecioUnitario = precio,
                    Cantidad = cantidad,

                };
                _productosRepository.AgregarProducto(nuevoProducto);

                MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
                CargarProductos();
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato de precio o cantidad es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Doble click en Datagridview
        private void dgvRegistro0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //No toma en cuenta el encabezado
            if (e.RowIndex < 0 || e.RowIndex >= dgvRegistro0.Rows.Count - 1)
            {
                return;
            }
            DataGridViewRow row = dgvRegistro0.Rows[e.RowIndex];
            
            try
            {
                Productos productoSeleccionado = new Productos
                {

                    IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    Codigo = row.Cells["Codigo"].Value.ToString(),
                    Categoria = row.Cells["Categoria"].Value?.ToString() ?? string.Empty,
                    PrecioUnitario = decimal.Parse(row.Cells["PrecioUnitario"].Value.ToString()),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                };
                frmRegistrarProductoCmd formEdicion = new frmRegistrarProductoCmd(productoSeleccionado);


                formEdicion.ShowDialog();


                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto seleccionado para Edicion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validacion 

        private void CargarProductos()
        {
            try
            {
                DataTable productos = _productosRepository.ObtenerTodos();
                dgvRegistro0.DataSource = productos;
                ResaltarBajoStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de productos: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void ResaltarBajoStock()
        {
            // Umbral fijo para el stock bajo
            const int UMBRAL_STOCK_MINIMO = 10;

            if (dgvRegistro0.Rows.Count == 0 || dgvRegistro0.Columns.Count == 0) return;

            // Si la columna 'Cantidad' o 'Stock' no existe, sal del método
            if (!dgvRegistro0.Columns.Contains("Cantidad") && !dgvRegistro0.Columns.Contains("Stock")) return;

            foreach (DataGridViewRow row in dgvRegistro0.Rows)
            {
                if (row.IsNewRow) continue;

                // Declaración única de la variable que contendrá el valor
                int cantidadEnStock;

                // Intentar obtener el valor de la columna "Cantidad" (o "Stock", dependiendo de tu nombre final)
                if (int.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidadEnStock))
                {
                    // Compara la cantidad del producto con el umbral fijo
                    if (cantidadEnStock < UMBRAL_STOCK_MINIMO)
                    {
                        // Resalta la fila en color coral (rojo suave)
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    }
                    else
                    {
                        // Restablece los colores por defecto
                        row.DefaultCellStyle.BackColor = dgvRegistro0.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.SelectionBackColor = dgvRegistro0.DefaultCellStyle.SelectionBackColor;
                    }
                }
                // Si no puede parsear el valor (no es un número), simplemente no hace nada.
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtCodigo.Text) ||
               string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) ||
               string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Los campos Nombre, Codigo, Precio Unitario y Cantidad son obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtPrecioUnitario.Clear();
            txtCantidad.Clear();
            txtNombre.Focus();
        }

        // Validacion para campos enteros 

        private void TxtNumericoEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // validacion para campos decimales

        private void TxtNumericoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (e.KeyChar.ToString() == decimalSeparator)
            {

                if (!((TextBox)sender).Text.Contains(decimalSeparator))
                {
                    e.Handled = false;
                    return;
                }
            }

            e.Handled = true;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario y mostrar mensaje de cancelación
            LimpiarControles();
            MessageBox.Show("Registro de producto cancelado.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de edición de productos y mostrar mensaje de traslado a edicion
            frmRegistrarProductoCmd formEdicion = new frmRegistrarProductoCmd();
            formEdicion.ShowDialog();
            MessageBox.Show("Trasladando al formulario de edición de productos.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }
    }
}
