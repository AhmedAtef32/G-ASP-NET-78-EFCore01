using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Session_01_BOOKSTORE.Entities
{
    internal class Category
    {
        public int categoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
