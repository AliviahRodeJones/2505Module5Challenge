using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public string Name { get; set; }
    // This is the first property for the library class. Name of the library
    private List<Book> Books { get; set; }
    // This is the second property for the library class. List of indidual books in the library.  

    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }
    // Constructor method for the library class. Includes both class properties. 

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }
    // This method adds a book to the list of books in the library. 

    public bool RemoveBook(string isbn)
    {
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        // Checks the list of books for the book object that matches the isbn value. 
        // Stores that book in the bookToRemove book object. 
        
        if (bookToRemove != null)
        // If the book object is not null. 
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Removed: {bookToRemove}");
            return true;
            // This block of code removes the bookToRemove object from the Books list. 
            // Then it prints a confirmation message and the method returns true. 
        }
        Console.WriteLine("Book not found.");
        return false;
        // If the bookToRemove object is null, an error message is printed and the method returns false. 
    }
    // This method removes a book from the libraries book list. 

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }
    // This method displays each book in the Books library list. 

    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
    // This method returns a book object based on the books Isbn value. 
}