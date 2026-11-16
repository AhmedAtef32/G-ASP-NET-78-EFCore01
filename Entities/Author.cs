using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Session_01_BOOKSTORE.Entities
{
    [Table(name: "AuthorsTable")]
    internal class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? EmailAddress { get; set; }

        [NotMapped]
        public string? FullName => $"{FirstName} {LastName}";

        [Required]
        [MaxLength(250)]
        public string? Biography { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DateOfBirth { get; set; }
    }
}
