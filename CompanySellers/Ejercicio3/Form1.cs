using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio3.Clases;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Guardado de una venta
        public void GuardarVenta()
        {
            Venta venta;
            int vendedor, producto, valor;

            try
            {
                vendedor = Convert.ToInt32(cmbVendedorID.SelectedItem);
                producto = Convert.ToInt32(cmbProductoID.SelectedItem);
                if (Convert.ToInt32(tbValorDolares.Text) < 0)
                {
                    throw new Exception("Valor invalido: Negativo.");
                }
                valor = Convert.ToInt32(tbValorDolares.Text);

                venta = new Venta(vendedor - 1, producto - 1, valor);

                empresa.AgregarVenta(venta);

                LimpiarDRegistro();

                MessageBox.Show("Venta guardada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void MostrarVentas()
        {
            // Limpiar DataGridView 
            dgvTabla.Rows.Clear();
            dgvTabla.Columns.Clear();

            // Mostrar resultados
            AgregarColumnaVendedor();
            MostrarProductoMostrarVendedor();
            MostrarTotalProducto();
            MostrarTotalVendedor();
        }


        public void AgregarColumnaVendedor()
        {
            // Para cada vendedor
            dgvTabla.Columns.Add("Producto", "Producto");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                dgvTabla.Columns.Add("Vendedor" + (vendedor + 1), "Vendedor " + (vendedor + 1));
            }
        }


        public void MostrarProductoMostrarVendedor()
        {

            // Productos y las ventas totales
            double[,] ventas = empresa.MostrarVentas();
            for (int producto = 0; producto < 5; producto++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvTabla);
                row.Cells[0].Value = producto + 1;
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    row.Cells[vendedor + 1].Value = ventas[producto, vendedor];
                }

                dgvTabla.Rows.Add(row);
            }
        }


        public void MostrarTotalProducto()
        {
            //Agregar total producto
            dgvTabla.Columns.Add(ToString(), "Total Producto en $");
            for (int producto = 0; producto < 5; producto++)
            {
                double total = empresa.TotalProducto(producto + 1);
                dgvTabla.Rows[producto].Cells[5].Value = total;
            }
        }
        public void MostrarTotalVendedor()
        {
            //Agregar Total Vendedor
            dgvTabla.Rows.Add("Total Vendedor en $");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                double total = empresa.TotalVendedor(vendedor + 1);
                dgvTabla.Rows[5].Cells[vendedor + 1].Value = total;
            }
        }

        // Limpiado de registros
        public void LimpiarDRegistro()
        {
            cmbProductoID.SelectedIndex = -1; 
            cmbVendedorID.SelectedIndex = -1; 
            tbValorDolares.Text = ""; 

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarVenta();
            MostrarVentas();
        }
    }
}
