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
        LiquidacionRepository LiquidacionRepository;
        public ServicioService(Stream fileStream)
        {
            LiquidacionRepository = new LiquidacionRepository(fileStream);

        }

        public LiquidacionRespuesta Consultar()
        {

            LiquidacionRespuesta respuesta = new LiquidacionRespuesta();
            try
            {

                respuesta.listaLiquidacion = LiquidacionRepository.Consultar();
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception)
            {
                respuesta.Error = true;
                return respuesta;
            }
        }


    }
    public class LiquidacionRespuesta
    {
        public List<Servicio> listaLiquidacion { get; set; }
        public bool Error { get; set; }
    }
}
