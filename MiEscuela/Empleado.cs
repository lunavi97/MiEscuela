using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public enum FrecuenciaPago
    {
        Quincenal,
        Mensual,
        Bimestral
    }

    public class Empleado
    {
        #region Atributos
        private int id;
        private string nombre;
        private bool activo;
        private int edad;
        private string nacionalidad;
        private decimal pago;
        #endregion

        #region Propiedades
        public int Id { get; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Pago { get; }
        #endregion

        #region Métodos
        public void CalcularPago()
        {

        }
        #endregion
    }
}
