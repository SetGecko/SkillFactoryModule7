namespace KeywordsThisAndBase_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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