using BookLibrary.Models;
using BookLibrary.Store.Core;
using BookLibrary.Store.Interfaces;

namespace BookLibrary.Store.Repositories
{
    public class TagRepository : EntityRepository<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}