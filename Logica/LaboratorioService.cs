using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
namespace Logica
{
    public class LaboratorioService
    {
        private readonly ConnectionManager connection;
        private readonly LaboratorioRepository laboratorioRepository;

        public LaboratorioService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            laboratorioRepository = new LaboratorioRepository(connection);
        }
        public ConsultaLaboratorioResponse ConsultaLaboratorio()
        {
            ConsultaLaboratorioResponse respuesta = new ConsultaLaboratorioResponse();
            try
            {
                connection.Open();
                respuesta.ListaLaboratorio = laboratorioRepository.ConsultarLaboratorio();
                if (respuesta.ListaLaboratorio.Count > 0)
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

    public class LaboratorioResponse
    {
        public Laboratorio Laboratorio { get; set; }
        public string Message { get; set; }
        public bool LaboratorioEncontrada { get; set; }

        public LaboratorioResponse(Laboratorio laboratorio)
        {
            Laboratorio = new Laboratorio();
            Laboratorio = laboratorio;
            LaboratorioEncontrada = true;
        }
        public LaboratorioResponse(string message)
        {
            Message = message;
            LaboratorioEncontrada = false;
        }
    }

    public class ConsultaLaboratorioResponse
    {
        public List<Laboratorio> ListaLaboratorio { get; set; }
        public string Message { get; set; }
        public bool LaboratorioEncontrada { get; set; }
        public ConsultaLaboratorioResponse()
        {

        }
        public ConsultaLaboratorioResponse(List<Laboratorio> listaLaboratorio)
        {
            ListaLaboratorio = new List<Ips>();
            ListaLaboratorio = listaLaboratorio;
            LaboratorioEncontrada = true;
        }
        public ConsultaLaboratorioResponse(string message)
        {
            Message = message;
            LaboratorioEncontrada = false;
        }
    }
}
