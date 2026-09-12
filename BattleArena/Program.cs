using BattleArena.Enums;
using BattleArena.Warriors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Agoot = new Agoot(100, 30, 10, 5, TeamType.A);
            var Orbeast = new Orbeast(200, 15, 20, 8, TeamType.B);
            var Balmond = new Balmond(150, 20, 15, 7, TeamType.A);

            Agoot.DisplayStatus();
            Orbeast.DisplayStatus();
            Balmond.DisplayStatus();

            while (Agoot.IsAlive && Orbeast.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                Agoot.Attack(Orbeast);
                Orbeast.DisplayStatus();
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(2000);
                Orbeast.Attack(Agoot);
                Agoot.DisplayStatus();
                Thread.Sleep(2000);
            }

            Console.ReadKey();
        }
    }
}