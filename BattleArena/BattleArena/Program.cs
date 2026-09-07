using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BattleArena.Warriors.Marksman;


namespace BattleArena
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var atlas = new Tank("atlas", 300, 15, 5);
            var Orbeast = new Marksman("Orbeast", 150, 32, 10 );
            var balmond = new Fighter("balmond", 200, 20, 7);

            atlas.DisplayStatus();
            Orbeast.DisplayStatus();
            balmond.DisplayStatus();

            while (atlas.IsAlive && Orbeast.IsAlive)
            {
                Console.WriteLine("\n\n====================================");
                atlas.Attack(Orbeast);
                Thread.Sleep(1000);
                Orbeast.Attack(atlas);
                Thread.Sleep(1000);
                Console.WriteLine("------------------------------------");

            }

            Console.ReadKey();
        }
    }
}