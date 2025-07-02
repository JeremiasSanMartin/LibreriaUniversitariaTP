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
using DAL;

namespace LibreriaUniversitaria
{
    public partial class PruebaCliente : Form
    {
        private ClienteLogica clienteLogica = new ClienteLogica();
        public PruebaCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    DNI = txtDNI.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Activo = chkActivo.Checked,
                    RolClienteId = (int)cmbRolCliente.SelectedValue
                };

                int resultado = clienteLogica.agregarCliente(nuevoCliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            chkActivo.Checked = false;
        }
        private void CargarRolesCliente()
        {
            try
            {
                Conexion conexion = new Conexion();
                var tablaRoles = conexion.LeerPorComando("SELECT id, nombre FROM RolesCliente");

                cmbRolCliente.DataSource = tablaRoles;
                cmbRolCliente.DisplayMember = "nombre";
                cmbRolCliente.ValueMember = "id";
                cmbRolCliente.SelectedIndex = -1; // Para que no aparezca uno seleccionado por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PruebaCliente_Load(object sender, EventArgs e)
        {
            CargarRolesCliente();
        }
    }
}

