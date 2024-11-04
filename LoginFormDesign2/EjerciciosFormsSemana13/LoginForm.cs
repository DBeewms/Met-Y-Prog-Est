using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosFormsSemana13.Servicios;
using EjerciciosFormsSemana13.Formularios;

namespace EjerciciosFormsSemana13
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        UsuarioServicio usuarioServicio = new UsuarioServicio();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string admin = tbUser.Text.Trim();
            string pass = tbPass.Text.Trim();
            MenuPrincipal menu = new MenuPrincipal();

            try
            {

                if (string.IsNullOrEmpty(tbUser.Text.Trim()) || string.IsNullOrWhiteSpace(tbUser.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "Ingresa el usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (usuarioServicio.validarUsuario(admin, pass))

                {
                    MetroMessageBox.Show(this, "Bienvenido");
                    menu.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
