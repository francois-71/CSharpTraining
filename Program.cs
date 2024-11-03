using Classes;

namespace App;

class App
{
    public static void Main(string[] args)
    {
        Library library;
        library = new();

        library.AddBook("Weird book", "J.K Rowling", "ISBN-34023", DateTime.Now);
        library.AddUser("Francois Dion");
        library.AddUser("Georges Walter");


        library.BorrowBook(userID:123456791, isbn: "ISBN-34023");

        library.PrintAvailableBooks();
        library.printTransactions();
    }
}