using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Clases
{
    internal class Venta
    {
        public int IdVendedor { get; }
        public int IdProducto { get; }
        public int Valor { get; }


        public Venta(int vendedor, int producto, int cantidad)
        {
            IdVendedor = vendedor;
            IdProducto = producto;
            Valor = cantidad;
        }
    }
}
