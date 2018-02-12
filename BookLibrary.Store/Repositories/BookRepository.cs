using BookLibrary.Models;
using BookLibrary.Store.Core;
using BookLibrary.Store.Interfaces;

namespace BookLibrary.Store.Repositories
{
    public class BookRepository : EntityRepository<Book>, IBookRepository
    {
        public BookRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}
