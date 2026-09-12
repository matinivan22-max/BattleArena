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
            var Orbeast = new Orbeast(100, 30, 3, TeamType.A);
            var Agoot = new Agoot( 200, 15, 10, TeamType.B);
            var Balmond = new Balmond(250, 10, 15, TeamType.B);


            Orbeast.DisplayStatus();
            Agoot.DisplayStatus();
            Balmond.DisplayStatus();

            while(Orbeast.IsAlive && Agoot.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                Orbeast.Attack(Agoot);
                Balmond.Attack(Agoot);
                Agoot.DisplayStatus();
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(2000);
                Agoot.Attack(Orbeast);
                Balmond.Attack(Orbeast);
                Orbeast.DisplayStatus();
                Thread.Sleep(2000); 
            }

            Console.ReadKey();
        }
    }
}
