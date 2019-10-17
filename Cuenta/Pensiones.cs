using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Pensiones: Cuenta // Pensiones toma herencia de la Clase Cuenta
    {
        public DateTime Vencimiento { get; set; }
        public int Cotizacion { get; set; }
        public int NumCuentaOrigen { get; set; }
    }
}
