using BookLibrary.Models;
using BookLibrary.Store.Core;
using BookLibrary.Store.Interfaces;

namespace BookLibrary.Store.Repositories
{
    public class UserRepository : EntityRepository<User>, IUserRepository
    {
        public UserRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}