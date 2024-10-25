using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotiseriaDes.Class
{
    public class ApiEndpoints
    {

        public static string Cliente { get; set; } = "clientes";

        public static string Pedido { get; set; } = "pedidos";
        public static string Producto { get; set; } = "productos";
        public static string Proveedor { get; set; } = "proveedores";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Cliente) => Cliente,
                nameof(Pedido) => Pedido,
                nameof(Producto) => Producto,
                nameof(Proveedor) => Proveedor,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }

    }

}

