using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio2.Clases;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Avion avion = new Avion();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReservarAsiento_Click(object sender, EventArgs e)
        {
            int opcion = -1, inicio, final; // Declaracion de variables

            if (avion.AvionLleno()) //Primero checamos que el avion no este lleno
            {
                Limpiar();
                MessageBox.Show("El avion esta lleno, El siguiente vuelo sale en 3 horas", "Ups!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                //Verificamos que se haya seleccionado una seccion
                opcion = cmbSeccionAvion.SelectedIndex;
                if (opcion != -1)
                {
                    inicio = opcion == 0 ? 0 : 5;
                    final = opcion == 0 ? 5 : 10;

                    Limpiar();
                    AsignarAsiento(inicio, final);
                }
                else
                {
                    throw new Exception("Seleccionar una opcion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalido...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        public void AsignarAsiento(int inicio, int final)
        {
            int index;
            if ((index = avion.AsignarAsiento(inicio, final)) != -1)
            {
                avion.asientos[index].Asignar();
                tbAsientoVuelo.Text += avion.asientos[index].ImprimirPase();
            }
            else
            {
                MessageBox.Show("No hay asientos disponibles en la seccion seleccionada", "Invalido...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult result = MessageBox.Show("Asientos disponibles en otra seccion, ¿Asignar?",
                    "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    inicio = inicio == 0 ? 5 : 0;
                    final = final == 5 ? 10 : 5;

                    index = avion.AsignarAsiento(inicio, final);
                    avion.asientos[index].Asignar();
                    tbAsientoVuelo.Text += avion.asientos[index].ImprimirPase();
                }
                else
                {
                    MessageBox.Show("El siguiente vuelo sale en 3 horas", "Invalido...",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        public void Limpiar()
        {
            tbAsientoVuelo.Text = "";
            cmbSeccionAvion.SelectedIndex = -1;
        }
    }
}

