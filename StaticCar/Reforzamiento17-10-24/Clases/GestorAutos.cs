using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reforzamiento17_10_24.Clases
{
    internal class GestorAutos
    {
        public struct Carro
        {
            public string marca;
            public string modelo;
            public int anio;
            public string color;

            public List<string> historialReparaciones;
        }

        public static Carro InicializarCarro()
        {
            Carro carro = new Carro();

            Console.WriteLine("Ingrese la marca del carro:");
            carro.marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del carro:");
            carro.modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el año del carro:");
            carro.anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el color del carro:");
            carro.color = Console.ReadLine();

            carro.historialReparaciones = new List<string>();

            return carro;
        }

        public static Carro AgregarReparacion(Carro carro)
        {
            Console.WriteLine("Ingrese la reparación realizada:");
            string reparacion = Console.ReadLine();

            carro.historialReparaciones.Add(reparacion);

            return carro;
        }

        public static void MostrarCarro(Carro carro)
        {
            Console.WriteLine("Marca: " + carro.marca);
            Console.WriteLine("Modelo: " + carro.modelo);
            Console.WriteLine("Año: " + carro.anio);
            Console.WriteLine("Color: " + carro.color);

            Console.WriteLine("Historial de reparaciones:");

            for (int i = 0; i < carro.historialReparaciones.Count; i++)
            {
                Console.WriteLine(carro.historialReparaciones[i]);
            }
        }
    }
}
