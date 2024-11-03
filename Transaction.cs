using Classes;
using enums;
namespace Log;

class Transaction
{
    private static int s_transactionID = 123456789;

    public int TransactionID { get; }
    private int? UserID { get; }
    private string? BookISBN { get; }

    public TransactionType TransactionType { get; set; }

    public DateTime DateTime { get; }
    public Transaction(int userID, TransactionType transactionType)
    {
        TransactionID = s_transactionID++;
        UserID = userID;
        DateTime = DateTime.Now;
        TransactionType = transactionType;
    }

    public Transaction(string bookISBN, TransactionType transactionType)
    {
        TransactionID = s_transactionID++;
        s_transactionID++;
        BookISBN = bookISBN;
        DateTime = DateTime.Now;
        TransactionType = transactionType;
    }

    public Transaction(int userID, string bookISBN, TransactionType transactionType)
    {
        TransactionID = s_transactionID++;
        s_transactionID++;
        BookISBN = bookISBN;
        UserID = userID;
        DateTime = DateTime.Now;
        TransactionType = transactionType;
    }
}