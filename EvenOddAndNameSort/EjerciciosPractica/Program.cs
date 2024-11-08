using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPractica
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //Elabore la un programa que lea N cantidad de números, guarde en lista separadas 
            //    los pares e impares.
            //Elabore un programa que lea N cantidad e nombres no minimo de 10 letras no maximo 
            //    de 60 letras guardar en lista separadas los que comienzan con j.
        }
    }
}
