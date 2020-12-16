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
    public class IpsRepository
    {
        private readonly SqlConnection _connection;
        private List<Ips> listaIps = new List<Ips>();
        public IpsRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;

        }
        public List<Ips> ConsultarIps()
        {
            SqlDataReader dataReader;
            listaIps.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from ips";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;

                        Ips ips = new Ips();
                        ips.IdIPS = (string)dataReader["IdIPS"];
                        ips.NombreIPS = (string)dataReader["NombreIPS"];

                        listaIps.Add(ips);
                    }
                }
            }
            return listaIps;
        }

    }

}
