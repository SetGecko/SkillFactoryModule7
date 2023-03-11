namespace UsingMultipleGenericParameters_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generic<object, int, string> generic = new Generic<object, int, string>();
        }
    }
    class Generic<T1, T2, T3>
    {
        public T1 Field;
        public T2 Property { get; set; }
        public void Method (T3 param)
        {
            
        }
    }
}