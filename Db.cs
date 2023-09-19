﻿using Microsoft.EntityFrameworkCore;

namespace DTOs;

public class Db:DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source=DTOs.db");
    }
}
