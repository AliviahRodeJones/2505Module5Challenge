public class Book
{
    public string Title { get; set; }
    // First property for the book class. 
    public string Author { get; set; }
    // Second property for the book class. 
    public string ISBN { get; set; }
    // Third property for the book class. 
    

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    // Class constructor for the book class. Includes all three properties in the class. 

    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
    // This method overrides the tostring function (or the function that is called when
    // something is printed). This method returns a formatted string with all of a book's properties. 

}