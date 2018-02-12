using BookLibrary.Models.Catalogs;
using BookLibrary.Store.Core;

namespace BookLibrary.Store.Interfaces
{
    public interface ICountryRepository : IEntityRepository<Country>
    {
    }
}