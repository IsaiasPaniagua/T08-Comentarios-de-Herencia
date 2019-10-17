using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class RepoCuenta: Cuenta // Repo cuenta toma herencia de la clase Cuenta
    {
        DatosCuenta ad; // aqui declaramos el objeto global
        public RepoCuenta()
        {
            ad = new DatosCuenta(); // aqui instanseamos un objeto 
        }
        internal void Principal()
        {
            Console.WriteLine("Bienvenidos a este banco");
            Menu();
            Console.ReadLine();
        }
        // Aqui creamos el meni para que el usuario decida que actividad hacer
        private void Menu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Este es nuestro menú:");
            Console.WriteLine("Elige una opción\n" +
                "\n1.-Cuenta Ahorro " +
                "\n2.-Pensiones " +
                "\n3.-Cuenta corriente " +
                "\n4.-Salir ");

            int n;
            n = Convert.ToInt16(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    GetDataSave();
                    break;

                case 2:
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDataPension();
                    break;

                case 3:
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    GetDataCurrent();
                    break;

                case 4:
                    Console.WriteLine("Hasta Luego");
                    break;

                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
        }
        private void GetDataCurrent()
        {
            int number = GetData();
            Console.ReadKey();
        }
        // aqui creamos un metodo para ingresar nuestro numero de cuenta
        private int GetData()
        {
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }
        // creamos un metodo para mandar a llamar nuestra lista pensiones
        private void GetDataPension()
        {
            int number = GetData();
            var lista = ad.Pensiones();
            Pensiones p = new Pensiones();

            foreach (var cuenta in lista)
            {
                if (number == cuenta.NumCuentaOrigen)
                {
                    p = cuenta;
                }
               // Console.WriteLine(item.Titular);
            }

            Console.WriteLine("Bienvenido " + p.Titular);
            MenuUsuario(p);
        }
        // Menu del usuario
        private void MenuUsuario(Cuenta p)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu cuenta: "+p.Titular);
            Console.WriteLine("Elige una opción\n" +
                "\n1.-Consultar saldo" +
                "\n2.-Transferir " +
                "\n3.-Interes x mes " +
                "\n4.-Ingreso ");

            int n;
            n = Convert.ToInt16(Console.ReadLine());
            switch (n)
            {
                case 1:
                    p.ConsultarSaldo(p); // Aqui mandamos a llamar a nuestro metodo dando nuestro objeto como parametro
                    MenuUsuario(p); // Aqui volvemos a llamar al menu para ver si el usuario desea hacer algo mas
                    break;
                case 2:
                    p.Transferir();
                    
                    break;
                case 3:
                    p.InteresesXMes(p); // Aqui mandamos a llamar a nuestro metodo dando nuestro objeto como parametro
                    Console.WriteLine("Su interes es: "+p.InteresesXMes(p)); // Aqui imprimimos el resultado de la operacion
                    break;
                case 4:
                    p.Ingreso();
                    break;

                default:
                    break;
            }


        }
        // Metodo para Guardar datos
        private void GetDataSave()
        {
            int number = GetData();
        }
        private int GetDataC()
        {
            //  Se pide al usuario que ingrese su numero de cuenta para pasar nuestro metodo y 
            //  asi mismo que lo buscara en las listas ya sea de pensiones, ahorros o cuentas corrientes
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }
    }
}
