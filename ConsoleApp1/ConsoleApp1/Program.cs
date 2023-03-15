using Core.Entities;
using System.Text;
using Utils.Exceptions;

//Book book1 = new("kitab 1", 20);
//Book book2 = new("kitab 2", 21);
//Book book3 = new("kitab 3", 22);

//Library library = new("Kitabxana");

//library.AddBook(book1);
//library.AddBook(book2);
//library.AddBook(book3);

//foreach (var book in library.GetAllBooks())
//{
//    Console.WriteLine(book);
//}

//library.books[0] = new Book("", 2);
//Console.WriteLine(library[3]);

//StringBuilder stringBuilder = new StringBuilder("Hello");
//Console.WriteLine(stringBuilder[0]);


//int number = 0;
////Console.WriteLine(5 / number);

//try
//{
//    //Console.WriteLine(library[3]);
//    //Console.WriteLine();
//    //Console.WriteLine(5 / number);
//    //library[0] = null;

//    Console.WriteLine(library.GetById(4));
//}
//catch (NotFoundException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("sifira bolme olmaz");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

Calculator calculator = new();

Console.WriteLine(calculator.Sum(1,2));