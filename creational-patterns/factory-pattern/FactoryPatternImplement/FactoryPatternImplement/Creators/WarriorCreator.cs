using FactoryPatternImplement.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImplement.Creators
{
    public class WarriorCreator : AbstractCreatorPlayer
    {
        public override IPlayer FactoryMethod() => new WarriorPlayer();
    }
}
