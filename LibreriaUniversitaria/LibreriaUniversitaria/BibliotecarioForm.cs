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
    public partial class BibliotecarioForm : Form
    {

        private bool colapsado = true;
        private int menu_abierto = 175;
        private int menu_cerrado = 60;
        Dictionary<string, string> mensajes = new Dictionary<string, string>
    {
        { "Inicio", "¡Bienvenido/a, (nombre y apellido)!" },
        { "Stock", "Lista de stock de Libreria Universitaria" },
        { "Editoriales", "Contactos de editoriales " },
    };
        public BibliotecarioForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            panel_menu.Width = menu_cerrado;
            dataGrid_stock.Rows.Add("1", "UML en 24 horas", "Joseph Schmuller", "Prentice Hall", "5", "3",  "10000");
            dataGrid_editoriales.Rows.Add("Prentice Hall", "(011) 4309-6100");
            dataGrid_stock.Location = new Point(154, 70);
            dataGrid_stock.Size = new Size(662, 508);
            btn_agregarStock.Location = new Point(154, 584);
            btn_alertasStockBajo.Location = new Point(606, 584);
            dataGrid_editoriales.Location = new Point(222, 70);
            dataGrid_stock.Hide();
            btn_agregarStock.Hide();
            btn_alertasStockBajo.Hide();
            dataGrid_editoriales.Hide();
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
                dataGrid_stock.Location = new Point(197, 70);
                btn_agregarStock.Location = new Point(197, 584);
                dataGrid_editoriales.Location = new Point(276, 70);
                btn_alertasStockBajo.Location = new Point(649, 584);

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
                    dataGrid_stock.Location = new Point(154, 70);
                    btn_agregarStock.Location = new Point(154, 584);
                    btn_alertasStockBajo.Location = new Point(606, 584);
                    dataGrid_editoriales.Location = new Point(222, 70);
                    colapsado = true;
                   
                }

            }
        }

        private void btn_desplegar_Click(object sender, EventArgs e)
        {
            timer_animacionMenu.Start();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Stock"];
            dataGrid_stock.Show();
            btn_agregarStock.Show();
            btn_alertasStockBajo.Show();
            dataGrid_editoriales.Hide();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_stock.Hide();
            btn_agregarStock.Hide();
            btn_alertasStockBajo.Hide();
            dataGrid_editoriales.Hide();
        }

        private void btn_editoriales_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Editoriales"];
            dataGrid_editoriales.Show();
            dataGrid_stock.Hide();
            btn_agregarStock.Hide();
            btn_alertasStockBajo.Hide();

        }
    }
}
