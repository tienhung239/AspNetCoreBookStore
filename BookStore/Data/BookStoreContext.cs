using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext : IdentityDbContext<DefaultUser>
    {
        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var book1 = new Book
            {
                Id = 1,
                Title = "Bröderna Lejonhjärta",
                Language = "Swedish",
                DatePublished = DateTime.Parse("2013-9-26"),
                Price = 139,
                Author = "Astrid Lindgren",
                ImageUrl = "/images/lejonhjärta.jpg"
            };

            var book2 = new Book
            {
                Id = 2,
                Title = "The Fellowship of the Ring",
                Language = "English",
                DatePublished = DateTime.Parse("1991-7-4"),
                Price = 100,
                Author = "J. R. R. Tolkien",
                ImageUrl = "/images/lotr.jpg"
            };

            var book3 = new Book
            {
                Id = 3,
                Title = "Mystic River",
                Language = "English",
                DatePublished = DateTime.Parse("2011-6-1"),
                Price = 91,
                Author = "Dennis Lehane",
                ImageUrl = "/images/mystic-river.jpg"
            };

            var book4 = new Book
            {
                Id = 4,
                Title = "Of Mice and Men",
                Language = "English",
                DatePublished = DateTime.Parse("1994-1-2"),
                Price = 166,
                Author = "John Steinbeck",
                ImageUrl = "/images/of-mice-and-men.jpg"
            };

            var book5 = new Book
            {
                Id = 5,
                Title = "The Old Man and the Sea",
                Language = "English",
                DatePublished = DateTime.Parse("1994-8-18"),
                Price = 84,
                Author = "Ernest Hemingway",
                ImageUrl = "/images/old-man-and-the-sea.jpg"
            };

            var book6 = new Book
            {
                Id = 6,
                Title = "The Road",
                Language = "English",
                DatePublished = DateTime.Parse("2007-5-1"),
                Price = 95,
                Author = "Cormac McCarthy",
                ImageUrl = "/images/the-road.jpg"
            };

            modelBuilder.Entity<Book>().HasData(book1, book2, book3, book4, book5, book6);

            base.OnModelCreating(modelBuilder);
        }
    }
}
