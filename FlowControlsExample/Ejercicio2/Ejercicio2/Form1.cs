using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        string[] nombres = new string[25]; // Arreglo de 25 nombres
        int indice = 0; // Contador de nombres ingresados

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (indice < 25)
            {
                nombres[indice] = tbInputNombres.Text; // Guardar el nombre
                indice++; 
                tbInputNombres.Clear(); 
                tbInputNombres.Focus(); 
            }
            else
            {
                MessageBox.Show("Ya se ingresaron los 25 nombres.");
            }
        }


        // Mostrar nombres con mas de 25 caracteres en el ListBox
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbNombres.Items.Clear(); // Limpiar

            int i = 0; 
            while (i < indice) 
            {
                if (nombres[i].Length > 25) // Nombres con mas de 25 caracteres
                {
                    lbNombres.Items.Add(nombres[i]); // Agregar
                }
                i++; 
            }

            if (lbNombres.Items.Count == 0)
            {
                MessageBox.Show("No hay nombres con mas de 25 caracteres.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
