namespace Practice_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleClass.MinValue);
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