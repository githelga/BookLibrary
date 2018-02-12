using BookLibrary.Models;
using BookLibrary.Store.Core;

namespace BookLibrary.Store.Interfaces
{
    public interface ITagRepository : IEntityRepository<Tag>
    {
    }
}