namespace DTOs.Models;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string? Epilogue { get; set; }
    public string? ForeWords { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
    public List<Author> Authors { get; set; }
}
