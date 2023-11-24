namespace library_iterator_pattern_example;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void PrintTitleAndAuthor()
    {
        Console.WriteLine($"Printed {Title} - {Author}");
    }
}