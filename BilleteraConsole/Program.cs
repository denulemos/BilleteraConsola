using BilleteraConsole.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("DenuLemos", "Denu", "Lemos", "denu.a.lemos@gmail.com", 10000, "holi");
            user.addMovimiento(100, TipoMov.deposito);
            user.addMovimiento(200, TipoMov.retiro);
            user.addMovimiento(300, TipoMov.retiro);
            user.verMovimientos();

            Console.WriteLine("Apreta enter para salir");
            Console.ReadLine(); //Para prevenir que la consola se cierre sola. 
        }
    }
}
