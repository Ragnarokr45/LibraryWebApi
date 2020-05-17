using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryApp.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
