using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class Cuenta
    {
        // Creacion de atributos 
        public int Numero { get; set; }
        public string  Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }

        // Creacion de metodos para nuestro MenuUsuario
        public bool Ingreso()
        {
            return false;
        }
        // metodo para sacar el interes x mes con parametro de cuenta
        public double InteresesXMes(Cuenta p)
        {
            // Operacion para sacar el interes de una cuenta
            return  p.Interes * p.Saldo;

        }
        // Metodo donde le pasamos parametros para asi imprimir el saldo de la cuenta que se eligio cuando el usuario ingreso el numero de cuenta
        public void ConsultarSaldo(Cuenta cuenta)
        {
           Console.WriteLine("Su saldo Actual es de  $" + cuenta.Saldo);
        }

        public Cuenta Tranferir(Cuenta d, double quantity)
        {

           // d.Saldo += Convert.ToDecimal(quantity);
            return d;
        }
    }
}
