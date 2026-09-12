using BattleArena.Enums;
using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    public static class BattleArena
    {
        private static readonly Random _random = new Random();

        static List<Warriors.Warrior> _warrior = new List<Warriors.Warrior>();


        public static void StartBattle()
        {
            DisplayWarriors();
        }
        public static void AddWarrior(Warriors.Warrior warrior)
        {
            _warrior.Add(warrior);
        }

        private static void DisplayWarriors()
        {
            var TeamA = _warrior.Where(w => w.Team == Enums.TeamType.A).ToList();
            var TeamB = _warrior.Where(w => w.Team == Enums.TeamType.B).ToList();

            Console.WriteLine("======= Team A =======");
            foreach (var warrior in TeamA)
                Console.WriteLine($"{warrior.Name}" +
                    $"\n Health: {warrior.Health}" +
                    $"\n Attack Power: {warrior.AttackPower}" +
                    $"\n Team: {warrior.Team}");

            Console.WriteLine("\n======= Team B =======");
            foreach (var warrior in TeamB)
                Console.WriteLine($"{warrior.Name}" +
                    $"\n Health: {warrior.Health}" +
                    $"\n Attack Power: {warrior.AttackPower}" +
                    $"\n Team: {warrior.Team}");
        }

        private static void RunRound()
        {
            var turnOrder = CreateTurnOrder;

            foreach (var entry in turnOrder)
            {
                var attacker = entry.Warrior;
                if (attacker.IsAlive && !entry.IsAttacked) ;
                {
                    attacker.Attack();
                }
            }
        }
        private static List<Turn> CreateTurnOrder()
        {
            var teams = new List<TeamType>
            {
                TeamType.A,
                TeamType.B
            };
            var turnOrder = new List<Turn>();
            foreach (var team in teams)
            {
                var warriors = _warrior.Where(w => w.Team == team && w.IsAlive).ToList();
                foreach (var warrior in warriors)
                {
                    turnOrder.Add(new Turn(warrior, false));
                }
            }
            return turnOrder.OrderBy(t => _random.Next()).ToList();
        }


        private static void Attack(Turn attacker)
        {
            var opponent = FindOpponent(attacker)
                attacker.IsAttacked = true;
            attacker.Warrior.Attack(opponent.Warrior);
        }

        private statoc TurnEntry FindOpponent(Turn attacker)
        {
            var opponentTeam = attacker.Warrior.Team == Enums.TeamType.A ? Enums.TeamType.B : Enums.TeamType.A;
            var Validopponent = _warrior.FirstOrDefault(w => w.Team == opponentTeam && w.IsAlive);
            if (ValidatOpponent(opponent))
            {
            }
        }
    }
}
