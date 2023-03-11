namespace DefaultValue_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = default(decimal);
            Console.WriteLine(a);

            var b = default(object);
            Console.WriteLine(b);
        }
    }
    class Generic<T>
    {
        public T Field = default(T); // Поле типа T
    }

}