using Utils.Exceptions;

namespace Core.Entities;

public class Library
{
    private static int _id;

    public int Id { get; }
    public string Name { get; set; }

    private Book[] books;

    public Book this[int index]
    {
        get => books[index];
        set
        {
            if(value == null)
                throw new ArgumentNullException("kitab","Gonderilen deyer null ola bilmez");

            books[index] = value;
        }
    }

    public Library(string name)
    {
        Id = ++_id;
        Name = name;
        books = new Book[0];
    }

    public void AddBook(Book book)
    {
        Array.Resize(ref books, books.Length + 1);
        books[books.Length - 1] = book;
    }

    public Book[] GetAllBooks()
    {
        return books;
    }

    public Book GetById(int id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
                return book;
        }

        throw new NotFoundException("Bele bir kitab tapilmadi (404)");
    }
}
