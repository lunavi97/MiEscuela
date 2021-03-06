﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Profesor<Tipo> : Empleado<Tipo>
    {
        #region Atributos
        private string matricula;
        private FrecuenciaPago frecuenciaPago;
        #endregion

        #region Propiedades
        public string Matricula
        {
            get
            {
                return matricula + "_" + DateTime.Today.Year;
            }
            set
            {
                this.matricula = value;
            }
        }
        public Materia Materia { get; set; }
        public FrecuenciaPago FrecuenciaPago { get; set; }
        #endregion

        #region Métodos
        public string Chequear()
        {
            DateTime horaActual = DateTime.Now;
            // Guardar la hora en la BD
            string resp = "Hora de registro: " + horaActual;
            return resp;
        }

        public void AsignarMateria(Materia materia)
        {
            Materia = materia;
        }
        #endregion

        #region Constructor
        public Profesor()
        {
            this.Matricula = "_2018";
        }
        #endregion
    }
}
