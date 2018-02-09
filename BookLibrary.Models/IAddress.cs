using BookLibrary.Models.Catalogs;

namespace BookLibrary.Models
{
    public interface IAddress
    {
        Country Country { get; set; }
        string City { get; set; }
        string Postcode { get; set; }
        string Address { get; set; }
    }
}