using System.Data;
using Microsoft.Data.SqlClient;

namespace ProySisElectoral_ADO
{
    public class MesaADO
    {
        public DataTable ListarMesa()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarMesa", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);
                }
            }
            return dt;
        }

        public bool InsertarMesa(string nombre, string direccion)
        {
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarMesa", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = direccion;
                    cnx.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}