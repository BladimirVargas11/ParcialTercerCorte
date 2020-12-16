using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class IpsService
    {

        private readonly ConnectionManager connection;
        private readonly IpsRepository ipsRepository;

        public IpsService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            ipsRepository = new IpsRepository(connection);
        }
        public ConsultaIpsResponse ConsultaSede()
        {
            ConsultaIpsResponse respuesta = new ConsultaIpsResponse();
            try
            {
                connection.Open();
                respuesta.ListaIps = ipsRepository.ConsultarSedes();
                if (respuesta.ListaIps.Count > 0)
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
    public class IpsResponse
    {
        public Ips Ips { get; set; }
        public string Message { get; set; }
        public bool IpsEncontrada { get; set; }

        public IpsResponse(Ips sede)
        {
            Ips = new Ips();
            Ips = sede;
            IpsEncontrada = true;
        }
        public IpsResponse(string message)
        {
            Message = message;
            IpsEncontrada = false;
        }
    }

    public class ConsultaIpsResponse
    {
        public List<Ips> ListaIps { get; set; }
        public string Message { get; set; }
        public bool IpsEncontrada { get; set; }
        public ConsultaIpsResponse()
        {

        }
        public ConsultaIpsResponse(List<Ips> listaIps)
        {
            ListaIps = new List<Ips>();
            ListaIps = listaIps;
            IpsEncontrada = true;
        }
        public ConsultaIpsResponse(string message)
        {
            Message = message;
            IpsEncontrada = false;
        }
    }
}
