namespace StaticConstructor_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine(Car.MinPrice);

            Console.WriteLine(Car.MaxPrice);

            Console.ReadKey();
        }
    }
    class Car
    {
        public static int MinPrice = 100_000;
        public static int MaxPrice;
        static Car()
        {
            Console.WriteLine("Вызван статический конструктор класса Car");
            MaxPrice = 1_000_000;
        }
        public int Price;
    }
}