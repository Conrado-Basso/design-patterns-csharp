using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImplement.Entitites
{
    public class Ranger : IPlayer
    {
        public int Hp => 200;

        public int Mp => 100;

        public int For => 10;

        public int Int => 30;

        public int Sab => 30;

        public int Res => 20;

        public int Atack() => this.For;


        public int Defence() => this.Res * 2;
    }
}
