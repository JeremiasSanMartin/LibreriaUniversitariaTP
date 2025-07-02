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
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Cargar editoriales desde la base de datos
            EditorialesLogica editorialesLogica = new EditorialesLogica();
            DataTable dtEditoriales = editorialesLogica.obtenerEditoriales();
            comboBox_editoriales.DataSource = dtEditoriales;
            comboBox_editoriales.DisplayMember = "nombre";
            comboBox_editoriales.ValueMember = "id";
            comboBox_editoriales.SelectedIndex = -1;

            this.StartPosition = FormStartPosition.CenterScreen;
            panel_menu.Width = menu_cerrado;
            dataGrid_stock.Location = new Point(154, 70);
            dataGrid_stock.Size = new Size(662, 508);
            btn_agregarLibroMenu.Location = new Point(154, 584);
            btn_alertasStockBajo.Location = new Point(606, 584);
            dataGrid_editoriales.Location = new Point(222, 70);
            dataGrid_stock.Hide();
            btn_agregarLibroMenu.Hide();
            btn_alertasStockBajo.Hide();
            dataGrid_editoriales.Hide();
            btn_verLibros.Hide();
            panel_agregarLibro.Hide();
            label_Autor.Hide();
            label_titulo.Hide();
            label_Editorial.Hide();
            label_precio.Hide();
            label_stockActual.Hide();
            label_stockMinimo.Hide();
            txtBox_autor.Hide();
            txtBox_titulo.Hide();
            comboBox_editoriales.Hide();
            txtBox_precio.Hide();
            txtBox_stockActual.Hide();
            textBox_StockMinimo.Hide();
            btn_agregarLibro.Hide();
            panel_editarLibro.Hide();
            label_AutorEditar.Hide();
            label_tituloEditar.Hide();
            label_editorialEditar.Hide();
            label_PrecioEditar.Hide();
            label_StockActualEditar.Hide();
            label_StockMinimoEditar.Hide();
            txtBox_AutorEditar.Hide();
            txtBox_tituloEditar.Hide();
            comboBox_EditorialEditar.Hide();
            txtBox_PrecioEditar.Hide();
            textBox_StockActualEditar.Hide();
            txtBox_StockMinimoEditar.Hide();
            btn_EditarLibro.Hide();
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
                btn_agregarLibroMenu.Location = new Point(197, 584);
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
                    btn_agregarLibroMenu.Location = new Point(154, 584);
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
            btn_agregarLibroMenu.Show();
            btn_alertasStockBajo.Show();
            btn_verLibros.Show();
            dataGrid_editoriales.Hide();

            // Instancia la lógica de stock de libros
            StockLibrosLogica stockLogica = new StockLibrosLogica();

            // Obtener los libros en stock
            DataTable dt = stockLogica.obtenerStockLibros();

            // Limpia el DataGridView antes de cargar nuevos datos
            dataGrid_stock.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_stock.Rows.Add(
                    row["id"],
                    row["titulo"],
                    row["autor"],
                    row["editorial"],
                    row["stock_actual"],
                    row["stock_minimo"],
                    row["precio"]
                );
            }
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Inicio"];
            dataGrid_stock.Hide();
            btn_agregarLibroMenu.Hide();
            btn_alertasStockBajo.Hide();
            btn_verLibros.Hide();
            dataGrid_editoriales.Hide();
            panel_agregarLibro.Hide();
        }

        private void btn_editoriales_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Editoriales"];
            dataGrid_editoriales.Show();
            dataGrid_stock.Hide();
            btn_agregarLibroMenu.Hide();
            btn_verLibros.Hide();
            btn_alertasStockBajo.Hide();
            panel_agregarLibro.Hide();

            // Instancia la lógica de editoriales
            EditorialesLogica editorialesLogica = new EditorialesLogica();

            // Obtener las editoriales
            DataTable dt = editorialesLogica.obtenerEditoriales();

            // Limpia el DataGridView antes de cargar nuevos datos
            dataGrid_editoriales.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_editoriales.Rows.Add(
                    row["nombre"],
                    row["contacto"]
                );
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

        private void btn_alertasStockBajo_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = "Libros con stock bajo";
            dataGrid_stock.Show();
            btn_agregarLibroMenu.Show();
            btn_alertasStockBajo.Show();
            btn_verLibros.Show();
            dataGrid_editoriales.Hide();
            panel_agregarLibro.Hide();

            // Instancia la lógica de stock de libros
            StockLibrosLogica stockLogica = new StockLibrosLogica();

            // Obtener los libros con stock bajo
            DataTable dt = stockLogica.obtenerLibrosStockBajo();

            // Limpia el DataGridView antes de cargar nuevos datos
            dataGrid_stock.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_stock.Rows.Add(
                    row["id"],
                    row["titulo"],
                    row["autor"],
                    row["editorial"],
                    row["stock_actual"],
                    row["stock_minimo"],
                    row["precio"]
                );
            }
        }

        private void btn_verLibros_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = mensajes["Stock"];
            dataGrid_stock.Show();
            btn_agregarLibroMenu.Show();
            btn_alertasStockBajo.Show();
            btn_verLibros.Show();
            dataGrid_editoriales.Hide();
            panel_agregarLibro.Hide();

            // Instancia la lógica de stock de libros
            StockLibrosLogica stockLogica = new StockLibrosLogica();

            // Obtener los libros en stock
            DataTable dt = stockLogica.obtenerStockLibros();

            // Limpia el DataGridView antes de cargar nuevos datos
            dataGrid_stock.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGrid_stock.Rows.Add(
                    row["id"],
                    row["titulo"],
                    row["autor"],
                    row["editorial"],
                    row["stock_actual"],
                    row["stock_minimo"],
                    row["precio"]
                );
            }
        }

        private void btn_agregarLibroMenu_Click(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = "Agregar stock libros";
            dataGrid_stock.Hide();
            btn_agregarLibroMenu.Hide();
            btn_alertasStockBajo.Hide();
            btn_verLibros.Hide();
            dataGrid_editoriales.Hide();
            panel_agregarLibro.Show();
            label_titulo.Show();
            label_Autor.Show();
            label_Editorial.Show();
            label_precio.Show();
            label_stockActual.Show();
            label_stockMinimo.Show();
            txtBox_titulo.Show();
            txtBox_autor.Show();
            comboBox_editoriales.Show();
            txtBox_precio.Show();
            txtBox_stockActual.Show();
            textBox_StockMinimo.Show();
            btn_agregarLibro.Show();
        }
        
        private void dataGrid_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_stock.Rows[e.RowIndex];
                // Mostrar el panel de edición y los controles
                panel_editarLibro.Show();
                label_AutorEditar.Show();
                label_tituloEditar.Show();
                label_editorialEditar.Show();
                label_PrecioEditar.Show();
                label_StockActualEditar.Show();
                label_StockMinimoEditar.Show();
                txtBox_AutorEditar.Show();
                txtBox_tituloEditar.Show();
                comboBox_EditorialEditar.Show();
                txtBox_PrecioEditar.Show();
                textBox_StockActualEditar.Show();
                txtBox_StockMinimoEditar.Show();
                btn_EditarLibro.Show();

                // Cargar los datos en los controles
                txtBox_tituloEditar.Text = row.Cells["titulo"].Value.ToString();
                txtBox_AutorEditar.Text = row.Cells["autor"].Value.ToString();
                textBox_StockActualEditar.Text = row.Cells["stock"].Value.ToString();
                txtBox_StockMinimoEditar.Text = row.Cells["stock_minimo"].Value.ToString();
                txtBox_PrecioEditar.Text = row.Cells["precio"].Value.ToString();

                // Cargar el ComboBox de editoriales si no está cargado
                if (comboBox_EditorialEditar.DataSource == null)
                {
                    EditorialesLogica editorialesLogica = new EditorialesLogica();
                    DataTable dtEditoriales = editorialesLogica.obtenerEditoriales();
                    comboBox_EditorialEditar.DataSource = dtEditoriales;
                    comboBox_EditorialEditar.DisplayMember = "nombre";
                    comboBox_EditorialEditar.ValueMember = "id";
                }

                // Seleccionar la editorial correspondiente
                string nombreEditorial = row.Cells["Editorial"].Value.ToString();
                int index = comboBox_EditorialEditar.FindStringExact(nombreEditorial);
                comboBox_EditorialEditar.SelectedIndex = index;
            }
        }

        private void btn_agregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro
                {
                    Titulo = txtBox_titulo.Text.Trim(),
                    Autor = txtBox_autor.Text.Trim(),
                    Stock_actual = Convert.ToInt32(txtBox_stockActual.Text.Trim()),
                    Stock_minimo = Convert.ToInt32(textBox_StockMinimo.Text.Trim()),
                    Precio = float.Parse(txtBox_precio.Text.Trim())
                };

                if (comboBox_editoriales.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una editorial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Editorial editorial = new Editorial
                {
                    Id = Convert.ToInt32(comboBox_editoriales.SelectedValue),
                    Nombre = comboBox_editoriales.Text
                };

                libro.Editorial = editorial;
                Logica.StockLibrosLogica stockLogica = new Logica.StockLibrosLogica();
                int resultado = stockLogica.agregarLibro(libro);

                if (resultado > 0)
                {
                    MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtBox_titulo.Clear();
                    txtBox_autor.Clear();
                    txtBox_stockActual.Clear();
                    textBox_StockMinimo.Clear();
                    txtBox_precio.Clear();
                    comboBox_editoriales.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error al agregar el libro. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_EditarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro()
                {
                    Titulo = txtBox_tituloEditar.Text.Trim(),
                    Autor = txtBox_AutorEditar.Text.Trim(),
                    Stock_actual = Convert.ToInt32(textBox_StockActualEditar.Text.Trim()),
                    Stock_minimo = Convert.ToInt32(txtBox_StockMinimoEditar.Text.Trim()),
                    Precio = float.Parse(txtBox_PrecioEditar.Text.Trim())
                };

                if (comboBox_EditorialEditar.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una editorial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Editorial editorial = new Editorial
                {
                    Id = Convert.ToInt32(comboBox_editoriales.SelectedValue),
                    Nombre = comboBox_editoriales.Text
                };

                Logica.StockLibrosLogica stockLogica = new Logica.StockLibrosLogica();
                int resultado = stockLogica.editarLibro(libro);

                if (resultado > 0)
                {
                    MessageBox.Show("Libro editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: refrescar el DataGridView
                }
                else
                {
                    MessageBox.Show("Error al editar el libro. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
