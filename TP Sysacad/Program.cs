using ClassLibrary1;
using System;
using System.IO;

namespace TP_Sysacad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flagLoop = true;

            string clave = Administrador.GeneradorContraseñas();
            Administrador admin = new Administrador("0", "juan", "pepe", "ikjasd@gmai.ae", clave, NivelAdmin.avanzado);

            while (flagLoop) 
            {
                Estudiante estudiante = Administrador.RegistrarEstudiante();

                string rutaArchivo = "E:\\OneDrive\\programacion\\facultad\\2 cuatrimestre\\TP\\TP Sysacad\\estudiantes.json";
                if (File.Exists(rutaArchivo))
                {
                    Console.WriteLine("encontrado");
                }
                else
                {
                    Console.WriteLine("mas vacio que el bcra");
                }
            }

            //string json = ManejadorDeArchivos.Serializador(estudiante);
            //ManejadorDeArchivos.GenerarArchivoJson(json, rutaArchivo, "estudiantes");
        }
    }
}
