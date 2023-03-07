namespace Indexers_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new Book[]
            {
                new Book
                {
                  Name = "Мастер и Маргарита",
                  Author = "М.А. Булгаков"
                },
                new Book
                {
                  Name = "Отцы и дети",
                  Author = "И.С. Тургенев"
                },
            };
                BookCollection collection = new BookCollection(array);

                Book book = collection[1];
        }
    }
    // Класс для объекта “Книга”
    class Book
    {
        public string Name;
        public string Author;
    }

    // Класс для объекта “Коллекция книг”
    class BookCollection
    {
        // Закрытое поле, хранящее книги в виде массива
        private Book[] collection;

        // Конструктор с добавлением массива книг
        public BookCollection(Book[] collection)
        {
            this.collection = collection;
        }

        // Индексатор по массиву
        public Book this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
    }
}