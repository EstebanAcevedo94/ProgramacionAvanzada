using System;
using System.Windows.Forms;
using Practico1.Modelos;
using Practico1.Controladores;

namespace Practico1
{
    public partial class Form1 : Form
    {
        private ClienteController clienteController = new ClienteController();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar el RUT ingresado
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("El RUT no puede estar vacío o en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener datos de la interfaz de usuario y crear un objeto Cliente
            Cliente nuevoCliente = new Cliente
            {
                Rut = txtRut.Text,
                Nombre = txtNombre.Text,
                Empresa = checkBox.Checked,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                FechaRegistro = txtDate.Value,
                // Inicializar otras propiedades si es necesario
            };

            try
            {
                // Agregar el nuevo cliente usando el controlador
                clienteController.AgregarCliente(nuevoCliente);

                // Actualizar DataGridView con la lista actualizada de clientes
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clienteController.ObtenerClientes();

                // Limpiar campos de entrada después de agregar
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Método para limpiar los campos de entrada
        private void LimpiarCampos()
        {
            txtRut.Clear();
            txtNombre.Clear();
            checkBox.Checked = false;
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDate.Value = DateTime.Now;
        }
        // Otros eventos y métodos de la interfaz gráfica
    }
}