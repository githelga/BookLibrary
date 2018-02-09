using BookLibrary.Models.Common;

namespace BookLibrary.Models
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
    }
}