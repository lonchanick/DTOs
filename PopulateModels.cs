namespace DTOs;

public class PopulateModels
{
    public void exe()
    {
        using var Db = new Db();

        List<Author> AuthorList = new()
        {
            new(){ FirstName = "Rick", LastName = "Warren"},
            new(){ FirstName = "Agustin", LastName = "Laje"},
        };

        Db.AddRange(AuthorList);
        Db.SaveChanges();
        Console.ReadLine();

        List<Book> BookList = new()
        {
            new(){ Title="Vida Con proposito", ISBN="0001", AuthorId=1},
            new(){ Title="DailyHope Devotional", ISBN="0002", AuthorId=1},
            new(){ Title="Libro Negro de la nueva izquierda", ISBN="0003", AuthorId=2},
            new(){ Title="Batalla cultural", ISBN="0004", AuthorId=2},
        };
        Db.AddRange(BookList);
        Db.SaveChanges();
        Console.ReadLine();
    }
}
