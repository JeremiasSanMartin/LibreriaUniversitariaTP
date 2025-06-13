using Entidades;
using Logica;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
   
    public partial class AdminForm : Form
    {
        private bool colapsado = true;
        private int menu_abierto = 175;
        private int menu_cerrado = 60;
        //diccionario con mensajes para mostrar en cada seccion 
        Dictionary<string, string> mensajes = new Dictionary<string, string>
        {
         { "Inicio", "¡Bienvenido/a, (nombre y apellido)!" },
         { "Usuarios", "Usuarios del Sistema" },
         { "NuevoUsuario", " " },
        };

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel_menu.Width = menu_cerrado;
            dataGrid_usuarios.Location = new Point(173, 87);
            dataGrid_usuarios.Hide();
            panel_crearUsuario.Hide();
            this.Load += AdminForm_Load;
        }

        public void AdminForm_Load(object sender, EventArgs e)
        {
            cBox_rolCrear.Items.Clear();
            cBox_rolCrear.Items.Add("Administrador");
            cBox_rolCrear.Items.Add("Bibliotecario");
            cBox_rolCrear.Items.Add("Gerente");
            cBox_rolCrear.Items.Add("Vendedor");

            SetPlaceholder(txtBox_nombreCrear, "Nombre");
            SetPlaceholder(txtBox_apellidoCrear, "Apellido");
            SetPlaceholder(txtBox_usuarioCrear, "Nombre de usuario");
            SetPlaceholder(txtBox_contrasenaCrear, "Contraseña");
            SetPlaceholder(txtBox_DNI, "DNI de usuario");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar sesión?","Confirmar cierre de sesión",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //usamos un timer para simular una animacion al abrir y cerrar el menu desplegable
        private void timer_animacionMenu_Tick(object sender, EventArgs e)
        {
            if(colapsado)
            {
               
                dataGrid_usuarios.Location = new Point(232, 87);
                panel_menu.Width += 5;
             
                if (panel_menu.Width >= menu_abierto)
                {
                    timer_animacionMenu.Stop();
                    colapsado = false;
                    
                }
            }
            else
            {
                dataGrid_usuarios.Location = new Point(173, 87);
                panel_menu.Width -= 5;
               
                if (panel_menu.Width <= menu_cerrado)
                {
                    timer_animacionMenu.Stop();
                    colapsado = true;
                }

            }
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {
            timer_animacionMenu.Start();
           
            
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Usuarios"];
            panel_crearUsuario.Hide();
            dataGrid_usuarios.Show();

            // Instancia la lógica de administración
            AdminLogica adminLogica = new AdminLogica();

            // Obtener los usuarios
            DataTable dt = adminLogica.buscarUsuario();

            // Limpia el DataGridView antes de cargar nuevos datos
            dataGrid_usuarios.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_usuarios.Rows.Add(
                    row["id"],
                    row["nombre_usuario"],
                    row["nombre"],
                    row["apellido"],
                    row["contrasena"],
                    row["rol"]
                );
            }
        }

        private void btn_nuevoUsuario_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["NuevoUsuario"];
            panel_crearUsuario.Show();
            panel_crearUsuario.Location = new Point(303, 128);
            dataGrid_usuarios.Hide();

        }

        private void pctBox_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_usuarios.Hide();
            panel_crearUsuario.Hide();
        }
    }
}
