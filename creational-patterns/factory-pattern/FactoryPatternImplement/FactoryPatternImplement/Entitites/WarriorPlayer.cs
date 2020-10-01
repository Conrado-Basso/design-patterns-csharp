using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImplement.Entitites
{
    public class WarriorPlayer : IPlayer
    {
        public int Hp { get => 100; }
        public int Mp { get => 50; }

        public int For { get => 40; }
        public int Int { get => 5; }
        public int Res { get => 50; }
        public int Sab { get => 40; }

        public int Atack() => this.For * 2;
        public int Defence() => this.Res * 3;
    }
}
