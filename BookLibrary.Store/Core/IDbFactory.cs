namespace BookLibrary.Store.Core
{
    public interface IDbFactory
    {
        IDbContext GetDb { get; }
    }
}