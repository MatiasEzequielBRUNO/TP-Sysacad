using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum NivelProfesor
    {
        ayudante,
        titular,
        jefeDeCatedra
    }
    public class Profesor
    {
        private string _idProfesor;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _clave;
        private NivelProfesor _nivelProfesor;
        private List<string> _materias = new List<string>();

        public Profesor(string idProfesor, string nombre, string apellido, string email, string clave, NivelProfesor nivelProfesor, List<string> materias)
        {
            _idProfesor = idProfesor;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _clave = clave;
            _nivelProfesor = nivelProfesor;
            _materias = materias;            
        }

    }
}
