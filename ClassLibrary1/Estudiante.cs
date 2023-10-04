using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{ 
    public class Estudiante
    {
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _clave;
        private string _direccion;
        private Dictionary<string, int> _historialAcademico;
        private string _numeroDeTelefono;
        private string _DNI;

        public Estudiante(int legajo, string nombre, string apellido, string email, string clave, string direccion, string numeroDeTelefono, string DNI)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _clave = clave;
            _direccion = direccion;
            _numeroDeTelefono = numeroDeTelefono;
            _DNI = DNI;
            _historialAcademico = new Dictionary<string, int>();

        }

        public int Legajo { get => _legajo; set => _legajo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public Dictionary<string, int> HistorialAcademico { get => _historialAcademico; set => _historialAcademico = value; }
        public string NumeroDeTelefono { get => _numeroDeTelefono; set => _numeroDeTelefono = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
    }
}

