# Library Management System

## Exercise Overview
Create a simple library management system that manages books, users, and transactions related to borrowing and returning books. The system should be able to:

### Manage Books
- Each book has details such as:
  - **Title**
  - **Author**
  - **ISBN**
  - **Published Year**
  - **Availability Status**
- Books can be borrowed and returned, with their availability status updated accordingly.

### Manage Users
- Users have:
  - A **unique ID**
  - A **name**
  - A record of borrowed books
- Users can borrow or return books, with a restriction on the maximum number of books they can borrow at once.

### Manage the Library
- The library maintains:
  - A collection of books
  - Registered users
- The library can:
  - Add new books
  - Register new users
  - Search for books by title
  - Display a list of all currently available books.

### Optional Extension
- Track each borrowing and returning transaction, including:
  - **Transaction ID**
  - **User ID**
  - **Book ISBN**
  - **Date**

## Implementation
Construct the system using object-oriented principles and implement each requirement as specified. This includes designing appropriate classes, methods, and properties to facilitate the functionality of the library management system.
