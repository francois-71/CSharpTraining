using Xunit;
using classes;  // Namespace where your classes like Account, Bank, etc. reside

namespace BankingTransactionSystem.Tests
{
    public class AccountTests
    {
        [Fact]
        public void Deposit_IncreasesBalance()
        {
            // Arrange
            var account = new Account("John Doe", 100);

            // Act
            account.Deposit(50);

            // Assert
            Assert.Equal(150, account.Balance);
        }

        [Fact]
        public void Withdraw_DecreasesBalance()
        {
            // Arrange
            var account = new Account("John Doe", 100);

            // Act
            account.Withdraw(30);

            // Assert
            Assert.Equal(70, account.Balance);
        }
        [Fact]
        public void Withdraw_ShouldNotAllowNegativeBalance()
        {
            var account = new Account("John Doe", 100);

            // should throw exception because balance is less than 0 in xunit
            var exception = Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
            Assert.Equal("Balance is too low ", exception.Message);

        }
    }
}
