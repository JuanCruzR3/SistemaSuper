using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_RelacionPermisoRol
    {
        public bool AgregarRelacion(int idPermiso, int idRol)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO RelacionPermisoRol (IdPermiso, IdRol) VALUES (@IdPermiso, @IdRol)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdPermiso", idPermiso);
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    con.Open();
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    // Manejo opcional de errores
                    resultado = false;
                }
            }

            return resultado;
        }

        public bool EliminarTodosPorRol(int idRol)
        {
            bool resultado = false;

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM RelacionPermisoRol WHERE IdRol = @IdRol";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    con.Open();
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    resultado = false;
                }
            }

            return resultado;
        }

        public List<int> ListarIdPermisosPorRol(int idRol)
        {
            List<int> lista = new List<int>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdPermiso FROM RelacionPermisoRol WHERE IdRol = @IdRol";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(Convert.ToInt32(dr["IdPermiso"]));
                    }

                    dr.Close();
                }
                catch (Exception ex)
                {
                    lista = new List<int>();
                }
            }

            return lista;
        }
    }
}
