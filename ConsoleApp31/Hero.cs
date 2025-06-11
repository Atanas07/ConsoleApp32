using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public delegate void AttackEventHandler(Hero attacker, Hero target, int damage);
    public delegate void DamagedEventHandler(Hero champion, int remainingHealth);
    public delegate void DefeatedEventHandler(Hero winner, Hero loser);
    public class Hero
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public bool IsDefeated => Health <= 0;
        public event AttackEventHandler OnAttack;
        public event DamagedEventHandler OnDamaged;
        public event DefeatedEventHandler OnDefeated;
        public Hero(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }
        public void Attack(Hero target)
        {
            if (IsDefeated || target.IsDefeated)
            {
                return;
            }
               
            OnAttack?.Invoke(this, target, AttackPower);
            target.TakeDamage(AttackPower);
        }

        public void TakeDamage(int amount)
        {
            if (IsDefeated)
            {
                return;
            }
            Health -= amount;
            
            OnDamaged?.Invoke(this, Health); 
            if (Health <= 0)
            {

                OnDefeated?.Invoke(null, this);
                Console.WriteLine($"{Name} was killed");
            }
        }


    }
}
