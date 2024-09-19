using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Arreglos.Clases
{
    internal class Dado
    {
        // Instancia de Random para asignacion de un lado para el dado

        private static Random randomDado = new Random();

        // Metodo para lanzar el dado y obtener el valor de su lado
        public int LanzarDado() 
        {
            return randomDado.Next(1, 7);
        }
    }
}
