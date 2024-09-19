using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Clases
{
    internal class Empresa
    {
        public double[,] TotalesVentas = new double[5, 4];

        public void AgregarVenta(Venta venta)
        {
            TotalesVentas[venta.IdProducto, venta.IdVendedor] += venta.Valor;
        }


        public double TotalVendedor(int vendedor)
        {
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += TotalesVentas[i, vendedor - 1];
            }
            return total;
        }


        public double TotalProducto(int producto)
        {
            double total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += TotalesVentas[producto - 1, i];
            }
            return total;
        }


        public double[,] MostrarVentas()
        {
            return TotalesVentas;
        }
    }
}

