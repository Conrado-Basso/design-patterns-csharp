using System;
using System.Linq;
using FactoryPatternImplement.Creators;

namespace FactoryPatternImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCombat(new WarriorCreator());
            TestCombat(new RangerCreator());
        }

        private static void TestCombat(AbstractCreatorPlayer abstractCreatorPlayer)
        {
            Console.WriteLine($"Test combat *** {abstractCreatorPlayer.GetType().Name} *** ");

            var random = new Random();
            var atacks = Enumerable.Range(0, 5).Select(t => random.Next(300)).ToList();

            atacks.ForEach(n => Console.WriteLine(abstractCreatorPlayer.CombatAtack(n)));

            Console.WriteLine("********************************************************");
        }
    }
}
