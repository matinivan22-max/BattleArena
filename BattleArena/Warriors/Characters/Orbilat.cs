using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class Orbilat : Warrior, IHealCaster
    {
        public int HealingAmount { get; set; }
        public Orbilat(int health, int attackPower, int speed, int healingAmount, TeamType teamType)
            : base("Orbilat", health, attackPower, speed, WarriorType.Magery, teamType)
        {
            HealingAmount = healingAmount;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "tuwad", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: aray {target.Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Ulul {Name}");
        }

        public void HealTeamMates(List<Warrior> teamMates)
        {
            foreach (var warrior in teamMates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"->{Name}: kotong dagdag heal {warrior.Name}!");
                    warrior.ReceiveHealing(HealingAmount, this);
                }
                else
                    Console.WriteLine($"->{Name}: Sayang, patay na si {warrior.Name}. " +
                        $"Hindi ko na siya makokotongan.");
            }
        }
    }
}
