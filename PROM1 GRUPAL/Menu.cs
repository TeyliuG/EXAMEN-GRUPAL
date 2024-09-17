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
            Console.WriteLine("------------");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("------------");

            Console.WriteLine("*******************************");
            Console.WriteLine("JUGADOR");
            Console.WriteLine("Colocale un nombre al jugador");
            string name = Console.ReadLine();
            Console.WriteLine("Añade Cantidad de vida para el jugador");
            int health = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de daño que desea hacer:");
            int damage = int.Parse(Console.ReadLine());
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            Console.WriteLine("*******************************");
            Console.WriteLine("ENEMIGO");
            Console.WriteLine("Crea al enemigo:");
            Console.WriteLine("Que nombre desea ponerle al enemigo?");
            string enemyName = Console.ReadLine();
            Console.WriteLine("Cuanta vida deseas tener?");
            int enemyVida = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de daño para el enemigo:");
            int enemyDanho = int.Parse(Console.ReadLine());
            Console.WriteLine("*******************************");
            Console.WriteLine(" ");

            Console.WriteLine("*******************************");
            Console.WriteLine("ITEMS");
        
            Console.WriteLine("1. Introduce el nombre");
            string iname = Console.ReadLine();// poner todo esto en switch cases
            Console.WriteLine("2.Introduce la descripcion");
            string description = Console.ReadLine();
            Items newItem = new Items(iname, description);
            Items.AddItem(newItem);
            Console.WriteLine("Item añadido");
            player = new Player(name,health, damage);
            Console.WriteLine("1 .Ingrese los items para el enemigo");
            string Enemyitems = Console.ReadLine();
            Console.WriteLine("2 .Ingrese los items para el jugador");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine();
                    break;

            }
            Console.WriteLine("*******************************");



            FlujoJuego();
        }

        public void FlujoJuego()
        {
            Console.WriteLine("Que deseas hacer a continuacion?");

            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Item");
            Console.WriteLine("3. Inventario");

            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    Console.WriteLine("Has atacado");
                    break;
                case "2":
                    break;
                case "3":
                    List<Items> items = Items.GetItems();
                    Console.WriteLine("\nLista de items:");
                    foreach (var item in items)
                    {
                        Console.WriteLine($"Nombre: {item.Name}, Descripcion: {item.Description}");
                    }
                    break;
            }
        }
    }
}
