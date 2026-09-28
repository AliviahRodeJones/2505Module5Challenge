using System;
using System.Collections.Generic;
using System.Linq;

public class Member
{
    public string Name { get; set; }
    // First property for the member class. The name of the member. 
    public int ID { get; set; }
    // Second property for the method class. The member ID. 
    private List<Book> BorrowedBooks { get; set; }
    // Third property for the method class. A list of books borrowed by the member. 

    public Member(string name, int id)
    {
        Name = name;
        ID = id;
        BorrowedBooks = new List<Book>();
    }
    // Constructor method for the member class. Includes all three properties. 

    public void BorrowBook(Library library, string isbn)
    {
        Book book = library.GetBook(isbn);
        // Gets the book from the library via Isbn. 
        if (book != null)
        // Checks if the book value isn't null. 
        {
            BorrowedBooks.Add(book);
            // Adds the book to the members borrowed books list. 
            library.RemoveBook(isbn);
            // Removes the book from the library. 
            Console.WriteLine($"{Name} borrowed: {book}");
            // Prints a confirmation message. 
        }
        else
        // If the book value IS null. 
        {
            Console.WriteLine("Book not available.");
        }
        // Prints an error message. 
    }
    // This method allows a member to borrow a book. 

    public void ReturnBook(Library library, string isbn)
    {
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        // Checks if the book Isbn entered is in the borrowedbook list. 
        if (book != null)
        // If the value of book isn't null. 
        {
            BorrowedBooks.Remove(book);
            // Removes book from the BorrowedBook list. 
            library.AddBook(book);
            // Adds the book to the library.
            Console.WriteLine($"{Name} returned: {book}");
            // Prints a confirmation message. 
        }
        else
        // If the value of book IS null. 
        {
            Console.WriteLine("Book not found in borrowed list.");
        }
        // Prints an error message. 
    }
    // This method allows a member to return a book. 

    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"{Name}'s Borrowed Books:");
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
        // Loops over the BorrowedBooks list and displays each book. 
    }
    // This method prints a neat list of a members borrowed book. 
}