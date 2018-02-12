using BookLibrary.Models.Catalogs;
using BookLibrary.Store.Core;
using BookLibrary.Store.Interfaces;

namespace BookLibrary.Store.Repositories
{
    public class ZoneRepository : EntityRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}