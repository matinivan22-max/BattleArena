using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    internal class Medillo : Warrior, IHealCaster
    {
        public int HealingAmount { get; set; }

        public TeamType Team => throw new NotImplementedException();

        public Medillo(string name, int health, int attackPower,int speed, TeamType teamType, int healingAmount)  
            : base(name, health, attackPower, speed, WarriorType.Mage, teamType)
        {
            HealingAmount = healingAmount;
        }

        public override void Attack(Warrior target)
        {
          var damageInfo = new DamageInfo(AttackPower,"Heal", HasCriticalChance, this);
          TakeDamage(damageInfo);

          Console.WriteLine($"{Name} Heal kita kupal {target.Name}");

          Thread.Sleep(1000);
            if(target.IsAlive)
                Console.WriteLine($"{Name} ULUL  {target.Name}");
        }
        public void HealTeammates(int amount, List<Warrior> teammates)
        {
            foreach (var warrior in teammates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"{Name} hala, heal kita {warrior.Name}");
                    warrior.ReceiveHealing(HealingAmount, this);
                }
                else
                    Console.WriteLine($"->{Name}: Sayang nilabasan na si{warrior.Name}"+
                        $"hindi ko na siya ma heal");
            }
        }
    }
}
