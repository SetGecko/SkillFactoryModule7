namespace Task_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
            Console.WriteLine("Метод класса DrivedClass");
        }
    }
}