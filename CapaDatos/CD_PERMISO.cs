using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            var lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Lee permisos del rol del usuario usando la tabla de relación
                    // Consulta correcta para CD_Permiso.cs Listar(int idusuario):
                    string query = @"
    SELECT p.IdPermiso, p.NombreMenu
    FROM USUARIO u
    INNER JOIN ROL r ON r.IdRol = u.IdRol
    INNER JOIN RelacionPermisoRol rr ON rr.IdRol = r.IdRol  -- Usa la nueva tabla
    INNER JOIN PERMISO p ON p.IdPermiso = rr.IdPermiso
    WHERE u.IdUsuario = @idusuario";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@idusuario", idusuario);

                        oconexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Permiso
                                {
                                    IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                    NombreMenu = dr["NombreMenu"].ToString()
                                });
                            }
                        }
                    }
                }
                catch
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;
        }

        public List<Permiso> ListarTodos()
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdPermiso, NombreMenu FROM PERMISO";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                NombreMenu = dr["NombreMenu"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
