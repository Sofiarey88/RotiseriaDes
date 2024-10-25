using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotiseriaDes.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = string.Empty;

        // Relación con Cliente
        public Cliente Cliente { get; set; }
    }
}

