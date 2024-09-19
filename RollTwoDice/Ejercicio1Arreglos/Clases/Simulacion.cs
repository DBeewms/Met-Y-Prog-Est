using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio1Arreglos.Clases;

namespace Ejercicio1Arreglos.Clases
{
    internal class Simulacion
    {
        // Creacion de dos dados
        public Dado dadoN1;
        public Dado dadoN2;
        // Arreglo para almacenar valores de la frecuencia de suma
        public int[] frecuenciaSuma;

        public Simulacion()
        {
            frecuenciaSuma = new int[13];

            dadoN1 = new Dado();
            dadoN2 = new Dado();
        }

        // Reinicio de la frecuencia para la suma 2-12
        public void ReinicializarFrecuencia()
        {
            frecuenciaSuma = new int[13];  
        }

        // Tirar ambos dados y sumar
        public void SimularTiradas(int vecesALanzar)
        {
            ReinicializarFrecuencia();

            for (int i = 0; i < vecesALanzar; i++)
            {
                int suma = dadoN1.LanzarDado() + dadoN2.LanzarDado(); 
                frecuenciaSuma[suma]++;
            }
        }

        // Obtener frecuencias de suma
        public int[] GetFrecuencias()
        {
            return frecuenciaSuma;
        }
    }
}
