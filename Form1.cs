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
            this.Load += Form1_Load;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Llamar a ObtenerUfAsync() y ObtenerDolarAsync() de manera asincrónica
            string valorUF = await RequestIndicadores.ObtenerUfAsync();
            string valorDolar = await RequestIndicadores.ObtenerDolarAsync();

            // Mostrar los valores en tu aplicación (puedes elegir cómo mostrarlos, por ejemplo, en etiquetas o controles TextBox)
            lblValorUF.Text = "Valor de la UF: " + valorUF;
            lblValorDolar.Text = "Valor del Dólar: " + valorDolar;
            // Cargar la lista de clientes en el DataGridView
            CargarClientes();
        }
        private void CargarClientes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clienteController.ObtenerClientes();
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
                CargarClientes();

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

        //Metodo para cargar datos y luego modificar al cliente
        private void CargarClienteEnTextBox(Cliente cliente)
        {
            txtRut.Text = cliente.Rut;
            txtNombre.Text = cliente.Nombre;
            checkBox.Checked = cliente.Empresa;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            txtDate.Value = cliente.FechaRegistro;
            // También puedes cargar otras propiedades del cliente si es necesario
        }

        //Eliminar clientes
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor del RUT de la fila seleccionada
                string rut = dataGridView1.SelectedRows[0].Cells["Rut"].Value.ToString();

                // Llamar al método de eliminación del controlador
                clienteController.EliminarCliente(rut);

                // Actualizar DataGridView con la lista actualizada de clientes
                CargarClientes();
            }
        }
        //Modificar clientes
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor del RUT de la fila seleccionada
                string rut = dataGridView1.SelectedRows[0].Cells["Rut"].Value.ToString();

                // Obtener el cliente seleccionado del controlador
                Cliente clienteSeleccionado = clienteController.ObtenerClientePorRut(rut);

                // Cargar los datos del cliente seleccionado en los TextBox
                CargarClienteEnTextBox(clienteSeleccionado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor del RUT de la fila seleccionada
                string rut = dataGridView1.SelectedRows[0].Cells["Rut"].Value.ToString();

                // Obtener el cliente seleccionado del controlador
                Cliente clienteSeleccionado = clienteController.ObtenerClientePorRut(rut);

                // Cargar los datos del cliente seleccionado en los TextBox
                CargarClienteEnTextBox(clienteSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}