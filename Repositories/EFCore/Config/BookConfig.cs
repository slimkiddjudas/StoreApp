using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.Price).HasDefaultValue(10);

            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "Things Fall Apart ",
                    Price = 89
                },
                new Book
                {
                    Id = 2,
                    Title = "Night",
                    Price = 25
                },
                new Book
                {
                    Id = 3,
                    Title = "The Kite Runner",
                    Price = 45
                },
                new Book
                {
                    Id = 4,
                    Title = "The Stranger",
                    Price = 55
                },
                new Book
                {
                    Id = 5,
                    Title = "Cry, the Beloved Country",
                    Price = 95
                },
                new Book
                {
                    Id = 6,
                    Title = "Metamorphosis",
                    Price = 35
                },
                new Book
                {
                    Id = 7,
                    Title = "The Odyssey ",
                    Price = 78
                },
                new Book
                {
                    Id = 8,
                    Title = "Candide",
                    Price = 85
                },
                new Book
                {
                    Id = 9,
                    Title = "Illiad",
                    Price = 96
                },
                new Book
                {
                    Id = 10,
                    Title = "Life of Pi",
                    Price = 98
                }
            );
        }
    }
}
