using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEjemplo3.Models
{
    public class Login
    {
        public bool LoggerUser(string user, string pass)
        {
            if (user == "admin" && pass == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
