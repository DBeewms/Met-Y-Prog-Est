using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioReforzamientoForms.Clases
{
    internal class Inventario
    {
        public struct Producto
        {
            public int Codigo;
            public string Nombre;
            public int Cantidad;
            public decimal Precio;
        }

        private Producto[] inventario = new Producto[100];
        private int contadorProductos = 0;
        private const string archivoInventario = "inventario.dat";

        public string AgregarProducto(int codigo, string nombre, int cantidad, decimal precio)
        {
            if (contadorProductos >= inventario.Length)
            {
                return "Inventario lleno.";
            }

            Producto nuevoProducto = new Producto
            {
                Codigo = codigo,
                Nombre = nombre,
                Cantidad = cantidad,
                Precio = precio
            };

            inventario[contadorProductos] = nuevoProducto;
            contadorProductos++;
            return "Producto agregado exitosamente.";
        }

        public string EliminarProducto(int codigo)
        {
            for (int i = 0; i < contadorProductos; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    for (int j = i; j < contadorProductos - 1; j++)
                    {
                        inventario[j] = inventario[j + 1];
                    }
                    contadorProductos--;
                    return "Producto eliminado exitosamente.";
                }
            }
            return "Producto no encontrado.";
        }

        public string ModificarProducto(int codigo, string nombre, int cantidad, decimal precio)
        {
            for (int i = 0; i < contadorProductos; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    inventario[i].Nombre = nombre;
                    inventario[i].Cantidad = cantidad;
                    inventario[i].Precio = precio;
                    return "Producto modificado exitosamente.";
                }
            }
            return "Producto no encontrado.";
        }

        public Producto ConsultarProducto(int codigo)
        {
            for (int i = 0; i < contadorProductos; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    return inventario[i];
                }
            }

            // Producto no encontrado
            return new Producto { Codigo = -1, Nombre = "No encontrado", Cantidad = 0, Precio = 0.0m };
        }

        public Producto[] MostrarTodosLosProductos()
        {
            Producto[] productos = new Producto[contadorProductos];
            for (int i = 0; i < contadorProductos; i++)
            {
                productos[i] = inventario[i];
            }
            return productos;
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
