using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        int[] numeros = new int[100]; // Arreglo 
        int indice = 0;  // Numeros ingresados
        int suma = 0;    
        int mayor;       
        int menor;       
        bool primerNumero = true;  // Primer numero

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            // Validar si el valor ingresado es un número entero
            if (int.TryParse(tbNumeros.Text, out numero))
            {
                // Numero negativo, mostramos y detener el programa
                if (numero < 0)
                {
                    MessageBox.Show("Numero negativo... Deteniendo...");
                    MostrarResultados();
                    return;
                }

                // Inicializar mayor/menor
                if (primerNumero)
                {
                    mayor = numero;
                    menor = numero;
                    primerNumero = false;
                }
                else
                {
                    if (numero > mayor)
                        mayor = numero;
                    if (numero < menor)
                        menor = numero;
                }

                // Agregamos el número al arreglo y aumentamos el índice
                numeros[indice] = numero;
                indice++;

                // Sumamos el número ingresado
                suma += numero;

                // Limpiar TB
                tbNumeros.Clear();
                tbNumeros.Focus();

                lblResultado.Text = $"Suma hasta ahora: {suma}\nMayor hasta ahora: {mayor}\nMenor hasta ahora: {menor}";
            }
            else
            {
                MessageBox.Show("Invalido. Intenta de nuevo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Mostrar la suma, mayor y menor 
        private void MostrarResultados()
        {
            if (indice > 0)
            {
                lblResultado.Text = $"Suma: {suma}\nMayor: {mayor}\nMenor: {menor}";
            }
            else
            {
                lblResultado.Text = "No se ingresaron numeros.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
