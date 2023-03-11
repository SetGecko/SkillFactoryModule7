namespace Task_7._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2);
            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3
        }
    }
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}