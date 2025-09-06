using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta1
{
    public class Producto
    {
        public string Nombre { get; set; }
        public long CodProducto { get; set; }
        public int PrecioUnitario { get; set; }
        public int stock { get; set; }

    }
}
