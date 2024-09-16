using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROM1_GRUPAL
{
    internal class Menu
    {
        public void Execute()
        {
            MenuJuego();
        }

        public void MenuJuego() {
            Console.WriteLine("Bienvenido al RPG");
            Console.WriteLine("Crea items:");
            Console.WriteLine("Crea al jugador:");
            Console.WriteLine("Que nombre desea ponerle al jugador?");
            Console.WriteLine("Ingrese la cantidad de daño que desea hacer:");
            Console.WriteLine("Ingrese los items para el jugador");
            Console.WriteLine("Crea al enemigo:");
            Console.WriteLine("Que nombre desea ponerle al enemigo?");
            Console.WriteLine("Ingrese la cantidad de daño que desea que el enemigo haga:");
            Console.WriteLine("Ingrese los items para el enemigo");
            
        }
    }
}
