using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class ServicioBdService
    {

        private readonly ConnectionManager connection;
        private readonly ServicioBdRepository servicioBdRepository;

        public ServicioBdService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            servicioBdRepository = new ServicioBdRepository(connection);
        }

        public ServicioResponse GuardarServicio(Servicio servicio)
        {

            ServicioResponse servicioResponse = new ServicioResponse();
                try
                {
                    connection.Open();
                    servicioBdRepository.Guardar(servicio);

                    servicioResponse.Message= $"Se guardó la Correctamente la persona "+servicio.NombrePaciente;
                    servicioResponse.Error = false;
                    return servicioResponse;
            }
                catch (Exception e)
                {
                    servicioResponse.Message = $"Error de la Aplicacion: {e.Message}"+"No se pudo Guardar a la persona: "+servicio.NombrePaciente;
                    servicioResponse.Error = true;
                    return servicioResponse;
                }
                finally { connection.Close(); }
            
        }
        public ServicioResponse ConsultarTodos(String tipo,string id)
        {
            ServicioResponse respuesta = new ServicioResponse();
            try
            {

                connection.Open();
                respuesta.servicios = servicioBdRepository.Consultas(tipo, id);
                connection.Close();
                if (respuesta.servicios.Count > 0)
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

    

    public class ServicioResponse
    {

        public string Message { get; set; }
        public bool Error { get; set; }
        public List<Servicio> servicios { get; set; }

        public ServicioResponse()
        {

        }
    }
}
