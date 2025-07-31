using System;
using System.Collections.Generic;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_RelacionPermisoRol
    {
        private CD_RelacionPermisoRol objcd_relacion = new CD_RelacionPermisoRol();

        public bool AgregarRelacion(int idPermiso, int idRol)
        {
            return objcd_relacion.AgregarRelacion(idPermiso, idRol);
        }

        public bool EliminarTodosPorRol(int idRol)
        {
            return objcd_relacion.EliminarTodosPorRol(idRol);
        }

        public List<int> ListarIdPermisosPorRol(int idRol)
        {
            return objcd_relacion.ListarIdPermisosPorRol(idRol);
        }
    }
}
