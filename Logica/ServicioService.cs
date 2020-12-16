using System;
using System.Collections.Generic;
using System.Text;
using Entidad;
using Datos;
using System.IO;

namespace Logica
{
    public class ServicioService
    {
        ServicioRepository ServicioRepository;
        public ServicioService(Stream fileStream)
        {
            ServicioRepository = new ServicioRepository(fileStream);

        }

        public ServicioRespuesta Consultar()
        {

            ServicioRespuesta respuesta = new ServicioRespuesta();
            try
            {

                respuesta.listaServicio = ServicioRepository.Consultar();
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = "ERROR: " + e;
                respuesta.Error = true;
                return respuesta;
            }
        }


    }
    public class ServicioRespuesta
    {
        public List<Servicio> listaServicio { get; set; }
        public bool Error { get; set; }

        public String Mensaje { get; set; }
    }
}
