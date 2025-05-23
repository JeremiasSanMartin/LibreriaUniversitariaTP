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
            dateTimePicker_mes.Location = new Point(635, 78);
            txtBox_busquedaReporte.Location = new Point(155, 78);
            dataGrid_reportes.Hide();
            txtBox_busquedaReporte.Hide();
            dateTimePicker_mes.Hide();


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
                dateTimePicker_mes.Location = new Point(690, 78); 
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
                    dateTimePicker_mes.Location = new Point(635, 78);
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

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Reportes"];
            dataGrid_reportes.Show();
            txtBox_busquedaReporte.Show(); 
            dateTimePicker_mes.Show ();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_reportes.Hide();
            txtBox_busquedaReporte.Hide();
            dateTimePicker_mes.Hide();
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
