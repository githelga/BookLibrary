using System.Collections.Generic;
using BookLibrary.Models.Common;

namespace BookLibrary.Models
{
    public class Book : BaseEntity
    {
        public string Titel { get; set; }
        public string Description { get; set; }
        public string Isbn { get; set; }
        public Published Published { get; set; }
        public Author Author { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}
