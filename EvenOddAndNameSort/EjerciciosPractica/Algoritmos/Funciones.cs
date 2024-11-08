using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPractica.Algoritmos
{
    internal class Funciones
    {
        public bool verificarParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verificarLetraJ(string nombre)
        {
            if (nombre[0] == 'j' || nombre[0] == 'J')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
