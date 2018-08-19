using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Estudiante
    {
        #region Atributos
        private int id;
        private string matricula;
        private string nombre;
        private string gradoGrupo;
        private bool estatus;
        #endregion

        #region Propiedades
        public int Id { get; }
        public string Matricula { get; }
        public string Nombre { get; set; }
        public string GradoGrupo { get; set; }
        public bool Estatus { get; set; }
        #endregion

        #region Métodos
        public string Registrar()
        {
            // Registro en la BD
            string resp = "Estudiante registrado";
            return resp;
        }

        public string DarDeBaja()
        {
            this.Estatus = false;
            // Editar el registro en la BD
            string resp = "Estudiante dado de baja";
            return resp;
        }

        public string DarDeBaja(string motivo)
        {
            this.Estatus = false;
            // Editar el registro en la BD agregando motivo
            string resp = "Estudiante dado de baja. Motivo: " + motivo;
            return resp;
        }

        public void DarDeBaja(string usuario, string clave, string motivo)
        {
            // Verificar que el usuario cuente con los permisos requeridos
            // Si el usuario cumple:
            // Eliminar el registro del estudiante
            // Guardar el movimiento en un log
        }
        #endregion

        #region Constructor
        public Estudiante(string nombre, string gradoGrupo)
        {
            Nombre = nombre;
            GradoGrupo = gradoGrupo;
        }
        #endregion
    }
}
