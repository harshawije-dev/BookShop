using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Model
{
    public class BooksModel
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
    }

    public class BookModelDBContext : DbContext {
        public DbSet<BooksModel> BooksModels { get; set; }
    }

}

