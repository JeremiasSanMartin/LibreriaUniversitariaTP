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


        public VendedorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGrid_clientes.Rows.Add("1", "Pepe", "Perez", "11111111", "unmail@gmail.com", "Calle 123", "1122334455", "Si");
            dataGrid_libros.Rows.Add("UML en 24 horas", "Joseph Schmuller", "Prentice Hall", "5", "10000");
            dataGrid_factura.Rows.Add("1", "UML en 24 horas", "3", "10000", "30000");
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
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_clientes.Hide();
            panel_nuevaVenta.Hide();
            btn_nuevoCliente.Hide();
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
