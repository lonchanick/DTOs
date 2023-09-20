using DTOs.Models;
using DTOs.DataBase;

namespace DTOs;
public static class PopulateModels
{
    public static void exe()
    {
        using var Db = new Db();

        List<Author> AuthorList = new()
        {
            new(){ FirstName = "Rick", LastName = "Warren"},
            new(){ FirstName = "Agustin", LastName = "Laje"},
            new(){ FirstName = "Nicolas", LastName = "Marquez"},
            new(){ FirstName = "Pablo", LastName = "Muños"},
        };

        Db.AddRange(AuthorList);
        Db.SaveChanges();

        List<Author> Agustin = new() { AuthorList[0]};

        List<Author> Rick = new() { AuthorList[1]  };
        List<Author> Nicolas = new() { AuthorList[2]  };
        List<Author> Pablo = new() { AuthorList[3]  };


        List<Book> BookList = new()
        {
            new(){ Title="Vida Con proposito", ISBN="0001", Authors = Rick},
            new(){ Title="DailyHope Devotional", ISBN="0002", Authors = Rick},
            new(){ Title="Iglesia con proposito", ISBN="0003", Authors = Rick},

            new(){ Title="Libro Negro de la nueva izquierda", ISBN="0004", Authors = Agustin},
            new(){ Title="Batalla cultural", ISBN="0005", Authors = Agustin},
            new(){ Title="Generacion Idiota", ISBN="0006", Authors = Agustin},

            new(){ Title="Las mentiras que te cuentan", ISBN="0007", Authors = Pablo},
            new(){ Title="Atrapado en el cuerpo equivocado", ISBN="0008", Authors = Pablo},
            new(){ Title="Apaga el celular", ISBN="0009", Authors = Pablo},

            new(){ Title="Libro Negro de la nueva izquierda", ISBN="0010", Authors = Nicolas},
            new(){ Title="La maquina de matar", ISBN="0011", Authors = Nicolas},
            new(){ Title="El cuentero de Carondelet", ISBN="0012", Authors = Nicolas},

        };

        Db.AddRange(BookList);
        Db.SaveChanges();
        
        WriteLine("Done");
    }
}
