using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROM1_GRUPAL
{
    internal class Enemy
    {
        private string enemy;
        private int health;
        private int damage;
        public Enemy(string enemy, int health, int damage)
        {
            this.enemy = enemy;
            this.health = health;
            this.damage = damage;
        }
        public void Damage(int damage)
        {
            health += damage;
        }
        public void GetDamage(int pdmg)
        {
            health -= pdmg;
            if (health < 0)
            {
                health = 0;
            }
        }
        public bool EnemyIsAlive()
        {
            return health > 0;
        }

        public int VidaCantEnemigo()
        {
            return health;
        }
    }
}
