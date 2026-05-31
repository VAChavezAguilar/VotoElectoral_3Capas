using System;
using System.Collections.Generic;
using System.Text;

namespace 
    ProySisElectoral_BE
{
    public class CandidatoBE
    {
        public Int32 id_candidato { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public Int32 id_partido { get; set; }
        public Int32 id_eleccion { get; set; }
        public Byte[] foto { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public String sexo { get; set; }
        public String direccion { get; set; }
        public String Id_Ubigeo { get; set; }
    }
}
