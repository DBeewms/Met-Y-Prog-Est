using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    internal class Asiento
    {
        public int Numero { get; set; }
        public bool Ocupado { get; set; }
        public string Seccion { get; set; }

        public Asiento(int numero, string seccion)
        {
            Numero = numero;
            Seccion = seccion;
            Ocupado = false;
        }

        public void Asignar()
        {
            Ocupado = true;
        }

        public string ImprimirPase()
        {
            return $"Asiento: {Numero} \t\t Seccion: {Seccion}\n";
        }
    }
}
