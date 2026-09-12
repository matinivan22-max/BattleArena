using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;
using BattleArena.Abilities;

namespace BattleArena.Warriors.Characters
{
    public class Agoot : Warrior, IDefender
    {
        public int Shield { get; set; }
        public Agoot(int health, int attackPower, int shield, int speed, TeamType teamType)
            : base("Agoot", health, attackPower, speed, WarriorType.Tank, teamType)
        {
            Shield = shield;
            attackPower += shield;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Shield", HasCriticalChance, this);
            Console.WriteLine($"\t->{Name}: Susubuan kita~~! {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: ahh~~~");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {Name} sarappp mo {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;

            var blockChance = _random.Next(0, 100);
            var isBlocked = blockChance < 50;
            _damageTaken = damage;

            if (isBlocked) Block();
            else
            {
                var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From);
                base.TakeDamage(newDmgInfo);
            }
        }

        public void Block()
        {
            var blockMessage = $"Blocked {_damageTaken.TotalAmountDamage} damage from {_damageTaken.From.Name}!";

        }
    }
}