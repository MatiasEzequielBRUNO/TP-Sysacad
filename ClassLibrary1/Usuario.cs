using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Usuario
    {
        private string _correo;
        private string _clave;

        private Usuario(string correo, string clave)
        {
            _correo = correo;
            _clave = clave;
        }
    }
}
