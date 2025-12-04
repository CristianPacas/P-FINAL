using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_FINAL_U20240388.Clases;
using P_FINAL_U20240388.Repositorios;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;





namespace P_FINAL_U20240388.Forms
{
    public partial class frmLogin : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
        private readonly UsuariosRepository _usuariosRepository;
        public frmLogin()
        {
            InitializeComponent();
            _usuariosRepository = new UsuariosRepository(_connectionString);
            txtContraseña.PasswordChar = '*';   //MASCARA
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                frmSignUp registroForm = new frmSignUp(_usuariosRepository);
                registroForm.ShowDialog();

                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario de registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                frmSignUp registroForm = new frmSignUp(_usuariosRepository);


                registroForm.ShowDialog();


                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario de registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {

            // Validar que los campos no estén vacíos
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Obtener el usuario de la base de datos
            Usuarios user = _usuariosRepository.ObtenerUsuarioPorNombre(usuario);
            if (user == null)
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
                return;
            }
            // Obtener la contraseña de la base de datos y compararla con la ingresada

            if (string.IsNullOrEmpty(user.PasswordHash))
            {
                MessageBox.Show("El usuario no tiene una contraseña válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            // Encriptar la contraseña ingresada para compararla
                        string hashIngresado = Encriptador.EncriptarClave(contraseña);

            if (hashIngresado != user.PasswordHash)
            {
                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            // Si todo es correcto, mostrar mensaje de éxito, cerrar formulario de Login y abrir el formulario RegistrarProducto

            MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            frmRegistrarProducto registrarProductoForm = new frmRegistrarProducto();
            registrarProductoForm.ShowDialog(this);
            this.Close();






        }


    }
}
