using enums;
using Log;

namespace Classes;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public DateTime DateTime { get; set; }

    public AvailabilityStatus AvailabilityStatus { get; set; }

    public Book(string title, string author, string isbn, DateTime dateTime)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        DateTime = dateTime;
        AvailabilityStatus = AvailabilityStatus.AVAILABLE;
    }
}