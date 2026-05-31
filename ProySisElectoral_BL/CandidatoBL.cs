using ProySisElectoral_ADO;
using ProySisElectoral_BE;
using System.Data;
using System;

namespace ProySisElectoral_BL
{
    public class CandidatoBL
    {
        CandidatoADO objADO = new CandidatoADO();

        public DataTable ListarCandidato()
        {
            return objADO.ListarCandidato();
        }

        public bool InsertarCandidato(CandidatoBE obj)
        {
            return objADO.InsertarCandidato(obj);
        }

        public bool ActualizarCandidato(CandidatoBE obj)
        {
            return objADO.ActualizarCandidato(obj);
        }

        public bool EliminarCandidato(Int32 id)
        {
            return objADO.EliminarCandidato(id);
        }
    }
}