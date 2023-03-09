namespace AbstractMethods_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Абстрактный элемент класса — это такой элемент абстрактного класса,
            //который не имеет реализации в базовом классе и должен быть реализован в классе-наследнике.
            Cat cat = new Cat();
            cat.Describe();
        }
    }
    abstract class AbstractClass
    {
        public string Name;
        public abstract void Display();
    }

    abstract class FourLeggedAdnimal
    {
        public abstract void Describe();
    }
    class Dog : FourLeggedAdnimal
    {
        public override void Describe() 
        {
            Console.WriteLine("Это животное  - собакен");
        }
    }
    class Cat : FourLeggedAdnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - котя");
        }
    }
}