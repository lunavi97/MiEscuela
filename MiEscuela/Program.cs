using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Program
    {
        public static void ImprimirMensajeEnPantalla(string mensaje, bool guardar = false)
        {
            Console.WriteLine("Respuesta del sistema: ");
            Console.WriteLine(mensaje);
            if (guardar)
            {
                // Guardar mensaje en BD
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Sistema de Administración Escolar";

            Profesor<int> profesorInterno = new Profesor<int>();
            string resp = profesorInterno.Chequear();
            ImprimirMensajeEnPantalla(resp);

            Profesor<string> profesorExterno = new Profesor<string>();
            resp = profesorExterno.Chequear();
            ImprimirMensajeEnPantalla(resp);

            Console.WriteLine("Ingrese el nombre del estudiante: ");
            string nombreEstudiante = Console.ReadLine();

            Console.WriteLine("Ingrese grado y grupo");
            string gradoGrupo = Console.ReadLine();

            Estudiante estudiante = new Estudiante(nombreEstudiante, gradoGrupo);

            Console.ReadKey();
        }
    }
}
