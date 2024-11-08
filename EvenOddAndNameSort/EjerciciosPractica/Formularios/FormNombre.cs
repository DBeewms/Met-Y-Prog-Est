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
    
    public partial class FormNombre : Form
    {
        Funciones Funciones1 = new Funciones();
        List<string> nombres = new List<string>();
        List<string> nombresConJ = new List<string>();

        public FormNombre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNombresJ.Items.Clear();
            lbNombresNormales.Items.Clear();

            string nombre1 = textBox1.Text;

            if (Funciones1.verificarLetraJ(nombre1))
            {
                nombresConJ.Add(nombre1);
            }
            else
            {
                nombres.Add(nombre1);
            }

            for (int i = 0; i < nombresConJ.Count; i++)
            {
                lbNombresJ.Items.Add(nombresConJ[i]);
            }
            for (int i = 0; i < nombres.Count; i++)
            {
                lbNombresNormales.Items.Add(nombres[i]);
            }
        }
    }
}
