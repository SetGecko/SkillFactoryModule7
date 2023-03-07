namespace Task_7._2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class A
    {
        //Добавьте в класс A виртуальный метод Display (void тип, без параметров),
        //который будет выводить в консоль "A".
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        // В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    class C : A
    {
        //Для класса C переопределите метод Display, чтобы в консоли было "C".
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    class D : B
    {
        //Для D снова скройте метод.
        public new void Display()
        {
            Console.WriteLine("D");
        }

    }
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }

    }
}