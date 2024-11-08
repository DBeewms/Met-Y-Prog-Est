using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosPractica.Formularios;

namespace EjerciciosPractica
{
    public partial class Form1 : Form
    {
        ParesImpares paresImpares = new ParesImpares();
        FormNombre formNombres = new FormNombre();


        public Form1()
        {
            InitializeComponent();
        }

        private void nNombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           formNombres.Show();
        }

        private void numerosParImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
           paresImpares.Show();
        }
    }
}
