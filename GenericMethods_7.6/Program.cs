namespace GenericMethods_7._6
{
    internal class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            Obj obj = new Obj();
            obj.Display<int>(345);

            int num1 = 4;
            int num2 = 10;
            Swap<int>(ref num1, ref num2);

            Console.WriteLine("{0} {1}", num1, num2);

            Console.ReadKey();
        }
    }
    class Obj
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString());
        }
    }
}