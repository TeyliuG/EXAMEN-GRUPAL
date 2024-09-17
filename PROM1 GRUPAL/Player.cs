using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROM1_GRUPAL
{
    internal class Player
    {
        private string name;
        private int health;
        private int damage;

        public Player(string name, int health, int damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }
        public void TakeDamage(int damage)
        {
            health += damage;
        }

        public bool IsAlive()
        {
            return health > 0;
        }

        public int GetDamage()
        {
            return -damage;
        }

        public string GetData()
        {
            return $"Jugador:{name} - Vida:{health} - Daño:{damage}";
        }

    }
}
