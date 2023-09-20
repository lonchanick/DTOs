namespace DTOs.Models;

public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Biography { get; set; }
    public DateTime? Birthday { get; set; }
    public string? Nationality { get; set; }
    public List<Book> Book { get; set; }
}
