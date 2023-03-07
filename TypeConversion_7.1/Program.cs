namespace TypeConversion_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondaryCreature = new Animal();

        }
    }
    class Creature { }
    class Animal : Creature { }
    class Human : Creature { }
    class HomoSapiens : Human { }
}