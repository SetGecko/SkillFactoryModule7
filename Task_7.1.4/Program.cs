namespace Task_7._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Emplyee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager : Emplyee
    {
        public string ProjectName;
    }
    class Developer : Emplyee
    {
        public string ProgrammingLanguage;
    }
}