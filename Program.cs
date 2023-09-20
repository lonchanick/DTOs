using DTOs;
using DTOs.DataBase;
using DTOs.DTOs;
using DTOs.Models;
using Microsoft.EntityFrameworkCore;

//PopulateModels.exe();

Db db = new();

var books = db.Books
    .Include(b => b.Authors).ToList();

List<BookDTO> BookDTOList = new();

foreach (var b in books)
{
    BookDTOList.Add(
        new BookDTO
        {
            Id = b.BookId,
            Title = b.Title,
            //Authorx = b.Authors
            Authorx = "damm you EF",
            Price = 2.2M
        });
}

foreach(var BooKDTO in BookDTOList)
{
    Write(BooKDTO);
}
