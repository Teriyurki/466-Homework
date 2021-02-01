using System;
using System.Collections.Generic;

namespace Hw1Exe2
{
    class Program
    {

        static void Main(string[] args)
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            Console.ReadLine();
        }

        static void DoBattle(List<Player> players)
        {
            foreach (var player in players)
            {
                player.Attack();
                Console.WriteLine("");
            }
        }
    }

    class Player
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public virtual void Attack()
        {
            Random RandomRoll = new Random();
            Console.WriteLine($" {Name} attacked for {RandomRoll.Next(Strength + 1)} damage.");

        }

    }

    class Warrior : Player
    {
        public int Bonus { get; set; }
        public override void Attack()
        {
            Random RandomRoll = new Random();

            Console.WriteLine($" {Name} attacked for {RandomRoll.Next(Strength + 1)} damage. (Includes +{Bonus} bonus)");
        }

    }

    class Wizard : Player
    {
        public int Energy { get; set; }
        public override void Attack()
        {
            Random RandomRoll = new Random();

            Console.WriteLine($" {Name} attacked for {RandomRoll.Next(Strength + 1)} damage." +
                    $"\n\t (Wizard {Name} depleted {RandomRoll.Next(Energy + 1)} energy)");
        }

    }
}