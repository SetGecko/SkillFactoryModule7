namespace Task_7._5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;
        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
}