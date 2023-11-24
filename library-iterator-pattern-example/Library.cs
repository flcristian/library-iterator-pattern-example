namespace library_iterator_pattern_example;

public class Library
{
    private List<Book> _books;

    public Library(List<Book> books)
    {
        _books = books;
    }

    public BookIterator CreateIterator()
    {
        return new BookIterator(_books);
    }
}