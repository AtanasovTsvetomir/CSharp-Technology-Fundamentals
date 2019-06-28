using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TeisterMaskDb;Integrated Security=True;");
        }
    }
}
