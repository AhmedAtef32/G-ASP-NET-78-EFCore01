using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Session_01_BOOKSTORE.Entities
{
    [Table(name:"BooksTable")]
    internal class Book
    {
        [Key]
        [MaxLength(10)]
        public string? ISBN { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Title { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }

        public int PublishedYear { get; set; }

        public bool IsInStock { get; set; }

        public int CategoryId { get; set; }

    }
}
