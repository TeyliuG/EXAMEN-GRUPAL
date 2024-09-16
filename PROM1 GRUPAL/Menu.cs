using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROM1_GRUPAL
{
    internal class Menu
    {
        private Player player;
        public void Execute()
        {
            MenuJuego();
        }

        public void MenuJuego() {
            Console.WriteLine("Bienvenido al RPG");
            Console.WriteLine("Crea items:");

            Console.WriteLine("Crea al jugador:");
            Console.WriteLine("Que nombre desea ponerle al jugador?");
            string name = Console.ReadLine();
            Console.WriteLine("Cuanta vida deseas tener?");
            int health = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de daño que desea hacer:");
            int damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los items para el jugador");
            string playeritems = Console.ReadLine(); // los items seran string (?
            player = new Player(name,health, damage);

            Console.WriteLine("Crea al enemigo:");
            Console.WriteLine("Que nombre desea ponerle al enemigo?");
            string enemyName = Console.ReadLine();
            Console.WriteLine("Cuanta vida deseas tener?");
            int enemyVida = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de daño para el enemigo:");
            int enemyDanho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los items para el enemigo");
            string Enemyitems = Console.ReadLine();

        }
    }
}
