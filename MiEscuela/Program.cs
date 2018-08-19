using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Program
    {
        public static void ImprimirMensajeEnPantalla(string mensaje)
        {
            Console.WriteLine("Respuesta del sistema: ");
            Console.WriteLine(mensaje);
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
