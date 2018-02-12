using BookLibrary.Models;
using BookLibrary.Store.Core;
using BookLibrary.Store.Interfaces;

namespace BookLibrary.Store.Repositories
{
    public class RoleRepository : EntityRepository<Role>, IRoleRepository
    {
        public RoleRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}