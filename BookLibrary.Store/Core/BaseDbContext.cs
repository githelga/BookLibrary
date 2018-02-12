using System.Threading;
using System.Threading.Tasks;
using BookLibrary.Models;
using BookLibrary.Models.Catalogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookLibrary.Store.Core
{
    public abstract class BaseDbContext : DbContext, IDbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BeforeModelCreated(modelBuilder);
            CreateModel(modelBuilder);
            AfterModelCreated(modelBuilder);
        }

        public abstract override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        
        protected abstract void BeforeModelCreated(ModelBuilder modelBuilder);
        protected abstract void AfterModelCreated(ModelBuilder modelBuilder);

        protected void CreateModel(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override DbSet<T> Set<T>()
        {
            return base.Set<T>();
        }

        public override EntityEntry<T> Entry<T>(T entity)
        {
            return base.Entry(entity);
        }
    }
}