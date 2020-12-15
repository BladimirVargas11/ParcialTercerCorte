using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    class Liquidacion
    {
        public string IdSede { get; set; }
        public string IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public int HorasTrabajadas { get; set; }
        public string Periodo { get; set; }
        public string Vigencia { get; set; }
        public decimal Valor { get; set; }

        //(IdSede, IdEmpleado, NombreEmpleado, HorasTrabajadas, Periodo, Vigencia y Valor
    }
}
