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
        private readonly ServicioBdRepository liquidacionBaseDeDatosRepository;

        public ServicioBdService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            liquidacionBaseDeDatosRepository = new ServicioBdRepository(connection);
        }

        public string Guardar(Servicio liquidacion)
        {
            {
                try
                {
                    connection.Open();
                    liquidacionBaseDeDatosRepository.Guardar(liquidacion);
                    
                    return $"Se guardó la Correctamente la persona "+liquidacion.NombreEmpleado;
                }
                catch (Exception e)
                {
                    return $"Error de la Aplicacion: {e.Message}"+"No se pudo Guardar a la persona: "+liquidacion.NombreEmpleado;
                }
                finally { connection.Close(); }
            }
        }



    }
}
