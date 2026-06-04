using System.Data;
using System;
using ProySisElectoral_ADO;

namespace ProySisElectoral_BL
{
    public class UsuarioBL
    {
        UsuarioADO objADO = new UsuarioADO();

        public DataTable ListarUsuarios() { return objADO.ListarUsuarios(); }

        public bool InsertarUsuario(string dni, string nombres, string apellidos, int id_rol, string direccion, string sexo, DateTime fecha_nac, string id_ubigeo)
        {
            return objADO.InsertarUsuario(dni, nombres, apellidos, id_rol, direccion, sexo, fecha_nac, id_ubigeo);
        }
    }
} 