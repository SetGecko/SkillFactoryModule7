namespace Task_7._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте классы для следующих объектов компьютера: процессор (Processor), 
             * материнская карта (MotherBoard), видеокарта (GraphicCard).
             * Унаследуйте их от класса ComputerPart.
             * Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.
             */
            GraphicCard graphicCard = new GraphicCard();
            graphicCard.Describe();
            
            Processor processor = new Processor();
            processor.Describe();

            MotherBoard board = new MotherBoard();
            board.Describe();
        }
    }
    abstract class ComputerPart
    {
        public abstract void Describe();
    }
    class Processor : ComputerPart
    {
        public override void Describe()
        {
            Console.WriteLine("Это проц");
        }
    }
    class GraphicCard : ComputerPart
    {
        public override void Describe()
        {
            Console.WriteLine("Это видяшка");
        }
    }
    class MotherBoard : ComputerPart
    {
        public override void Describe()
        {
            Console.WriteLine("Это материнка");
        }
    }
}