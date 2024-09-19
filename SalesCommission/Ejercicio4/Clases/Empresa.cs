using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Clases
{
    internal class Empresa
    {
        public int[] rangoSalarios = new int[9];

        public void ComprobarRangoSalario(Vendedor vendedor)
        {
            int salarioVendedor = vendedor.ObtenerSalario();
            int salarioBase = vendedor.SalarioBase;

            if (salarioVendedor >= salarioBase)
            {
                for (int i = 0; i < 9; i++)
                {
                    int limiteInferior = i * 100 + 200;

                    int limiteSuperior;
                    if (i == 8)
                    {
                        limiteSuperior = int.MaxValue;
                    }
                    else
                    {
                        limiteSuperior = limiteInferior + 99;
                    }

                    if (salarioVendedor >= limiteInferior && salarioVendedor <= limiteSuperior)
                    {
                        rangoSalarios[i]++;
                        break;
                    }
                }
            }
        }
    }
}
