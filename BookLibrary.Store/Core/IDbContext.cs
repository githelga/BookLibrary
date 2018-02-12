using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookLibrary.Store.Core
{
    public interface IDbContext : IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        EntityEntry<T> Entry<T>(T entity) where T : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
