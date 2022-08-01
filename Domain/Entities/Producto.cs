using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public DateTime FechaValidez { get; set; }
        public int CodigoProveedor { get; set; }
        public string DescripcionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
    }
}
