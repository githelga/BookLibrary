using System;

namespace BookLibrary.Store.Core
{
    public class DbFactory : IDbFactory, IDisposable
    {
        public DbFactory(IDbContext context)
        {
            GetDb = context;
        }

        public IDbContext GetDb { get; }

        #region implementation IDispose

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    GetDb.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}