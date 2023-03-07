namespace KeywordsThisAndBase_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class BaseClass
    {
        public string Name;
        protected string Description;
        private int value;
        public BaseClass(int value)
        {
            this.value = value;
        }
    }

    class InheritedClass : BaseClass
    {
        private int newValue;
        public InheritedClass(int newValue) : base(100)
        {
            this.newValue = newValue;
        }
    }
    class Obj
    {
        private string name;
        private string description;

        public Obj()
        {
            Console.WriteLine("Вызван конструктор без параметров");
        }
        public Obj(string name, string description)
        {
            //явное указание обращения к полям экзмепляра данного класса
            this.name = name;
            this.description = description;
        }
    }
}