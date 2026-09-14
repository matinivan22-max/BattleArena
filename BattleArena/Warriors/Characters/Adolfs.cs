using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Adolfs : Warrior
    {
        public int PunchDamage { get; private set; }
        public Adolfs(int health, int attackPower, int speed, int punchDamage, TeamType teamType)
            : base("Adolfs", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = punchDamage;
            attackPower += PunchDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Kaltok", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Sasapakin kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray aray!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Bossing {target.Name}");
        }
    }

}
