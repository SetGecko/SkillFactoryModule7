namespace StaticPropertiesMethodsFields_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = Helper.Sum(1, 2, 3);
            Console.WriteLine(sum);
        }
    }
    class Counter
    {
        private static int increasingCounter;
        public static int IncreasingCounter
        {
            get { return increasingCounter; }
            set
            {
                if (value > increasingCounter)
                {
                    increasingCounter = value;
                }
            }
        }
    }
    class Helper
    {
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}