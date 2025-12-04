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
    public partial class frmRegistrarProductoCmd : Form

    {

        public frmRegistrarProductoCmd()
        {
            InitializeComponent();
        }

        public frmRegistrarProductoCmd(Clases.Productos productoSeleccionado)
        {
            InitializeComponent();
            txtNombre2.Text = productoSeleccionado.Nombre;
            txtCodigo2.Text = productoSeleccionado.Codigo;
            txtCategoria2.Text = productoSeleccionado.Categoria;
            txtPrecioUnitario2.Text = productoSeleccionado.PrecioUnitario.ToString();
            txtCantidad2.Text = productoSeleccionado.Cantidad.ToString();

        }

        private void frmRegistrarProductoCmd_Load(object sender, EventArgs e) => throw new NotImplementedException();


    }
    }
