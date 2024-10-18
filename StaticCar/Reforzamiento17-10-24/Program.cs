using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reforzamiento17_10_24.Clases;
using static Reforzamiento17_10_24.Clases.GestorAutos;

namespace Reforzamiento17_10_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro
            {
                historialReparaciones = new List<string>()
            };

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Inicializar carro");
                Console.WriteLine("2. Agregar reparación");
                Console.WriteLine("3. Mostrar carro");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        carro = InicializarCarro();
                        break;
                    case "2":
                        carro = AgregarReparacion(carro);
                        break;
                    case "3":
                        MostrarCarro(carro);
                        break;
                    case "4":
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
