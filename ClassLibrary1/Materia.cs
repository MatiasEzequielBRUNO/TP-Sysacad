using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Materia
    {
        private string _idMateria;
        private string _cargaHoraria;
        private string _aula;
        private string _nombre;
        private string _docente;
        private string _cupos;
        private string _horario;
        private string _turno;
        private string _estado;

        public Materia (string idMateria, string cargaHoraria, string aula, string nombre, string docente, string cupos, string horario, string turno, string estado)
        {
            _idMateria = idMateria;
            _cargaHoraria = cargaHoraria;
            _aula = aula;
            _nombre = nombre;
            _docente = docente;
            _cupos = cupos;
            _horario = horario;
            _turno = turno;
            _estado = estado;
        }
    }
}
