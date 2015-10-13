using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithAbstraction.Interfaces;

namespace WorkingWithAbstraction.Characters
{
    public abstract class Character : IAttack
    {
        protected Character(int health, int mana, int damage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Damage = damage;
        }

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        public abstract void Attack(Character target);

        public override string ToString()
        {
            return string.Format("Hero {0}:\r\n-Health: {1}\r\n-Mana: {2}\r\n", this.GetType().Name, this.Health, this.Mana);
        }
    }
}
