# Payment Adapter Pattern Exercise

This project demonstrates the Adapter Pattern in C#, simulating a payment processing system that can work with multiple payment APIs (LegacyPay and ModernPay). Each API has unique methods and conventions, and the Adapter Pattern provides a unified interface for interacting with both.

## ⚠️ Note: The primary objective of this exercise was to implement the Adapter Pattern. For simplicity, many exceptions are handled with messages rather than being fully thrown

## Enoncé (Exercise Statement)

### Scenario

You are developing an e-commerce platform that needs to integrate multiple payment gateways to process payments. Each payment gateway has its own API, and they are incompatible with each other. You need to implement an adapter pattern that allows the system to work with these gateways using a single unified interface.

### Requirements

1. **Unified Payment Interface**: Define a `PaymentProcessor` interface (`IPayAdapter`) that includes methods like `MakePayment`, `IssueRefund`, and `GetTransactionStatus`.
2. **Existing Payment Gateways**:

   - **LegacyPay**: An older payment system with methods `MakePayment(int amount)`, `ReversePayment(int transactionId)`, and `GetTransactionStatus(int transactionId)`.
   - **ModernPay**: A newer payment system with methods `ExecutePayment(PaymentRequest request)`, `IssueRefund(int transactionIdentifier)`, and `GetTransactionStatus(int transactionIdentifier)`.

3. **Adapters**:
   - Create `LegacyPayAdapter` and `ModernPayAdapter` classes that implement the `IPayAdapter` interface and adapt each payment gateway to this interface.
