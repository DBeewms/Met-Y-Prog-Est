using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Clases
{
    internal class Vendedor
    {
        public int Ventas { get; set; }
        public double Salario { get; set; }
        public int SalarioBase = 200;

        public Vendedor(int ventas)
        {
            Ventas = ventas;
            CalcularSalario();
        }

        public void CalcularSalario()
        {
            Salario = SalarioBase + (Ventas * 0.09);
        }

        public int ObtenerSalario()
        {
            return (int)Salario;
        }
    }
}
