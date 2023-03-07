namespace Task_7._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrivedClass obj = new DrivedClass();
            obj.Display();
        }
    }
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
    class DrivedClass : BaseClass
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DrivedClass");
        }
    }
}