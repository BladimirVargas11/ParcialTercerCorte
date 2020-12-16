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
    public class LaboratorioRepository
    {
        private readonly SqlConnection _connection;
        private List<Laboratorio> listaLaboratorios = new List<Laboratorio>();
        public LaboratorioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;

        }
        public List<Laboratorio> ConsultarLaboratorio()
        {
            SqlDataReader dataReader;
            listaLaboratorios.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from laboratorios";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;

                        Laboratorio laboratorio = new Laboratorio();
                        laboratorio.IdLaboratorios = (string)dataReader["IdLaboratorio"];
                        laboratorio.NombreLaboratorios = (string)dataReader["NombreLaboratorio"];
                        laboratorio.ValorLaboratorio = (decimal)dataReader["ValorLaboratorio"];

                        listaLaboratorios.Add(laboratorio);
                    }
                }
            }
            return listaLaboratorios;
        }
    }
}
