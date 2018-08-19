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

            Profesor profesor = new Profesor();
            string resp = profesor.Chequear();
            ImprimirMensajeEnPantalla(resp);

            Console.ReadKey();
        }
    }
}
