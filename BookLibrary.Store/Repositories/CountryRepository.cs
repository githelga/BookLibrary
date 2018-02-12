using BookLibrary.Models.Catalogs;
using BookLibrary.Store.Core;
using BookLibrary.Store.Interfaces;

namespace BookLibrary.Store.Repositories
{
    public class CountryRepository : EntityRepository<Country>, ICountryRepository
    {
        public CountryRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}