using Microsoft.EntityFrameworkCore;
using Session_01_BOOKSTORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session_01_BOOKSTORE.Contexts
{
    internal class BooksStoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BooksStore;Trusted_Connection=true;trustServerCertificate=true");
        }

        DbSet<Book> books { get; set; }
        DbSet<Author> authors{ get; set; }
    }
}
