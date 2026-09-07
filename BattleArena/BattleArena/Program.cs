    using BattleArena.Warriors;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BattleArena
    {
        internal partial class Program
        {
            static void Main(string[] args)
            {
                Warrior Etits = new Warrior("Etits", 300, 50);
                Warrior Orbeast = new Warrior("Orbeast", 10, 1);
                Warrior Dedong = new Warrior("Dedong", 100, 20);

                Console.WriteLine($"{Etits.Name} has " +
                    $"{Etits.Health} health and {Etits.AttackPower} attack power.");
                Console.WriteLine("----------------------------------------------");

                Console.WriteLine($"{Orbeast.Name} has " +
                    $"{Orbeast.Health} health and {Orbeast.AttackPower} attack power.");
                Console.WriteLine("----------------------------------------------");

                Console.WriteLine($"{Dedong.Name} has " +
                    $"{Dedong.Health} health and {Dedong.AttackPower} attack power.");
                Console.WriteLine("----------------------------------------------");

                Console.ReadLine();
            }

        }
    }
