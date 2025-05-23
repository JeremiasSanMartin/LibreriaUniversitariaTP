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
   
    public partial class AdminForm : Form
    {
        private bool colapsado = true;
        private int menu_abierto = 175;
        private int menu_cerrado = 60;
    
       

        

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGrid_usuarios.Rows.Add("1", "miardg", "Mia", "Rodriguez", "123", "Gerente");
            panel_menu.Width = menu_cerrado;
            dataGrid_usuarios.Hide();
            panel_crearUsuario.Hide();


        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar sesión?","Confirmar cierre de sesión",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }


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
            panel_crearUsuario.Hide();
            dataGrid_usuarios.Show();
           
            
        }

        private void btn_nuevoUsuario_Click(object sender, EventArgs e)
        {
            panel_crearUsuario.Show();
            panel_crearUsuario.Location = new Point(303, 128);
            dataGrid_usuarios.Hide();


        }
    }
}
