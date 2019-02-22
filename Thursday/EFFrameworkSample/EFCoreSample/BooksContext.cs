using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSample
{
    public class BooksContext : DbContext
    {
        private const string DbConnection = @"Server=(localdb)\mssqllocaldb;database=BooksSample2;trusted_connection=true";
        public BooksContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(DbConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(25).IsRequired();
        }

        public DbSet<Book> Books { get; set; }
    }
}
