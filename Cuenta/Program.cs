using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanseamos nuestro objeto y llamamos nuestro metodo
            RepoCuenta r = new RepoCuenta();
            r.Principal();
            
        }
    }
}
