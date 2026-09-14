using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class ROY : Warrior
    {
        public int DuraDamage { get; private set; }
        public ROY(int health, int attackPower, int speed, int duraDamage, TeamType teamType)
            : base("ROY", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            DuraDamage = duraDamage;
            attackPower += DuraDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Kupal", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: kakupalan {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: pak u!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko boi {target.Name}");
        }
    }

}




