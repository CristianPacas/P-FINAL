using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_FINAL_U20240388.Forms;
using P_FINAL_U20240388.Repositorios;
using P_FINAL_U20240388.Clases;
using System.Configuration;

namespace P_FINAL_U20240388.Forms
{
    public partial class frmSignUp : Form
    {
        private  UsuariosRepository _usuariosRepository;
        public frmSignUp() //El constructor del formulario
        {
            InitializeComponent();

            _usuariosRepository = new UsuariosRepository();
        }
        private object lblMensajeContraseña;

        public frmSignUp(UsuariosRepository usuariosRepository)
        {
            InitializeComponent();
            _usuariosRepository = usuariosRepository;


            txtContraseña.PasswordChar = '*';
            txtConfirmarContraseña.PasswordChar = '*';
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSingUp_Load(object sender, EventArgs e)
        {

        }
        // Agregar Usuario

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtContraseña.Text;
            string claveConfirmacion = txtConfirmarContraseña.Text;


            //Validaciones de campos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(claveConfirmacion))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // La contraseña debe tener al menos 6 caracteres 
            if (clave.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtConfirmarContraseña.Clear();
                 return;
            }

            //Mostrar * en la contraseña
            txtContraseña.PasswordChar = '*';
            txtConfirmarContraseña.PasswordChar = '*';










            // Validar que coincidan las contraseñas
            if (clave != claveConfirmacion)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtConfirmarContraseña.Clear();
                txtContraseña.Focus();
                return;
            }


            // validar espacios
            if (usuario.Contains(" ") || clave.Contains(" "))
            {
                MessageBox.Show("El usuario y la contraseña no pueden contener espacios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                _usuariosRepository.AgregarUsuario(usuario, clave);

                MessageBox.Show("Usuario **" + usuario + "** registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario de Login
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                // Ocultar el formulario de registro
                this.Hide();   // o this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar el usuario. Detalle: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        // Cancelar 

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnIraIniciarSesion_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de Login
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            // Mostrar * en la contraseña
            txtContraseña.PasswordChar = '*';


        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            // Mostrar * en la confirmación de la contraseña
            txtConfirmarContraseña.PasswordChar = '*';

            //Verificar sean la misma contraseña
            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                lblMensajeContraseña = "Las contraseñas no coinciden.";
            }
            else
            {
                lblMensajeContraseña = string.Empty;
            }



        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            //Al dar click en registrar, se ejecuta el evento btnRegistrar_Click y luego se cierra el formulario actual y se abre el formulario de login
            btnRegistrar_Click(sender, e);
            this.Close();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

        }

        private void btnCancelar0_Click(object sender, EventArgs e)
        {
            //Limpiar los campos del formulario y mostrar mensaje de cancelación
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
            MessageBox.Show("Registro cancelado.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
