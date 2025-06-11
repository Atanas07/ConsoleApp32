using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class BattleManager
    {
        private Hero champion1;
        private Hero champion2;
    

        public BattleManager(Hero hero1, Hero hero2)
        {
            champion1 = hero1;
            champion2 = hero2;

            champion1.OnAttack += HandleAttack;
            champion1.OnDamaged += HandleDamaged;
            
           
            champion2.OnAttack += HandleAttack;
            champion2.OnDamaged += HandleDamaged;
       
        }
        private void HandleAttack(Hero   attacker, Hero target, int damage)
        {
            Console.WriteLine($"Герой {attacker.Name} атакува Герой {target.Name} с {damage} щети!");
        }

        private void HandleDamaged(Hero champion, int remainingHealth)
        {
            Console.WriteLine($"Герой {champion.Name} има {remainingHealth} здраве.");
        }


       
        public void StartBattle()
        {
            Console.WriteLine("Битката започва!");
            Console.WriteLine($"Герой {champion1.Name} (Здраве: {champion1.Health}, Атака: {champion1.AttackPower})");
            Console.WriteLine($"срещу");
            Console.WriteLine($"Герой {champion2.Name} (Здраве: {champion2.Health}, Атака: {champion2.AttackPower})");
            Console.WriteLine();
            int turn = 0;
            while ( !champion1.IsDefeated && !champion2.IsDefeated)
            {
                if (turn % 2 == 0)
                { 
                    champion1.Attack(champion2);
                }
                else
                {
              champion2.Attack(champion1);
                }
                turn++;
                Console.WriteLine();
            }

            Console.WriteLine("GG FF 15");
        }

    }

}
