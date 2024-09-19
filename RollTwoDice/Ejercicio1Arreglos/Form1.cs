using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio1Arreglos.Clases;

namespace Ejercicio1Arreglos
{
    public partial class Form1 : Form
    {
        Simulacion simulacion = new Simulacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTablaResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            simulacion.SimularTiradas(36000);
           
            int[] frecuencias = simulacion.GetFrecuencias();

            
            // Limpiar datos anteriores
            LimpiarResultados();

            // Configuracion de columnas
            if (dgvTablaResultados.Columns.Count == 0)
            {
                dgvTablaResultados.Columns.Add("Suma", "Suma");
                dgvTablaResultados.Columns.Add("Frecuencia", "Frecuencia");
            }

            // Agregar los resultados a la tabla
            for (int i = 2; i < frecuencias.Length; i++)
            {
                dgvTablaResultados.Rows.Add(i, frecuencias[i]);
            }

            // Comprobar si la suma 7 se aproxima al 16.67% de las tiradas
            double probabilidad7 = (double)frecuencias[7] / 36000;
            tbProbabilidades.Text = $"\nFrecuencia estimada de la suma 7: {frecuencias[7]} veces.\n";
            tbProbabilidadesDe7.Text = $"\nProbabilidad estimada de la suma 7: {probabilidad7:P2}";
        }

        public void LimpiarResultados()
        {
            dgvTablaResultados.Rows.Clear();
            tbProbabilidades.Clear();
            tbProbabilidadesDe7.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
