using enums;
using Log;

namespace Classes;


class Library
{
    public List<User> Users { get; set; }
    public List<Book> Books { get; set; }

    private List<Transaction> _allTransactions = new List<Transaction>();

    public Library()
    {
        Users = new List<User>();
        Books = new List<Book>();
    }

    public void AddUser(string name)
    {
        User user;
        user = new(name);

        Users.Add(user);

        Transaction transaction;
        transaction = new Transaction(user.GetUserID(), TransactionType.REGISTER_USER);

        _allTransactions.Add(transaction);
    }

    public void AddBook(string title, string author, string isbn, DateTime dateTime)
    {
        Book book;
        book = new(title, author, isbn, dateTime);

        Books.Add(book);

        Transaction transaction;
        transaction = new Transaction(bookISBN: isbn, TransactionType.REGISTER_BOOK);

        _allTransactions.Add(transaction);
    }

    public void BorrowBook(int userID, string isbn)
    {
        // check if user exist: 
        User? user = Users.Find(user => user.GetUserID() == userID) ?? throw new InvalidOperationException($"User with userID: {userID} does not exist");

        if (user == null)
        {
            throw new InvalidOperationException($"User {userID} does not exist");
        }

        Book? book = Books.Find(book => book.ISBN == isbn) ?? throw new InvalidOperationException($"Book with ISBN: {isbn} does not exist");

        if (book.AvailabilityStatus == AvailabilityStatus.NOT_AVAILABLE)
        {
            throw new Exception("The book is not available");
        }
        else
        {
            book.AvailabilityStatus = AvailabilityStatus.NOT_AVAILABLE;
            user.BorrowedBooks.Add(book);

            Transaction transaction;
            transaction = new(userID: userID, bookISBN: isbn, transactionType: TransactionType.BORROW_BOOK);

            _allTransactions.Add(transaction);
        }
    }

    public void ReturnBook(int userID, string isbn)
    {
        User? user = Users.Find(user => user.GetUserID() == userID) ?? throw new InvalidCastException($"User with userID: {userID} does not exist");

        if (user == null)
        {
            throw new InvalidOperationException($"User {userID} does not exist");
        }

        Book? book = Books.Find(book => book.ISBN == isbn) ?? throw new InvalidOperationException($"Book with ISBN: {isbn} does not exist");

        if (book.AvailabilityStatus == AvailabilityStatus.AVAILABLE)
        {
            throw new Exception("The book was not borrowed");
        }
        else
        {
            book.AvailabilityStatus = AvailabilityStatus.AVAILABLE;
            user.BorrowedBooks.Remove(book);

            Transaction transaction;
            transaction = new Transaction(userID: userID, bookISBN: isbn, transactionType: TransactionType.RETURN_BOOK);
        }

    }

    public List<Book> GetBooksByTitle(string title)
    {
        List<Book> result;
        result = new List<Book>();
        foreach (var book in Books)
        {
            if (book.Title.Equals(title))
            {
                result.Add(book);
            }
        }
        return result;
    }

    public void PrintAvailableBooks()
    {
        List<Book> result;
        result = new List<Book>();

        foreach (var book in Books)
        {
            if (book.AvailabilityStatus.Equals(AvailabilityStatus.AVAILABLE))
            {
                result.Add(book);
            }
        }

        foreach (var item in result)
        {
            System.Console.WriteLine($"AVAILABLE: {item.Title} - {item.Author} - {item.DateTime} - {item.ISBN}");
        }
    }

    public void printTransactions(){
        foreach (var transaction in _allTransactions){
            System.Console.WriteLine($"Transaction Date: {transaction.DateTime} - Transaction {transaction.TransactionID} - Transaction Type: {transaction.TransactionType}");
        }
    }
}