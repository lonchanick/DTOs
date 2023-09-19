namespace DTOs;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Epilogue { get; set; }
    public string? ForeWords { get; set; }
    public string ISBN { get; set; }
    public int AuthorId { get; set; }
    public List<Author> Authors { get; set; }
}
