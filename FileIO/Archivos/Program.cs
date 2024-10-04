using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.OpenOrCreate, FileAccess.Write);
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota: ");
                    int nota = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el género: ");
                    char genero = char.Parse(Console.ReadLine());

                    Escritor.Write(nombre.Length); // Escribimos la longitud del nombre
                    Escritor.Write(nombre.ToCharArray()); // Escribimos el nombre como arreglo de caracteres
                    Escritor.Write(edad);
                    Escritor.Write(nota);
                    Escritor.Write(genero);
                }
            }

            FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read);
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
                while (mArchivoLector.Position != mArchivoLector.Length)
                {
                    int length = Lector.ReadInt32(); // Leemos la longitud del nombre
                    char[] nombreArray = Lector.ReadChars(length); // Leemos el nombre
                    string nombre = new string(nombreArray); // Convertimos a string
                    int edad = Lector.ReadInt32();
                    int nota = Lector.ReadInt32();
                    char genero = Lector.ReadChar();

                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Edad: " + edad);
                    Console.WriteLine("Nota: " + nota);
                    Console.WriteLine("Género: " + genero);
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}
