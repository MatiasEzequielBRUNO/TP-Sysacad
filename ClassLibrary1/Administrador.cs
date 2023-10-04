using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace ClassLibrary1
{
    public enum NivelAdmin
    {
        basico,
        intermedio,
        avanzado
    }
    public class Administrador
    {
        private string _idAdmin;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _clave;
        private NivelAdmin _nivelAdmin;

        public Administrador(string idAdmin, string nombre, string apellido, string email, string clave,NivelAdmin nivelAdmin)
        {
            _idAdmin = idAdmin;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _clave = clave;
            _nivelAdmin = nivelAdmin;
        }

        public static string GeneradorContraseñas()
        {
            string contrasenia = string.Empty;

            int longitudCodigo = 8; // Cambia la longitud del código según tus necesidades
            Random random = new Random();

            char[] codigo = new char[longitudCodigo];

            for (int i = 0; i < longitudCodigo; i++)
            {
                int valorAscii = random.Next(41, 126); // para solo letras mayusculas 65-91
                codigo[i] = (char)valorAscii;
            }

            contrasenia = new string(codigo);

            return contrasenia;
        }

        public static Estudiante RegistrarEstudiante()
        {
            int contadorLegajo = 0;

            int legajo = contadorLegajo++;  //no hacemos parse porque no hay operaciones matematicas
            
            Console.WriteLine("\nIngrese nombre del estudiante");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("\nIngrese apellido del estudiante");
            string apellido = Console.ReadLine();
           
            Console.WriteLine("\nIngrese email del estudiante");
            string email = Console.ReadLine();      //heredar de usuario
            
            Console.WriteLine("\nIngrese direccion del estudiante");
            string direccion = Console.ReadLine();
            
            Console.WriteLine("\nIngrese numero de telefono del estudiante");
            string numeroDeTelefono = Console.ReadLine();

            string contraseniaProvisional = GeneradorContraseñas();     //heredar de usuario

            Console.WriteLine("\nIngrese DNI del estudiante");
            string DNI = Console.ReadLine();

            Estudiante estudiante = new Estudiante(legajo, nombre, apellido, email, contraseniaProvisional, direccion, numeroDeTelefono, DNI);

            return estudiante;
        }   

    }

}