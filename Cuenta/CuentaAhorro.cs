using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class CuentaAhorro: Cuenta // la CuentaAhorro toma herencia de la clase cuenta
    {
        // Creacion de atributo
        public DateTime Vencimiento { get; set; }
    }
}
