using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ProySisElectoral_ADO
{
    

    public static class Configuracion
    {
        // Manejamos una propiedad que implemente la interfaz IConfiguration
        private static IConfiguration _config;

        //Definimos el constructor de la clase, para que lea el contenido de todo lo 
        // declarado en appsettings.json
        static Configuracion()
        {
            try
            {
                // Configuramos el constructor para leer el archivo JSON
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                _config = builder.Build();
            }
            catch (Exception ex)
            {
                // Si el archivo json no existe o está mal formado, lanzamos un error claro
                throw new Exception("Error al inicializar la configuración: " + ex.Message);
            }
        }

        // Propiedad para obtener la cadena de conexión
        public static string CadenaVentas
        {
            get
            {
                // Buscamos dentro de la sección "ConnectionStrings"
                string cadena = _config.GetConnectionString("Ventas");

                if (string.IsNullOrEmpty(cadena))
                    throw new Exception("No se encontró la cadena 'VentasLeon' en appsettings.json");

                return cadena;
            }
        }

        // Método para obtener cualquier otra ruta (como por ejemplo la de las fotos en la GP3)
        public static string RutaFotos => _config["ConfiguracionGeneral:CarpetaFotos"];
    }
}
