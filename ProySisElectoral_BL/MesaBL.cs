using System.Data;
using ProySisElectoral_ADO;

namespace ProySisElectoral_BL
{
    public class MesaBL
    {
        MesaADO objADO = new MesaADO();
        public DataTable ListarMesa() { return objADO.ListarMesa(); }
        public bool InsertarMesa(string nombre, string direccion) { return objADO.InsertarMesa(nombre, direccion); }
    }
}