using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class DatosCuenta: Cuenta
    {
        // creamos nuestro constructoe
        public DatosCuenta()
        {
                
        }
        // creamos y hacemos el llenado de las listas de pensiones
        public List<Pensiones> Pensiones()
        {
            List<Pensiones> ListaP = new List<Pensiones>();
            ListaP.Add(new Pensiones { Numero = 1, Titular = "Isaias Paniagua", Saldo = 4000, Interes = 1300, Vencimiento = new DateTime(19/10/2029), Cotizacion = 30, NumCuentaOrigen = 19210536 });
            ListaP.Add(new Pensiones { Numero = 2, Titular = "Alan Humberto", Saldo = 5000, Interes = 1500, Vencimiento = new DateTime(10/11/2039), Cotizacion = 14, NumCuentaOrigen = 19210537 });
            ListaP.Add(new Pensiones { Numero = 3, Titular = "Mario Silva", Saldo = 6000, Interes = 1100, Vencimiento = new DateTime(18/12/2025), Cotizacion = 28, NumCuentaOrigen = 19210538 });
            ListaP.Add(new Pensiones { Numero = 4, Titular = "Miguel Hernandez", Saldo = 7000, Interes = 1200, Vencimiento = new DateTime(14/01/2040), Cotizacion = 10, NumCuentaOrigen = 19210539 });
            ListaP.Add(new Pensiones { Numero = 5, Titular = "Emmanuel Monroy", Saldo = 8000, Interes = 1000, Vencimiento = new DateTime(11/02/ 2030), Cotizacion = 20, NumCuentaOrigen = 19210540 });
            return ListaP;
        }
        // creamos y hacemos el llenado de las listas de C.Ahorros
        public List<CuentaAhorro> CuentaAhorros()
        {
            List<CuentaAhorro> ListaCA = new List<CuentaAhorro>();
            ListaCA.Add(new CuentaAhorro { Numero = 1, Titular = "Isaias Paniagua", Saldo = 4000, Interes = 1300, Vencimiento = new DateTime(19/10 /2029)});
            ListaCA.Add(new CuentaAhorro { Numero = 2, Titular = "Alan Humberto", Saldo = 5000, Interes = 1500, Vencimiento = new DateTime(19/10/2029) });
            ListaCA.Add(new CuentaAhorro { Numero = 3, Titular = "Mario Silva", Saldo = 6000, Interes = 1100, Vencimiento = new DateTime(19/10/2029) });
            ListaCA.Add(new CuentaAhorro { Numero = 4, Titular = "Miguel Hernandez", Saldo = 7000, Interes = 1200, Vencimiento = new DateTime(19/10/2029) });
            ListaCA.Add(new CuentaAhorro { Numero = 5, Titular = "Emmanuel Monroy", Saldo =8000, Interes = 1000, Vencimiento = new DateTime(19/10/2029) });
            return ListaCA;
        }
        // creamos y hacemos el llenado de las listas de C.Corriente
        public List<CuentaCorriente> CuentaCorrientes()
        {
            List<CuentaCorriente> ListaCC = new List<CuentaCorriente>();
            ListaCC.Add(new CuentaCorriente { Numero = 1, Titular = "Isaias Paniagua", Saldo = 4000, Interes = 1300 });
            ListaCC.Add(new CuentaCorriente { Numero = 2, Titular = "Alan Humberto", Saldo = 5000, Interes = 1500 });
            ListaCC.Add(new CuentaCorriente { Numero = 3, Titular = "Mario Silva", Saldo = 6000, Interes = 1100 });
            ListaCC.Add(new CuentaCorriente { Numero = 4, Titular = "Miguel Hernandez", Saldo = 7000, Interes = 1200 });
            ListaCC.Add(new CuentaCorriente { Numero = 5, Titular = "Emmanuel Monroy", Saldo = 8000, Interes = 1000 });
            return ListaCC;
        }
    }
}
