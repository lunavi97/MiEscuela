using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public class Profesor : Empleado
    {
        #region Atributos
        private string matricula;
        private Materia materia;
        private FrecuenciaPago frecuenciaPago;
        #endregion

        #region Propiedades
        public string Matricula
        {
            get
            {
                return matricula + "_" + DateTime.Today.Year;
            }
        }
        public FrecuenciaPago FrecuenciaPago { get; set; }
        #endregion

        #region Métodos
        #endregion
    }
}
