namespace DTOs.DTOs;

public class BookDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Authorx { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return ($"Id: {Id}\nTitle: {Title}\nAuthor: {Authorx}\nPrice: {Price}\n\n");
    }
}
