using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {

            comboBox_tipoUsuario.Items.Clear();
            comboBox_tipoUsuario.Items.Add("Administrador");
            comboBox_tipoUsuario.Items.Add("Bibliotecario");
            comboBox_tipoUsuario.Items.Add("Vendedor");
            comboBox_tipoUsuario.Items.Add("Gerente");
            comboBox_tipoUsuario.SelectedIndex = -1; //para que en combo box no aparezca nada seleccionado primero

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string clave = textBox_clave.Text;
            string rolSeleccionado = comboBox_tipoUsuario.SelectedItem?.ToString(); //selectedItem es por si agrega nada

            Logica.Usuario unLogin = new Logica.Usuario();

            if (unLogin.Loguearse(usuario, clave, rolSeleccionado))
            {
                MessageBox.Show($"Inicio sesión correctamente como {rolSeleccionado}");

                if (rolSeleccionado == "Administrador")
                {

                    AdminForm adminForm = new AdminForm();
                    this.Hide(); // oculta el form actual
                    adminForm.ShowDialog(); // muestra el nuevo form 
                    this.Show(); // vuelve a mostrar el menú al cerrar el AdminForm

                }
                else if (rolSeleccionado == "Bibliotecario")
                {

                    BibliotecarioForm bibliotecarioForm = new BibliotecarioForm();
                    this.Hide();
                    bibliotecarioForm.ShowDialog();
                    this.Show();

                }
                else if (rolSeleccionado == "Vendedor")
                {
                    VendedorForm vendedorForm = new VendedorForm();
                    this.Hide();
                    vendedorForm.ShowDialog();
                    this.Show();

                }
                else if (rolSeleccionado == "Gerente")
                {
                    GerenteForm gerenteForm = new GerenteForm();
                    this.Hide();
                    gerenteForm.ShowDialog();
                    this.Show();
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
    }
}
