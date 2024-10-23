using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMentoria2310
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, total;

                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);

                total = num1 + num2;

                lblResultado.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al sumar los números, verifica si los valores son números");
            }
        }
    }
}
