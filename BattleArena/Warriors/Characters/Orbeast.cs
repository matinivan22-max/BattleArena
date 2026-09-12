using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Orbeast : Warrior
    {
        public int DuraDamage { get; private set; }
        public Orbeast(int health, int attackPower, int duraDamage, TeamType teamType) 
            : base("Orbeast", health, attackPower, WarriorType.Marksman, teamType)
        {
            DuraDamage = duraDamage;
            attackPower += DuraDamage; 
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Likod", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Lilikuran kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Ahh~~~");

            Thread.Sleep(1000);
            if (target.IsAlive)
                 Console.WriteLine($"->{target.Name}: Yown {target.Name}");
        }
    }

}




