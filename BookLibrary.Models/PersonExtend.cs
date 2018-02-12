using System;
using BookLibrary.Models.Catalogs;
using BookLibrary.Models.Enums;

namespace BookLibrary.Models
{
    public abstract class PersonExtend : Person, ICommuniction, IAddress
    {
        public SexTypes Sex { get; set; }
        public DateTime BirthDateTime { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Country Country { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
    }
}