using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Orbeast : Warrior
    {
        public int Subo { get; private set; }
        public Orbeast(int health, int attackPower, int Subo, int speed, TeamType teamType)
            : base("Orbeast", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            this.Subo = Subo;
            attackPower += this.Subo;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Subo", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Duburaan kita bebe {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Need more babe!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko babe {target.Name}");
        }
    }

}



