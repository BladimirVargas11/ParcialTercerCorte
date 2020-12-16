using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entidad;

namespace Datos
{
    public class ServicioRepository
    {
        public Stream FileStream { get; set; }
        private List<Servicio> listaServicio = new List<Servicio>();

        public ServicioRepository(Stream fileStream)
        {
            FileStream = fileStream;
        }
        public List<Servicio> Consultar()
        {
            listaServicio.Clear();

            string linea = string.Empty;

            StreamReader lector = new StreamReader(FileStream);

            while ((linea = lector.ReadLine()) != null)
            {
                
                String[] datos = linea.Split(';');
                Servicio servicio = new Servicio();
                servicio.IdIPS = datos[0];
                servicio.Identificacion = datos[1];
                servicio.NombrePaciente = datos[2];
                servicio.IdLaboratorio = datos[3];
                servicio.ValorLaboratorio = decimal.Parse(datos[4]);

                listaServicio.Add(servicio);
            }

            lector.Close();

            return listaServicio;
        }
    }
}
