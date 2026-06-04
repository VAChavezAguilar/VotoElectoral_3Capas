using System;

namespace ProySisElectoral_BE
{
    public class UsuarioBE
    {
        public Int32 id_usuario { get; set; }
        public String dni { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public Int32 id_rol { get; set; }
        public String direccion { get; set; }
        public String sexo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public String Id_Ubigeo { get; set; }
    }
}