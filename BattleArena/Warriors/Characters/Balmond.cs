using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;


namespace BattleArena.Warriors.Characters
{

    public class Balmond : Warrior
    {
        public int WhirlDamage { get; private set; }
        public Balmond(int health, int attackPower, int whirlDamage, int speed, TeamType teamType)
            : base("Balmond", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            WhirlDamage = whirlDamage;
            attackPower += whirlDamage;
        }

        public Balmond(string name, int health, int attackPower, int speed, TeamType teamType)
            : base(name, health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            WhirlDamage = WhirlDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Whirl", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: Iikotan kita {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: Aeugh~ ahh~ ahh~");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: sarap mo {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

    }
}