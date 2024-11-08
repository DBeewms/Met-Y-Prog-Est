using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosPractica.Algoritmos;

namespace EjerciciosPractica.Formularios
{
    public partial class ParesImpares : Form
    
    {
        Funciones Funciones = new Funciones();
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        public ParesImpares()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNumerosPar.Items.Clear();
            lbNumeroImpar.Items.Clear();

            int numero = int.Parse(textBox1.Text);
            if (Funciones.verificarParImpar(numero))
            {
                pares.Add(numero);
            }
            else
            {
                impares.Add(numero);
            }

            for (int i = 0; i < pares.Count; i++)
            {
                lbNumerosPar.Items.Add(pares[i]);
                
            }

            for (int i = 0; i < impares.Count; i++)
            {
                lbNumeroImpar.Items.Add(impares[i]);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
