using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class ServicioBdRepository
    {
        private readonly SqlConnection _connection;
        private List<Servicio> listaLiquidacion = new List<Servicio>();

        public ServicioBdRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Servicio servicio)

        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO liquidacion(IdIPS, Identificacion, NombrePaciente, IdLaboratorio, ValorLaboratorio)
                                        Values (@IdSede,@IdEmpleado,@NombreEmpleado,@HorasTrabajadas,@Periodo,@Vigencia,@Valor)";
                command.Parameters.AddWithValue("@IdIPS", servicio.IdIPS);
                command.Parameters.AddWithValue("@Identificacion", servicio.Identificacion);
                command.Parameters.AddWithValue("@NombrePaciente", servicio.NombrePaciente);
                command.Parameters.AddWithValue("@IdLaboratorio", servicio.IdLaboratorio);
                command.Parameters.AddWithValue("@ValorLaboratorio", servicio.ValorLaboratorio);
                
                var filas = command.ExecuteNonQuery();

            }

        }

    }
}
