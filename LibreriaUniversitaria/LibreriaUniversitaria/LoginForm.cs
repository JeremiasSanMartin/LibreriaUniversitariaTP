using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;
using Logica;
using LibreriaUniversitaria;

namespace Presentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarPlaceholders();
        }

        private void cargarPlaceholders()
        {
            textBox_usuario.Text = "Usuario";
            textBox_clave.Text = "Contraseña";
            textBox_usuario.ForeColor = Color.Gray;
            textBox_clave.ForeColor = Color.Gray;
            textBox_clave.PasswordChar = '\0';
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string clave = textBox_clave.Text;
            string rol; // Variable para almacenar el rol del usuario
            int id;

            Logica.UsuarioLogica unLogin = new Logica.UsuarioLogica();

            if (unLogin.loguearse(usuario, clave, out rol, out id))
            {
                MessageBox.Show($"Inicio sesión correctamente");

                if (rol == "Administrador")
                {

                    AdminForm adminForm = new AdminForm();
                    this.Hide(); // oculta el form actual
                    adminForm.ShowDialog(); // muestra el nuevo form 
                    this.Show(); // vuelve a mostrar el menú al cerrar el AdminForm
                    cargarPlaceholders();


                }
                else if (rol == "Bibliotecario")
                {

                    BibliotecarioForm bibliotecarioForm = new BibliotecarioForm();
                    this.Hide();
                    bibliotecarioForm.ShowDialog();
                    this.Show();
                    cargarPlaceholders();   

                }
                else if (rol == "Gerente")
                {
                    GerenteForm gerenteForm = new GerenteForm();
                    this.Hide();
                    gerenteForm.ShowDialog();
                    this.Show();
                    cargarPlaceholders();
                }
                else if (rol == "Vendedor")
                {
                    VendedorForm vendedorForm = new VendedorForm(id);
                    this.Hide();
                    vendedorForm.ShowDialog();
                    this.Show();
                    cargarPlaceholders();

                }
                else
                {
                    MessageBox.Show("Rol no reconocido");
                }
            }
            else
            {
                MessageBox.Show("El usuario, la contraseña o el tipo de rol es incorrecto");
            }
        }


    //Eventos para que al presionar los txtbox se borren los placeholder y si el usuario no escribe nada vuelvan a aparecer
        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "Usuario")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.Black;
            }
        }

        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_usuario.Text))
            {
                textBox_usuario.Text = "Usuario";
                textBox_usuario.ForeColor = Color.Gray;
            }
        }

        private void textBox_clave_Enter(object sender, EventArgs e)
        {

            if (textBox_clave.Text == "Contraseña")
            {
                textBox_clave.Text = "";
                textBox_clave.ForeColor = Color.Black;
                textBox_clave.PasswordChar = '●';
            }
        }

        private void textBox_clave_Leave(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textBox_clave.Text))
            {
                textBox_clave.PasswordChar = '\0';
                textBox_clave.Text = "Contraseña";
                textBox_clave.ForeColor = Color.Gray;
            }
        }

     //Eventos para agregarle un efecto de click al boton de iniciar sesion
        private void btn_iniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            btn_iniciarSesion.Location = new Point(btn_iniciarSesion.Location.X + 1, btn_iniciarSesion.Location.Y + 1);
        }

        private void btn_iniciarSesion_MouseUp(object sender, MouseEventArgs e)
        {
            btn_iniciarSesion.Location = new Point(btn_iniciarSesion.Location.X - 1, btn_iniciarSesion.Location.Y - 1);
        }

        //Eventos para ir al control siguiente cuando se presiona enter

        private void txtBox_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_clave.Focus();
                e.SuppressKeyPress = true; // para evitar el ruido que hace el sistema cuando se presiona enter
            }
        }   
        private void txtBox_clave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btn_iniciarSesion.Focus();
                e.SuppressKeyPress = true; 
            }
        }
        private void comboBox_tipoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_iniciarSesion_Click(sender, e);
                e.SuppressKeyPress = true; 
            }
        }

    }
}
