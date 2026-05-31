using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProySisElectoral_BE;

namespace ProySisElectoral_ADO
{
    public class CandidatoADO
    {
        public DataTable ListarCandidato()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaVentas))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarCandidatos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataSet dts = new DataSet();
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dts, "Candidatos");
                    DataTable dtCandidatos = dts.Tables["Candidatos"];
                    dt = dtCandidatos;
                    return dt;
                }
            }
        }

        public bool InsertarCandidato(CandidatoBE obj)
        {
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaVentas))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCandidato", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombres", obj.nombres);
                    cmd.Parameters.AddWithValue("@apellidos", obj.apellidos);
                    cmd.Parameters.AddWithValue("@id_partido", obj.id_partido);
                    cmd.Parameters.AddWithValue("@id_eleccion", obj.id_eleccion);
                    cmd.Parameters.AddWithValue("@sexo", obj.sexo);
                    cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                    cmd.Parameters.AddWithValue("@Id_Ubigeo", obj.Id_Ubigeo);

                    cnx.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ActualizarCandidato(CandidatoBE obj)
        {
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaVentas))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarCandidato", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_candidato", obj.id_candidato);
                    cmd.Parameters.AddWithValue("@nombres", obj.nombres);
                    cmd.Parameters.AddWithValue("@apellidos", obj.apellidos);
                    cmd.Parameters.AddWithValue("@id_partido", obj.id_partido);
                    // ... añade aquí el resto de parámetros igual al Insertar ...

                    cnx.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public CandidatoBE ConsultarCandidato(Int16 intCodigo)
        {
            var objCandidatoBE = new CandidatoBE();
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaVentas))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_ConsultarCandidato", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id_candidato", SqlDbType.SmallInt).Value = intCodigo;

                        //Abrimos la conexion y ejecutamos
                        cnx.Open();
                        using (SqlDataReader dtr = cmd.ExecuteReader())
                        {
                            //CODIFIQUE
                            if (dtr.Read())
                            {
                                objCandidatoBE.id_candidato = Convert.ToInt16(dtr["id_candidato"]);
                                if (dtr["foto"] != DBNull.Value)
                                    objCandidatoBE.foto = (byte[])dtr["foto"];
                            }
                        } // cierra using cmd
                    } // cierra using cnx

                    return objCandidatoBE;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al consultar: {ex.Message}");
            }
        }


        public bool EliminarCandidato(Int32 id)
        {
            using (SqlConnection cnx = new SqlConnection(Configuracion.CadenaVentas))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarCandidato", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_candidato", id);

                    cnx.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}