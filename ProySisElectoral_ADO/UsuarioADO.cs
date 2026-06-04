using System.Data;
using Microsoft.Data.SqlClient;

namespace ProySisElectoral_ADO
{
    public class UsuarioADO
    {
        // Ejemplo de Listar (asegúrate de que tu SP sp_ListarUsuarios exista en SQL)
        public DataTable ListarUsuarios()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarUsuarios", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);
                }
            }
            return dt;
        }

        public bool InsertarUsuario(string dni, string nombres, string apellidos, int id_rol, string direccion, string sexo, DateTime fecha_nac, string id_ubigeo)
        {
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@dni", SqlDbType.Char).Value = dni;
                    cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = nombres;
                    cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = apellidos;
                    cmd.Parameters.Add("@id_rol", SqlDbType.Int).Value = id_rol;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;
                    cmd.Parameters.Add("@sexo", SqlDbType.Char).Value = sexo;
                    cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = fecha_nac;
                    cmd.Parameters.Add("@Id_Ubigeo", SqlDbType.Char).Value = id_ubigeo;
                    cnx.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}