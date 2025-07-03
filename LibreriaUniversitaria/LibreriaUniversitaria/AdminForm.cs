using Entidades;
using Logica;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            dataGrid_usuarios.RowPrePaint += dataGrid_usuarios_RowPrePaint;
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
                    row["rol"],
                    row["activo"]
                );
            }
        }

        // Evento para cambiar el color de las filas según el estado del usuario (activo/inactivo)
        private void dataGrid_usuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGrid_usuarios.Rows[e.RowIndex];

            var activoCell = row.Cells["Activo"];
            if (activoCell.Value == null)
                return;

            bool activo = false;
            string valorTexto = activoCell.Value.ToString().Trim().ToLower();
            if (valorTexto == "1" || valorTexto == "true")
                activo = true;

            if (!activo)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
                row.DefaultCellStyle.ForeColor = Color.DarkGray;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

        }

        // Método para refrescar la grilla de usuarios
        private void RefrescarUsuarios()
        {
            AdminLogica adminLogica = new AdminLogica();
            DataTable dt = adminLogica.buscarUsuario();

            dataGrid_usuarios.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_usuarios.Rows.Add(
                    row["id"],
                    row["nombre_usuario"],
                    row["nombre"],
                    row["apellido"],
                    row["contrasena"],
                    row["rol"],
                    row["activo"]
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

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            try 
            {
                Usuario usuario = new Usuario
                {
                    Nombre = txtBox_nombreCrear.Text.Trim(),
                    Apellido = txtBox_apellidoCrear.Text.Trim(),
                    Nombre_usuario = txtBox_usuarioCrear.Text.Trim(),
                    Contraseña = txtBox_contrasenaCrear.Text.Trim(),
                    DNI = txtBox_DNI.Text.Trim(),
                    Rol = cBox_rolCrear.SelectedItem?.ToString() ?? "Bibliotecario", // Valor por defecto si no se selecciona nada
                    Activo = true // Por defecto, el usuario se crea como activo
                };

                // Validaciones de campos vacíos
                if (string.IsNullOrWhiteSpace(usuario.Nombre) ||
                    string.IsNullOrWhiteSpace(usuario.Apellido) ||
                    string.IsNullOrWhiteSpace(usuario.Nombre_usuario) ||
                    string.IsNullOrWhiteSpace(usuario.Contraseña) ||
                    string.IsNullOrWhiteSpace(usuario.DNI) ||
                    string.IsNullOrWhiteSpace(usuario.Rol))
                {
                    MessageBox.Show("Debe completar todos los campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de contraseña segura
                Regex regexContrasena = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_])[^\s]{8,}$");

                if (!regexContrasena.IsMatch(usuario.Contraseña))
                {
                    MessageBox.Show("La contraseña debe tener al menos:\n- Una letra mayúscula\n- Una letra minúscula\n- Un número\n- Un carácter especial\n- Y no contener espacios",
                                    "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AdminLogica adminLogica = new AdminLogica();

                if (adminLogica.crearUsuario(usuario))
                {
                    MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBox_nombreCrear.Clear();
                    txtBox_apellidoCrear.Clear();
                    txtBox_usuarioCrear.Clear();
                    txtBox_contrasenaCrear.Clear();
                    txtBox_DNI.Clear();
                    cBox_rolCrear.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                string msg = ex.Message.ToLower();

                if (msg.Contains("usuario ya existe"))
                {
                    MessageBox.Show("El nombre de usuario ya está en uso.", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (msg.Contains("dni ya está"))
                {
                    MessageBox.Show("El DNI ingresado ya fue registrado anteriormente.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error al insertar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        //Eventos para que al presionar enter envie datos al crear usuario
        private void txtBox_nombreCrear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;//Evitar que se envíe el Enter al botón predeterminado
                txtBox_apellidoCrear.Focus();//Pasa al siguiente foco
            }
        }

        private void txtBox_apellidoCrear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                txtBox_usuarioCrear.Focus();
            }
        }

        private void txtBox_usuarioCrear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                txtBox_contrasenaCrear.Focus(); 
            }
        }

        private void txtBox_contrasenaCrear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                txtBox_DNI.Focus(); 
            }
        }

        private void txtBox_DNI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
            }
        }

        private void dataGrid_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la columna de bloquear
            if (e.ColumnIndex == dataGrid_usuarios.Columns["inactivar"].Index && e.RowIndex >= 0)
            {
                Usuario usuarioSeleccionado = new Usuario
                {
                    ID = Convert.ToInt32(dataGrid_usuarios.Rows[e.RowIndex].Cells["ID"].Value),
                    Nombre_usuario = dataGrid_usuarios.Rows[e.RowIndex].Cells["nombreUsuario"].Value.ToString(),
                    Nombre = dataGrid_usuarios.Rows[e.RowIndex].Cells["nombre"].Value.ToString(),
                    Apellido = dataGrid_usuarios.Rows[e.RowIndex].Cells["apellido"].Value.ToString(),
                    Contraseña = dataGrid_usuarios.Rows[e.RowIndex].Cells["password"].Value.ToString(),
                    Rol = dataGrid_usuarios.Rows[e.RowIndex].Cells["rol"].Value.ToString(),
                    Activo = Convert.ToBoolean(dataGrid_usuarios.Rows[e.RowIndex].Cells["activo"].Value)
                };

                if (!usuarioSeleccionado.Activo)
                {
                    MessageBox.Show($"El usuario {usuarioSeleccionado.Nombre_usuario} ya está inactivado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show($"¿Seguro que desea inactivar al usuario {usuarioSeleccionado.Nombre_usuario}?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    AdminLogica adminLogica = new AdminLogica();
                    bool exito = adminLogica.inactivarUsuario(usuarioSeleccionado);

                    if (exito)
                    {
                        MessageBox.Show("Usuario inactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo inactivar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
