using System;
using System.Collections.Generic;
using System.Text;

namespace Session_01_BOOKSTORE.Entities
{
    internal class Category
    {
        public int categoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
