namespace GenericInheritance_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass<int> intVar = new DerivedClass<int>();
            intVar.Field = 4;
            Console.WriteLine(intVar.Field);

            DerivedClass<long> longVar = new DerivedClass<long>();
            longVar.Field = (long)7;
            Console.WriteLine(longVar.Field);

            DerivedClass<string> stringVar = new DerivedClass<string>();
            stringVar.Field = "zz";
            Console.WriteLine(stringVar.Field);
        }
    }
    class BaseClass<T>
    {
        public T Field;
    }
    class DerivedClass<T> : BaseClass<T>  // можно и от BaseClass<int> - тогда будет в DerivedClass int
    { 
        public T Property { get; set; }
    }
}