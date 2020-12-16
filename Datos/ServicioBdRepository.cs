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
        private List<Servicio> listaServicio = new List<Servicio>();

        public ServicioBdRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Servicio servicio)

        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO servicio(IdIPS, Identificacion, NombrePaciente, IdLaboratorio, ValorLaboratorio)
                                        Values (@IdIPS,@Identificacion,@NombrePaciente,@IdLaboratorio,@ValorLaboratorio)";
                command.Parameters.AddWithValue("@IdIPS", servicio.IdIPS);
                command.Parameters.AddWithValue("@Identificacion", servicio.Identificacion);
                command.Parameters.AddWithValue("@NombrePaciente", servicio.NombrePaciente);
                command.Parameters.AddWithValue("@IdLaboratorio", servicio.IdLaboratorio);
                command.Parameters.AddWithValue("@ValorLaboratorio", servicio.ValorLaboratorio);
                
                var filas = command.ExecuteNonQuery();

            }

        }
        public List<Servicio> ConsultarServicio()
        {
            SqlDataReader dataReader;
            listaServicio.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from ips";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;

                        Servicio servicio = new Servicio();
                        servicio.IdIPS = (string)dataReader["IdIPS"];
                        servicio.Identificacion = (string)dataReader["Identificacion"];
                        servicio.NombrePaciente = (string)dataReader["NombrePaciente"];
                        servicio.IdLaboratorio = (string)dataReader["IdLaboratorio"];
                        servicio.ValorLaboratorio = (decimal)dataReader["ValorLaboratorio"];
                        

                        listaServicio.Add(servicio);
                    }
                }
            }
            return listaServicio;
        }

    }
}
