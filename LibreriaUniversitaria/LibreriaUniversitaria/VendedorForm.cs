using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;   


namespace Presentacion
{
    public partial class VendedorForm : Form
    {
        private bool colapsado = true;
        private int menu_abierto = 175;
        private int menu_cerrado = 60;
        Dictionary<string, string> mensajes = new Dictionary<string, string>
        {
            { "Inicio", "¡Bienvenido/a!" },
            { "Clientes", "Clientes de Libreria Universitaria." },
            { "Ventas", " " },
        };
        private Venta venta_actual;
        private VentaLogica venta_logica = new VentaLogica();
        private LibroLogica libro_logica = new LibroLogica();
        private ClienteLogica cliente_logica = new ClienteLogica(); 
        private List<Libro> lista_libros_original;
        private int vendedor_id = 0;
       
        




        public VendedorForm(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel_menu.Width = menu_cerrado;
            dataGrid_clientes.Location = new Point(90, 68);
            dataGrid_clientes.Size = new Size(771, 508);
            btn_mostrarPanelAgregar.Location = new Point(90, 582);
            panel_nuevaVenta.Location = new Point(84, 76);
            panel_nuevaVenta.Size = new Size(780, 543);
            dataGrid_clientes.Hide();
            panel_nuevaVenta.Hide();
            btn_mostrarPanelAgregar.Hide();
            vendedor_id = id;
            cargarClientes();



        }

        private void cargarLibros()
        {
            lista_libros_original = libro_logica.obtenerDatosLibros();

            if (lista_libros_original.Count == 0)
            {
                MessageBox.Show("No se encontraron libros disponibles.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGrid_libros.AutoGenerateColumns = false;
            dataGrid_libros.DataSource = lista_libros_original;

            dataGrid_libros.Columns["precio"].DefaultCellStyle.Format = "C2";
        }
        private void cargarClientes()
        {
            var lista = cliente_logica.obtenerTodosLosClientes();
            dataGrid_clientes.DataSource = null;
            dataGrid_clientes.DataSource = lista;
            dataGrid_clientes.Columns["Descuento"].Visible = false;
            dataGrid_clientes.Columns["Tipo_ID"].Visible = false;
            // Ocultá las columnas que no querés mostrar
            dataGrid_clientes.Columns["ID"].Visible = false;
            dataGrid_clientes.Columns["Activo"].Visible = false;
        }
        private void inicializarVenta()
        {
            venta_actual = new Venta
            {
                Detalles = new List<DetalleVenta>()
            };

            venta_logica.reiniciarContadorDetalles();
            dataGrid_libros.Visible = false;
            txtBox_busquedaLibro.Visible = false;
            lbl_aviso.Visible = true;

            dataGrid_factura.DataSource = null;
            lbl_total.Text = "Subtotal: $0\n" +
                "Descuento (0%): -$0\n" +
                "Total a pagar: $0";
            
        }

        private void inicializarPanelAgregarCliente()
        {
            panel_agregarCliente.Visible = true;
            dataGrid_clientes.Hide();

            cmb_rolCliente.Items.Clear();
            cargarRolesCliente(); 

     
            SetPlaceholder(txtBox_nombreCliente, "Nombre");
            SetPlaceholder(txtBox_apellidoCliente, "Apellido");
            SetPlaceholder(txtBox_dniCliente, "DNI");
            SetPlaceholder(txtBox_telefonoCliente, "Teléfono");
            SetPlaceholder(txtBox_direccionCliente, "Dirección");
            SetPlaceholder(txtBox_emailCliente, "Email");

            cmb_rolCliente.SelectedIndex = -1;
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

        private void cargarRolesCliente()
        {
            var tabla_roles = cliente_logica.obtenerRoles();
            cmb_rolCliente.DataSource = tabla_roles;
            cmb_rolCliente.DisplayMember = "nombre";
            cmb_rolCliente.ValueMember = "id";       
        }
        private void inactivarClienteDesdeFila(int rowIndex)
        {
            var cliente = (Cliente)dataGrid_clientes.Rows[rowIndex].DataBoundItem;

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que querés inactivar al cliente {cliente.Nombre} {cliente.Apellido}?",
                "Confirmar inactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                cliente_logica.inactivarCliente(cliente.ID); // Lógica
                MessageBox.Show("Cliente inactivado correctamente.");
                cargarClientes();
            }
        }


        private void timer_animacionMenu_Tick(object sender, EventArgs e)
        {
            if (colapsado)
            {

                dataGrid_clientes.Location = new Point(198, 95);
                dataGrid_clientes.Size = new Size(663, 481);
                btn_mostrarPanelAgregar.Location = new Point(198, 582);
                panel_nuevaVenta.Location = new Point(198, 60);
                panel_nuevaVenta.Size = new Size(666, 559);
                panel_menu.Width += 5;
               
                if (panel_menu.Width >= menu_abierto)
                {
                    timer_animacionMenu.Stop();
                    colapsado = false;
                    

                }
            }
            else
            {
               
               
                panel_menu.Width -= 5;

                if (panel_menu.Width <= menu_cerrado)
                {
                    timer_animacionMenu.Stop();
                    colapsado = true;
                    dataGrid_clientes.Location = new Point(90, 68);
                    dataGrid_clientes.Size = new Size(771, 508);
                    btn_mostrarPanelAgregar.Location = new Point(90, 582);
                    panel_nuevaVenta.Location = new Point(84, 76);
                    panel_nuevaVenta.Size = new Size(780, 543);
                }

            }
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {
            timer_animacionMenu.Start();


        }


        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            panel_nuevaVenta.Hide();
            lbl_bienvenida.Text = mensajes["Clientes"];
            dataGrid_clientes.Show();
            btn_mostrarPanelAgregar.Show();
            cargarClientes();
        }

        private void btn_nuevaVenta_Click(object sender, EventArgs e)
        {
            dataGrid_clientes.Hide();
            btn_mostrarPanelAgregar.Hide();
            lbl_bienvenida.Text = mensajes["Ventas"];
            panel_nuevaVenta.Show();
            cargarLibros();
            inicializarVenta();
        }


        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_clientes.Hide();
            panel_nuevaVenta.Hide();
            btn_mostrarPanelAgregar.Hide();
        }

        private void btn_busquedaCliente_Click(object sender, EventArgs e)
        {
            string dni = txtBox_busquedaCliente.Text.Trim();
            if (string.IsNullOrEmpty(dni) || dni == "DNI del cliente")
            {
                MessageBox.Show("Ingrese un DNI válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = cliente_logica.buscarClientePorDNI(dni); 
            if (cliente == null)
            {
                MessageBox.Show("Cliente inexistente. Pruebe con otro DNI o agregue el Cliente al sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cliente.Activo)
            {
                MessageBox.Show("Cliente inactivo. No es posible asociarlo a la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            venta_actual.Cliente_Asociado = cliente;
            float descuento = cliente.Descuento * 100;
            MessageBox.Show($"Cliente {cliente.Nombre} {cliente.Apellido} asociado a la venta, le corresponde {descuento}% de descuento", "Cliente asociado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGrid_libros.Visible = true;
            txtBox_busquedaLibro.Visible = true;
            lbl_aviso.Visible = false;
        }

        private void dataGrid_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGrid_libros.Columns[e.ColumnIndex].Name == "agregar")
            {
                //guardamos el libro que se va a utilizar para modificar el catalogo 
                Libro libro = (Libro)dataGrid_libros.Rows[e.RowIndex].DataBoundItem;

                //copia para guardar el libro que se va a utilizar para guardar el detalle de la venta
                Libro libro_detalle = new Libro
                {
                    ID = libro.ID,
                    Titulo = libro.Titulo,
                    Precio = libro.Precio,
                    Stock_actual = libro.Stock_actual, 
                    Editorial = libro.Editorial,
                    Autor = libro.Autor,
                    Stock_minimo = libro.Stock_minimo,
                };

               


                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"📚 {libro.Titulo}\nStock disponible: {libro.Stock_actual}\n\nIngresá la cantidad:",
                    "Agregar al carrito", "1");

                if (int.TryParse(input, out int cantidad) && cantidad > 0)
                {
                    try
                    {
                        venta_logica.agregarDetalle(venta_actual, libro_detalle, cantidad);
                        libro.Stock_actual -= cantidad;

                        dataGrid_factura.AutoGenerateColumns = false;
                        dataGrid_factura.DataSource = null;
                        dataGrid_factura.DataSource = venta_actual.Detalles;

                        float subtotal = venta_actual.Detalles.Sum(d => d.Cantidad * d.Precio_Unitario);
                        float descuento = venta_actual.Cliente_Asociado?.Descuento ?? 0;
                        float descuento_monto = subtotal * descuento;
                        float total_final = subtotal - descuento_monto;
                        float descuento_porcentaje = descuento * 100;

                        lbl_total.Text = $"Subtotal: ${subtotal:0.00}\n" +
                                         $"Descuento ({(int)descuento_porcentaje}%): -${descuento_monto:0.00}\n" +
                                         $"Total a pagar: ${total_final:0.00}";
                        dataGrid_libros.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    MessageBox.Show("Cantidad invalida. Debe ser un entero positivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }


        private void txtBox_busquedaLibro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBox_busquedaLibro.Text.Trim().ToLower();

            List<Libro> filtrados = new List<Libro>();

            foreach (Libro libro in lista_libros_original)
            {
                string titulo = libro.Titulo?.ToLower();
                string autor = libro.Autor?.ToLower();
                string editorial = libro.Editorial?.Nombre?.ToLower();

                if ((titulo != null && titulo.Contains(filtro)) ||
                    (autor != null && autor.Contains(filtro)) ||
                    (editorial != null && editorial.Contains(filtro)))
                {
                    filtrados.Add(libro);
                }
            }

            dataGrid_libros.DataSource = null;
            dataGrid_libros.DataSource = filtrados;

            lbl_sinResultados.Visible = filtrados.Count == 0;
        }

        private void txtBox_busquedaLibro_Enter(object sender, EventArgs e)
        {
            if (txtBox_busquedaLibro.Text == "Buscar libro...")
            {
                txtBox_busquedaLibro.Text = "";
                txtBox_busquedaLibro.ForeColor = Color.Black;
            }
        }

        private void txtBox_busquedaLibro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_busquedaLibro.Text))
            {
                txtBox_busquedaLibro.Text = "Buscar libro...";
                txtBox_busquedaLibro.ForeColor = Color.Gray;
                cargarLibros();
                lbl_sinResultados.Visible = false;
            }
        }

        private void txtBox_busquedaCliente_Enter(object sender, EventArgs e)
        {
            if (txtBox_busquedaCliente.Text == "DNI del cliente")
            {
                txtBox_busquedaCliente.Text = "";
                txtBox_busquedaCliente.ForeColor = Color.Black;
            }
        }

        private void txtBox_busquedaCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_busquedaCliente.Text))
            {
                txtBox_busquedaCliente.Text = "DNI del cliente";
                txtBox_busquedaCliente.ForeColor = Color.Gray;
             
            }
        }

        private void btn_finalizarVenta_Click(object sender, EventArgs e)
        {
            if (venta_actual.Cliente_Asociado == null)
            {
                MessageBox.Show("Debe asociar un cliente a la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (venta_actual.Detalles == null || venta_actual.Detalles.Count == 0)
            {
                MessageBox.Show("Se debe agregar al menos un libro a la factura para realizar una venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = venta_logica.generarVenta(venta_actual.Cliente_Asociado, venta_actual.Detalles, vendedor_id);
            if (resultado == "OK")
            {
                MessageBox.Show("Venta realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inicializarVenta();
                cargarLibros();
                txtBox_busquedaCliente.Text = "DNI del cliente";
                txtBox_busquedaCliente.ForeColor = Color.Gray;

            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelarVenta_Click(object sender, EventArgs e)
        {
            inicializarVenta();
            cargarLibros(); // Esto restaura el stock original
            dataGrid_factura.DataSource = null;
            lbl_total.Text = "TOTAL: $0.00";
        }

        private void pctBox_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_mostrarPanelAgregar_Click(object sender, EventArgs e)
        {
            inicializarPanelAgregarCliente();
        }

        private void btn_guardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación previa (opcional pero recomendable)
                if (cliente_logica.buscarClientePorDNI(txtBox_dniCliente.Text.Trim()) != null)
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI.");
                    return;
                }

                // Paso 2: Crear el cliente y asignar el tipo desde el ComboBox
                Cliente nuevo_cliente = new Cliente
                {
                    Nombre = txtBox_nombreCliente.Text.Trim(),
                    Apellido = txtBox_apellidoCliente.Text.Trim(),
                    DNI = txtBox_dniCliente.Text.Trim(),
                    Telefono = txtBox_telefonoCliente.Text.Trim(),
                    Direccion = txtBox_direccionCliente.Text.Trim(),
                    Email = txtBox_emailCliente.Text.Trim(),
                    Tipo = cmb_rolCliente.Text, // 👈 Este es el paso 2
                    Activo = true
                };

                cliente_logica.agregarCliente(nuevo_cliente);

                MessageBox.Show("Cliente agregado correctamente.");
                panel_agregarCliente.Visible = false;
                // cargarClientes(); // si tenés un listado para refrescar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente:\n{ex.Message}\n{ex.InnerException?.Message}");
            }
        }

    }
}
