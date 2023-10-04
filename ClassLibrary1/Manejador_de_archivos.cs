using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ManejadorDeArchivos
    {
        public static string GenerarArchivoJson(string datos, string rutaArchivo, string nombreArchivo)
        {
            string rutaArchivoJson = $"{rutaArchivo}{nombreArchivo}.json";
            File.WriteAllText(rutaArchivoJson, datos);
            Console.WriteLine("Archivo JSON creado exitosamente.");

            return rutaArchivoJson;
        }

        public static string Serializador(object datos)
        {
            string json = JsonConvert.SerializeObject(datos);
            return json;
        }

        public static void LeerArchivoJson(string rutaArchivoJson) 
        {
            try
            {
                string json = File.ReadAllText(rutaArchivoJson);
            }

            catch (FileNotFoundException) 
            {
                Console.WriteLine("Archivo JSON no encontrdado.");
            }
                
        }

        public static bool ValidarLegajoEstudiantes(List<Estudiante> datosAComparar, int valor)
        {
            foreach (Estudiante elemento in datosAComparar)
            {
                if (elemento.Legajo == valor)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidarEmailEstudiante(List<Estudiante> datosAComparar, string valor)
        {
            foreach (Estudiante elemento in datosAComparar)
            {
                if (elemento.Email == valor)
                {
                    return true;
                }
            }

            return false;
        }

        //public static bool ValidarXXXXProfesor(List<Profesor> datosAComparar)       // ver que hay que validar en los profes
        //{
        //    foreach (Dictionary<string, string> elemento in datosAComparar)
        //    {
        //        foreach (string valor in elemento.Keys)
        //        {
        //            if
        //        }
        //    }
        //}
    }
}
