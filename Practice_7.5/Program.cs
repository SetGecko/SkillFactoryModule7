namespace Practice_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(SimpleClass.MinValue);
            SimpleClass object1 = new SimpleClass(50);
            SimpleClass object2 = new SimpleClass(170);
        }
    }
    class SimpleClass
    {
        public static int MinValue = 100;
        public int Value;
        public SimpleClass(int value)
        {
            if (value < MinValue) 
            {
                Value = MinValue;
            }
            else
            {
                Value = value;
            }
        }
    }
}