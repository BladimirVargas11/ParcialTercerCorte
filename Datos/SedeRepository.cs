using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;


namespace Datos
{
    public class SedeRepository
    {
        private readonly SqlConnection _connection;
        private List<Sede> Sedes = new List<Sede>();
        public SedeRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;

        }
        public List<Sede> ConsultarSedes()
        {
            SqlDataReader dataReader;
            Sedes.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from sede";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;

                        Sede sede = new Sede();
                        sede.Id = (string)dataReader["id"];
                        sede.Nombre = (string)dataReader["nombre"];

                        Sedes.Add(sede);
                    }
                }
            }
            return Sedes;
        }

    }

}
