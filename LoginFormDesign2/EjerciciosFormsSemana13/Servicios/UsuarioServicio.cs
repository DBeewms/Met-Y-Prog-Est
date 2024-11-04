using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFormsSemana13.Servicios
{
    internal class UsuarioServicio
    {
        internal bool validarUsuario(string admin, string contraseña)
        {
            if (admin == "admin" && contraseña == "1234")
            {
                return true;
            }
            return false;
        }
    }
}
