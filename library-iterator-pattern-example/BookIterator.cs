namespace library_iterator_pattern_example;

public class BookIterator
{
    private List<Book> _books;
    private int _position;

    public BookIterator(List<Book> books)
    {
        _books = books;
        _position = 0;
    }

    public Book GetNext()
    {
        if (HasNext())
        {
            Book result = _books[_position];
            _position++;
            return result;
        }

        return null;
    }

    public bool HasNext()
    {
        return _position < _books.Count;
    }
}