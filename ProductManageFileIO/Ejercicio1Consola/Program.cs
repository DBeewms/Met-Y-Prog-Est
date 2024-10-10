using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ejercicio1Consola.Clases;

namespace Ejercicio1Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario.CargarInventario();
            int opcion;
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("4. Consultar producto");
                Console.WriteLine("5. Mostrar todos los productos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inventario.AgregarProducto();
                        break;
                    case 2:
                        inventario.EliminarProducto();
                        break;
                    case 3:
                        inventario.ModificarProducto();
                        break;
                    case 4:
                        inventario.ConsultarProducto();
                        break;
                    case 5:
                        inventario.MostrarTodosLosProductos();
                        break;
                    case 6:
                        inventario.GuardarInventario();
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 6);
        }
    }
}
