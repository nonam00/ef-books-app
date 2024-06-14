﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrarySystemApp
{
    public class LibrarySystemContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Reader> Readers { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<IssueCard> IssueCards { get; set; }

        public DbSet<BookStore> BooksStores { get; set; }

        public LibrarySystemContext()
        {
            Database.EnsureCreated();
            //Administrators.Add(new() { Login = "bobby", Password = "qwerty" });
            //SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-A8L8TG44\\MSSQLSERVER01;Initial Catalog=Books;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BookStore>()
                        .HasKey(bs => new { bs.RoomId, bs.BookId });
        }
    }
}
