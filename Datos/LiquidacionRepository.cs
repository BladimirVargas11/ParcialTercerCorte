using System;
using System.Collections.Generic;
using System.Text;
using Entidad;

namespace Datos
{
    class LiquidacionRepository
    {
        public List<Liquidacion> ConsultarTodos()
        {
            List<Persona> personas = new List<Persona>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                Persona persona = Map(linea);
                personas.Add(persona);
            }
            reader.Close();
            file.Close();
            return personas;
        }
    }
}
