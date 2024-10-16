using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioReforzamientoForms.Clases;

namespace EjercicioReforzamientoForms
{
    public partial class Form1 : Form
    {
        private Inventario inventario;

        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbIDProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbIDProducto.Text);
            string nombre = tbNombreProducto.Text;
            int cantidad = int.Parse(tbCantidad.Text);
            decimal precio = decimal.Parse(tbPrecio.Text);

            string mensaje = inventario.AgregarProducto(codigo, nombre, cantidad, precio);
            MessageBox.Show(mensaje);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbIDProducto.Text);
            string nombre = tbNombreProducto.Text;
            int cantidad = int.Parse(tbCantidad.Text);
            decimal precio = decimal.Parse(tbPrecio.Text);

            string mensaje = inventario.ModificarProducto(codigo, nombre, cantidad, precio);
            MessageBox.Show(mensaje);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbIDProducto.Text);
            string mensaje = inventario.EliminarProducto(codigo);
            MessageBox.Show(mensaje);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(tbIDProducto.Text);
            Inventario.Producto producto = inventario.ConsultarProducto(codigo);


            if (producto.Codigo != -1)
            {
                tbNombreProducto.Text = producto.Nombre;
                tbCantidad.Text = producto.Cantidad.ToString();
                tbPrecio.Text = producto.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbProductos.Items.Clear();
            var productos = inventario.MostrarTodosLosProductos();
            for (int i = 0; i < productos.Length; i++)
            {
                var producto = productos[i];
                lbProductos.Items.Add($"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Cantidad: {producto.Cantidad}, Precio: {producto.Precio}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
