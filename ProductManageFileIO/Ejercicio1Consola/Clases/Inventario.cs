using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Consola.Clases
{
    internal class Inventario
    {
        struct Producto
        {
            public int Codigo;
            public string Nombre;
            public int Cantidad;
            public decimal Precio;
        }

        private Producto[] inventario = new Producto[100];
        private int contadorProductos = 0;
        private const string archivoInventario = "inventario.dat";

        public void AgregarProducto()
        {
            if (contadorProductos >= inventario.Length)
            {
                Console.WriteLine("Inventario lleno.");
                return;
            }

            Producto nuevoProducto;
            Console.Write("Ingrese el código del producto: ");
            nuevoProducto.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            nuevoProducto.Nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            nuevoProducto.Cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio del producto: ");
            nuevoProducto.Precio = decimal.Parse(Console.ReadLine());

            inventario[contadorProductos] = nuevoProducto;
            contadorProductos++;
            Console.WriteLine("Producto agregado exitosamente.");
        }

        public void EliminarProducto()
        {
            Console.Write("Ingrese el código del producto a eliminar: ");
            int codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < contadorProductos; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    for (int j = i; j < contadorProductos - 1; j++)
                    {
                        inventario[j] = inventario[j + 1];
                    }
                    contadorProductos--;
                    Console.WriteLine("Producto eliminado exitosamente.");
                    return;
                }
            }
            Console.WriteLine("Producto no encontrado.");
        }

        public void ModificarProducto()
        {
            Console.Write("Ingrese el código del producto a modificar: ");
            int codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < contadorProductos; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    Console.Write("Ingrese el nuevo nombre del producto: ");
                    inventario[i].Nombre = Console.ReadLine();
                    Console.Write("Ingrese la nueva cantidad del producto: ");
                    inventario[i].Cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el nuevo precio del producto: ");
                    inventario[i].Precio = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Producto modificado exitosamente.");
                    return;
                }
            }
            Console.WriteLine("Producto no encontrado.");
        }

        public void ConsultarProducto()
        {
            Console.Write("Ingrese el código del producto a consultar: ");
            int codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < contadorProductos; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    Console.WriteLine($"Código: {inventario[i].Codigo}");
                    Console.WriteLine($"Nombre: {inventario[i].Nombre}");
                    Console.WriteLine($"Cantidad: {inventario[i].Cantidad}");
                    Console.WriteLine($"Precio: {inventario[i].Precio}");
                    return;
                }
            }
            Console.WriteLine("Producto no encontrado.");
        }

        public void MostrarTodosLosProductos()
        {
            for (int i = 0; i < contadorProductos; i++)
            {
                Console.WriteLine($"Código: {inventario[i].Codigo}");
                Console.WriteLine($"Nombre: {inventario[i].Nombre}");
                Console.WriteLine($"Cantidad: {inventario[i].Cantidad}");
                Console.WriteLine($"Precio: {inventario[i].Precio}");
                Console.WriteLine("----------------------------");
            }
        }

        public void GuardarInventario()
        {
            using (FileStream fs = new FileStream(archivoInventario, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(contadorProductos);
                    for (int i = 0; i < contadorProductos; i++)
                    {
                        writer.Write(inventario[i].Codigo);
                        writer.Write(inventario[i].Nombre);
                        writer.Write(inventario[i].Cantidad);
                        writer.Write(inventario[i].Precio);
                    }
                }
            }
        }

        public void CargarInventario()
        {
            if (File.Exists(archivoInventario))
            {
                using (FileStream fs = new FileStream(archivoInventario, FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        contadorProductos = reader.ReadInt32();
                        for (int i = 0; i < contadorProductos; i++)
                        {
                            inventario[i].Codigo = reader.ReadInt32();
                            inventario[i].Nombre = reader.ReadString();
                            inventario[i].Cantidad = reader.ReadInt32();
                            inventario[i].Precio = reader.ReadDecimal();
                        }
                    }
                }
            }
        }

    }
}
