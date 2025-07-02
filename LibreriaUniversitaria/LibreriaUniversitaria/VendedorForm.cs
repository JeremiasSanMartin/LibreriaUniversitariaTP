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
using Persistencia;


namespace Presentacion
{
    public partial class VendedorForm : Form
    {
        private bool colapsado = true;
        private int menu_abierto = 175;
        private int menu_cerrado = 60;
        Dictionary<string, string> mensajes = new Dictionary<string, string>
        {
            { "Inicio", "¡Bienvenido/a, (nombre y apellido)!" },
            { "Clientes", "Clientes de Libreria Universitaria." },
            { "Ventas", " " },
        };
        private Venta ventaActual;
        private VentaLogica ventaLogica = new VentaLogica();
        private LibroDatos libroDatos = new LibroDatos();
        private List<Libro> listaLibrosOriginal;
        



        public VendedorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGrid_clientes.Rows.Add("1", "Pepe", "Perez", "11111111", "unmail@gmail.com", "Calle 123", "1122334455", "Si");
            panel_menu.Width = menu_cerrado;
            dataGrid_clientes.Location = new Point(90, 68);
            dataGrid_clientes.Size = new Size(771, 508);
            btn_nuevoCliente.Location = new Point(90, 582);
            panel_nuevaVenta.Location = new Point(84, 76);
            panel_nuevaVenta.Size = new Size(780, 543);
            dataGrid_clientes.Hide();
            panel_nuevaVenta.Hide();
            btn_nuevoCliente.Hide();
            
        }
        private void cargarLibros()
        {
            listaLibrosOriginal = libroDatos.obtenerDatosLibros();

            if (listaLibrosOriginal.Count == 0)
            {
                MessageBox.Show("No se encontraron libros disponibles.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGrid_libros.AutoGenerateColumns = false;
            dataGrid_libros.DataSource = listaLibrosOriginal;

            dataGrid_libros.Columns["precio"].DefaultCellStyle.Format = "C2";
        }
        private void inicializarVenta()
        {
            ventaActual = new Venta
            {
                Detalles = new List<DetalleVenta>(),
                Cliente_Asociado = ventaLogica.obtenerClientePrueba()
            };

            dataGrid_factura.DataSource = null;
            label2.Text = "TOTAL: $0.00";
        }




        private void timer_animacionMenu_Tick(object sender, EventArgs e)
        {
            if (colapsado)
            {

                dataGrid_clientes.Location = new Point(198, 95);
                dataGrid_clientes.Size = new Size(663, 481);
                btn_nuevoCliente.Location = new Point(198, 582);
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
                    btn_nuevoCliente.Location = new Point(90, 582);
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
            btn_nuevoCliente.Show();

        }

        private void btn_nuevaVenta_Click(object sender, EventArgs e)
        {
            dataGrid_clientes.Hide();
            btn_nuevoCliente.Hide();
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
            btn_nuevoCliente.Hide();
        }

        private void dataGrid_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGrid_libros.Columns[e.ColumnIndex].Name == "agregar")
            {
                Libro libro = (Libro)dataGrid_libros.Rows[e.RowIndex].DataBoundItem;

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"📚 {libro.Titulo}\nStock disponible: {libro.Stock_actual}\n\nIngresá la cantidad:",
                    "Agregar al carrito", "1");

                if (int.TryParse(input, out int cantidad) && cantidad > 0)
                {
                    try
                    {
                        ventaLogica.agregarDetalle(ventaActual, libro, cantidad);

                        dataGrid_factura.AutoGenerateColumns = false;
                        dataGrid_factura.DataSource = null;
                        dataGrid_factura.DataSource = ventaActual.Detalles;

                        float total = ventaActual.Detalles.Sum(d => d.Cantidad * d.Precio_Unitario);
                        label2.Text = $"TOTAL: ${total:0.00}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private void txtBox_busquedaLibro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBox_busquedaLibro.Text.Trim().ToLower();

            List<Libro> filtrados = new List<Libro>();

            foreach (Libro libro in listaLibrosOriginal)
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

        private void pctBox_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
