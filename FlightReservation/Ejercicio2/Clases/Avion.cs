using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    internal class Avion
    {
        public Asiento[] asientos = new Asiento[10];

        public Avion()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i < 5) asientos[i] = new Asiento(i + 1, "Fumadores");
                else asientos[i] = new Asiento(i + 1, "No Fumadores");
            }
        }


        public int AsignarAsiento(int inicio, int fin)
        {

            for (int i = inicio; i < fin; i++)
            {
                if (!asientos[i].Ocupado)
                {
                    return i;
                }
            }
            return -1;

        }


        public bool AvionLleno()
        {
            foreach (Asiento asiento in asientos)
            {
                if (!asiento.Ocupado) return false;
            }
            return true;
        }
    }
}
