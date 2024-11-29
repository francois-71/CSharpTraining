using System.Runtime;
using classes;
using enums;
using interfaces;

namespace factories
{
    public static class TransactionFactory
    {
        public static ITransaction MakeTransaction(TransactionType transactionType, decimal amount, int accountID)
        {
            switch (transactionType)
            {
                case TransactionType.TRANSFER:
                    throw new Exception("Invalid parameters for this type of transaction");

                case TransactionType.WITHDRAWAL:
                    WithdrawalTransaction withdrawal = new(amount: amount, fromAccount: accountID);
                    return withdrawal;

                case TransactionType.DEPOSIT:
                    DepositTransaction deposit = new(amount: amount, toAccount: accountID);
                    return deposit;

                default:
                    throw new ArgumentOutOfRangeException("This transaction type does not exist");
            }
        }

        public static ITransaction MakeTransaction(TransactionType transactionType, decimal amount, int fromAccountID, int toAccountID)
        {
            if (transactionType != TransactionType.TRANSFER)
            {
                throw new Exception("Invalid parameters for this type of transaction");
            }
            else
            {
                TransferTransaction transfer = new(amount: amount, fromAccount: fromAccountID, toAccount: toAccountID);
                return transfer;
            }
        }
    }
}