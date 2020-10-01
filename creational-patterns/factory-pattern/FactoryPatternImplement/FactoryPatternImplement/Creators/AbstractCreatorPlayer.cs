using FactoryPatternImplement.Entitites;

namespace FactoryPatternImplement.Creators
{
    public abstract class AbstractCreatorPlayer
    {
        public abstract IPlayer FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        // Ref (https://refactoring.guru/pt-br/design-patterns/factory-method/csharp/example)
        public string CombatAtack(int atack)
        {
            var player = this.FactoryMethod();

            if (atack < player.Defence())
                return $"atack={atack}, defence={player.Defence()}, result=Fail";
            else if (atack == player.Defence())
                return $"atack={atack}, defence={player.Defence()}, result=Miss";

            return $"atack={atack}, defence={player.Defence()}, result=Sucess";
        }
    }
}
