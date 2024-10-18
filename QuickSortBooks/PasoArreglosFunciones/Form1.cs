using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasoArreglosFunciones.Clases;


namespace PasoArreglosFunciones
{
    public partial class Form1 : Form
    {
        List<NuevoLibro.Libro> listaLibros = new List<NuevoLibro.Libro>();


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

        private void Agregar_Click(object sender, EventArgs e)
        {
            NuevoLibro.Libro libro = new NuevoLibro.Libro();

            string titulo = tbTitulo.Text;
            string autor = tbAutor.Text;
            string anio = tbAnio.Text;

            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Anio = int.Parse(anio);

            listaLibros.Add(libro);

            tbTitulo.Text = "";
            tbAutor.Text = "";
            tbAnio.Text = "";

            tbTitulo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NuevoLibro.Libro libro = new NuevoLibro.Libro();

            string titulo = tbTitulo.Text;

            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (listaLibros[i].Titulo == titulo)
                {
                    tbAutor.Text = listaLibros[i].Autor;
                    tbAnio.Text = listaLibros[i].Anio.ToString();
                }
            }
        }

        private void btnOrdenarMostrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            QuickSort(listaLibros, 0, listaLibros.Count - 1);

            for (int i = 0; i < listaLibros.Count; i++)
            {
                NuevoLibro.Libro libro = listaLibros[i];
                listBox1.Items.Add(libro.Titulo + " - " + libro.Autor + " - " + libro.Anio);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int Particionar(List<NuevoLibro.Libro> libros, int bajo, int alto)
        {
            NuevoLibro.Libro pivote = libros[alto];
            int i = bajo - 1;

            for (int j = bajo; j < alto; j++)
            {
                if (libros[j].Anio < pivote.Anio)
                {
                    i++;
                    Intercambiar(libros, i, j);
                }
            }

            Intercambiar(libros, i + 1, alto);

            return i + 1;
        }

        private void Intercambiar(List<NuevoLibro.Libro> libros, int i, int j)
        {
            NuevoLibro.Libro temp = libros[i];
            libros[i] = libros[j];
            libros[j] = temp;
        }

        private void QuickSort(List<NuevoLibro.Libro> libros, int bajo, int alto)
        {
            if (bajo < alto)
            {
                int indicePivote = Particionar(libros, bajo, alto);

                QuickSort(libros, bajo, indicePivote - 1);
                QuickSort(libros, indicePivote + 1, alto);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
