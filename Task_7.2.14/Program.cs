namespace Task_7._2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
}