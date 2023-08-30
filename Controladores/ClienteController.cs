using Practico1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1.Controladores
{
    internal class ClienteController
    {
        private List<Cliente> listaClientes = new List<Cliente>();

        public void AgregarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
            }

            // Validaciones de datos aquí
            if (string.IsNullOrWhiteSpace(cliente.Rut))
            {
                throw new ArgumentException("El RUT del cliente no puede estar vacío o en blanco.", nameof(cliente.Rut));
            }

            if (listaClientes.Any(c => c.Rut == cliente.Rut))
            {
                throw new InvalidOperationException("Ya existe un cliente con ese RUT.");
            }

            listaClientes.Add(cliente);
        }

        public List<Cliente> ObtenerClientes()
        {
            return listaClientes;
        }

        public void EliminarCliente(string rut)
        {
            Cliente cliente = listaClientes.FirstOrDefault(c => c.Rut == rut);
            if (cliente != null)
            {
                listaClientes.Remove(cliente);
            }
        }

        public void EditarCliente(Cliente cliente)
        {
            Cliente clienteExistente = listaClientes.FirstOrDefault(c => c.Rut == cliente.Rut);
            if (clienteExistente != null)
            {
                // Actualizar propiedades editables
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Empresa = cliente.Empresa;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.FechaRegistro = cliente.FechaRegistro;
            }
        }

        public void IngresarUltimaFactura(string rut, int numeroFactura, int monto)
        {
            Cliente cliente = listaClientes.FirstOrDefault(c => c.Rut == rut);
            if (cliente != null)
            {
                // Actualizar propiedades relacionadas con facturación
                cliente.NumeroUltimaFactura = numeroFactura;
                cliente.MontoUltimaFactura = monto;
                cliente.CantidadFacturas += 1;
            }
        }
    }
}