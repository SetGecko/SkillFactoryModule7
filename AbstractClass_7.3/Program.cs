namespace AbstractClass_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Абстрактный класс — это класс, экземпляр которого не может быть инициализирован.
            // Абстрактный класс служит только базовым классом для других классов.
            Employee employee = new Employee("Николай", true);
            Guest guest = new Guest("Андрей", new DateTime(2020, 11, 05));
            employee.DisplayName();
            guest.DisplayName();
        }
    }
    abstract class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public bool IsOnShift;
        public Employee(string name, bool IsOnShift) : base(name)
        {
            IsOnShift = IsOnShift;
        }
    }
    class Guest : Person
    {
        public DateTime ArrivalDate;
        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }
}