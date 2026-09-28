using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library("Central Library");
        Member member1 = new Member("Alice", 1);
        Member member2 = new Member("Bob", 2);
        // This block of code creates a new library object and two new member objects. 

        
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780446310789"));
        library.AddBook(new Book("1984", "George Orwell", "9780451524935"));
        // This block of code adds three new books to the library object. 

        library.DisplayAvailableBooks();
        // This line calls the DisplayAvailableBooks function, which displays the 
        // information for each book contained in the library. 

        Console.WriteLine("\nBorrowing books:");
        member1.BorrowBook(library, "9780743273565");
        member2.BorrowBook(library, "9780446310789");
        // This block of code uses the BorrowBook function to allow members to borrow a book from the library. 

        library.DisplayAvailableBooks();
        // Displays the availible books from the library after the two members borrowed books. 

        member1.DisplayBorrowedBooks();
        member2.DisplayBorrowedBooks();
        // Displays both borrowed books from the two members. 

        Console.WriteLine("\nReturning a book:");
        member1.ReturnBook(library, "9780743273565");
        // Uses the ReturnBook method from the member class to enable member1 to return a book to the library. 
        // This function removes the book from the member's borrowed books list and adds it back to the library. 

        library.DisplayAvailableBooks();
        // Displays all availible books in the library. 
    }
}

