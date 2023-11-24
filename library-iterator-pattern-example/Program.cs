using library_iterator_pattern_example;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new() { Title = "Book1", Author = "Author1" },
            new() { Title = "Book2", Author = "Author2" },
            new() { Title = "Book3", Author = "Author3" },
            new() { Title = "Book4", Author = "Author4" }
        };
        Library library = new Library(books);
        BookIterator iterator = library.CreateIterator();
        Printer.Print(iterator);
    }
}