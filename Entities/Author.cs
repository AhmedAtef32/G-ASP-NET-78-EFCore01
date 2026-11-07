using System;
using System.Collections.Generic;
using System.Text;

namespace Session_01_BOOKSTORE.Entities
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
