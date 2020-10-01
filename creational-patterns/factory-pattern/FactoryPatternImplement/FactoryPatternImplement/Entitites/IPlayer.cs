using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImplement.Entitites
{
    public interface IPlayer
    {
        int Hp { get; }
        int Mp { get; }
        int For { get; }
        int Int { get; }
        int Sab { get; }
        int Res { get; }

        int Atack();
        int Defence();
    }
}
