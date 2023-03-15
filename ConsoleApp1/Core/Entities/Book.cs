namespace Core.Entities;

public class Book
{
    private static int _id;

    public int Id { get; }
    public string Name { get; set; }
    public int PageCount { get; set; }

    public Book(string name, int pageCount)
    {
        Id = ++_id;
        Name = name;
        PageCount = pageCount;
    }

    public override string ToString()
    {
        return $"Id: {Id} - Name: {Name} - Page count: {PageCount}";
    }
}
