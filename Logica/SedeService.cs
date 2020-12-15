using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class SedeService
    {

        private readonly ConnectionManager connection;
        private  SedeRepository sedeRepository;

  

        public SedeService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            sedeRepository = new SedeRepository(connection);
        }

        public ConsultaSedeResponse ConsultaSede()
        {
            ConsultaSedeResponse respuesta = new ConsultaSedeResponse();
            try
            {
                connection.Open();
                respuesta.Sedes = sedeRepository.ConsultarSedes();
                if (respuesta.Sedes.Count > 0)
                {
                    respuesta.Message = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Message = "No hay datos para consultar";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Message = $"Error de la Aplicacion: {e.Message}";

                return respuesta;
            }
            finally { connection.Close(); }
        }
    }
    public class SedeResponse
    {
        public Sede Sede { get; set; }
        public string Message { get; set; }
        public bool SedeEncontrada { get; set; }

        public SedeResponse(Sede sede)
        {
            Sede = new Sede();
            Sede = sede;
            SedeEncontrada = true;
        }
        public SedeResponse(string message)
        {
            Message = message;
            SedeEncontrada = false;
        }
    }

    public class ConsultaSedeResponse
    {
        public List<Sede> Sedes { get; set; }
        public string Message { get; set; }
        public bool SedeEncontrada { get; set; }
        public ConsultaSedeResponse()
        {

        }
        public ConsultaSedeResponse(List<Sede> sedes)
        {
            Sedes = new List<Sede>();
            Sedes = sedes;
            SedeEncontrada = true;
        }
        public ConsultaSedeResponse(string message)
        {
            Message = message;
            SedeEncontrada = false;
        }
    }
}
