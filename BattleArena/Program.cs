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
            var Raymond = new Raymond(100, 30, 25, 10, TeamType.A);
            var Kirk = new Kirk( 200, 15, 10, 30, TeamType.B);
            var Agoot = new Agoot(150, 20, 15, 10, TeamType.A);
            var Busa = new Busa(150, 20, 15, 10, TeamType.A);
            var ROY = new ROY(150, 20, 15, 10, TeamType.B);
            var Adolfs = new Adolfs(150, 20, 15, 10, TeamType.B);
            var Muhat = new Muhat(150, 20, 15, 10, TeamType.B);
            var Orbilat = new Orbilat(150, 20, 15, 10, TeamType.B);
            var Khia = new Khia(150, 20, 15, 10, TeamType.A);
            var Athlon = new Athlon(150, 20, 15, 10, TeamType.B);


            BattleArena.AddWarrior(Raymond);
            BattleArena.AddWarrior(Kirk);
            BattleArena.AddWarrior(Agoot);
            BattleArena.AddWarrior(Busa);
            BattleArena.AddWarrior(ROY);
            BattleArena.AddWarrior(Adolfs);
            BattleArena.AddWarrior(Muhat);
            BattleArena.AddWarrior(Orbilat);
            BattleArena.AddWarrior(Khia);
            BattleArena.AddWarrior(Athlon);

            BattleArena.StartBattle();
        }
    }
}