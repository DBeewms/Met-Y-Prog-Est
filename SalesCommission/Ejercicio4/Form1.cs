using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio4.Clases;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobarRango_Click(object sender, EventArgs e)
        {
            try
            {
                int ventas = int.Parse(tbVentas.Text);
                Vendedor vendedor = new Vendedor(ventas);
                int salarioBase = vendedor.SalarioBase;

                tbVentas.Clear();

                empresa.ComprobarRangoSalario(vendedor);
                MessageBox.Show("Vendedor agregado.", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbSalario.Clear();


                tbSalario.Text = "$ " + vendedor.ObtenerSalario().ToString();

                lbListaRangos.Items.Clear();
                for (int rango = 0; rango < empresa.rangoSalarios.Length; rango++)
                {

                    lbListaRangos.Items.Add($"Rango {rango + 1}, Salario > {salarioBase}: {empresa.rangoSalarios[rango]}");
                    salarioBase += 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Atencion: {ex.Message}", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
