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
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class GerenteForm : Form
    {
        private bool colapsado = true;
        private int menu_abierto = 175;
        private int menu_cerrado = 60;
        Dictionary<string, string> mensajes = new Dictionary<string, string>
    {
        { "Inicio", "¡Bienvenido/a, (nombre y apellido)!" },
        { "Reportes", "Reportes de Ventas" },
    };
        public GerenteForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel_menu.Width = menu_cerrado;
            dataGrid_reportes.Location = new Point(155, 111);
            txtBox_busquedaReporte.Location = new Point(155, 78);
            dataGrid_reportes.Hide();
            txtBox_busquedaReporte.Hide();
            pictureBoxBuscar.Hide();
            pictureBoxBuscarFecha.Hide();
            label3.Hide();
            label4.Hide();
            dtpInicio.Hide();
            dtpFinal.Hide();
            txtBox_busquedaReporte.Click += txtBox_busquedaReporte_Click;
            txtBox_busquedaReporte.KeyDown += txtBox_busquedaReporte_KeyDown;


        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer_animacionMenu_Tick(object sender, EventArgs e)
        {
            if (colapsado)
            {


                panel_menu.Width += 5;
                dataGrid_reportes.Location = new Point(210, 111);
                txtBox_busquedaReporte.Location = new Point(210, 78);

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
                    dataGrid_reportes.Location = new Point(155, 111);
                    txtBox_busquedaReporte.Location = new Point(155, 78);
                    timer_animacionMenu.Stop();
                    colapsado = true;

                }

            }
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {
            timer_animacionMenu.Start();
        }

        private ReporteLogica _reporteLogica = new ReporteLogica();

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Reportes"];
            dataGrid_reportes.Show();
            txtBox_busquedaReporte.Show();
            pictureBoxBuscar.Show();
            pictureBoxBuscarFecha.Show();
            label3.Show();
            label4.Show();
            dtpInicio.Show();
            dtpFinal.Show();

            CargarDatos();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_reportes.Hide();
            txtBox_busquedaReporte.Hide();
            pictureBoxBuscar.Hide();
            pictureBoxBuscarFecha.Hide();
            label3.Hide();
            label4.Hide();
            dtpInicio.Hide();
            dtpFinal.Hide();
        }

        private void pctBox_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBox_busquedaReporte_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void txtBox_busquedaReporte_Click(object sender, EventArgs e)
        {
            //limpia el campo al hacer click en el textbox
            txtBox_busquedaReporte.Clear();
        }

        //funcion para realizar la busqueda por vendedor
        private void RealizarBusqueda()
        {
            try
            {
                string texto = txtBox_busquedaReporte.Text.Trim();
                var lista = _reporteLogica.RecuperarDetalles(texto);

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    dataGrid_reportes.Columns.Clear();
                    dataGrid_reportes.AutoGenerateColumns = true;
                    dataGrid_reportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGrid_reportes.DataSource = lista;
                    dataGrid_reportes.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar por vendedor:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDatos()
        {
            //utiliza RecupearDetalles sin pasar parametros para obtener los datos de los reportes
            var lista = _reporteLogica.RecuperarDetalles();
            dataGrid_reportes.Columns.Clear(); // Limpiar columnas
            dataGrid_reportes.AutoGenerateColumns = true;
            dataGrid_reportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid_reportes.DataSource = lista;
        }

        private void txtBox_busquedaReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                RealizarBusqueda();
            }
        }

        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void pictureBoxBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpInicio.Value.Date;
            DateTime hasta = dtpFinal.Value.Date;
            try
            {
                //verifica que las fechas cumplan con las condiciones
                if (desde > hasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.");
                    return;
                }

                //recupera los reportes por el rango de fechas ingresado
                var lista = _reporteLogica.RecuperarPorFechas(desde, hasta);

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    dataGrid_reportes.Columns.Clear();
                    dataGrid_reportes.AutoGenerateColumns = true;
                    dataGrid_reportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGrid_reportes.DataSource = lista;
                    dataGrid_reportes.Refresh();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar ventas por fecha:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
