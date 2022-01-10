using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int ISBN { get; set; }
        [Required]
        public double Price { get; set; }

        public Books(string bookName, string author, int isbn, double price)
        {
            this.BookName = bookName;
            this.Author = author;
            this.ISBN = isbn;
            this.Price = price;
        }
    }


    public class BooksDBContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
    }
}
