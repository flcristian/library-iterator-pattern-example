namespace library_iterator_pattern_example;

public class Printer
{
    public static void Print(BookIterator iterator)
    {
        while (iterator.HasNext())
        {
            iterator.GetNext().PrintTitleAndAuthor();
        }
    }
}