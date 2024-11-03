namespace Classes;

public class User
{
    private static int _id = 123456789;
    public string Name { get; set; }
    public List<Book> BorrowedBooks { get; set; }

    public User(string name)
    {
        Name = name;
        BorrowedBooks = new List<Book>();
        _id++;
        System.Console.WriteLine($"id is {_id}");
    }

    public int GetUserID()
    {
        return _id;
    }
}