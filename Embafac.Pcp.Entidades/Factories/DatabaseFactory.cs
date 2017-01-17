using System;
using System.Configuration;

namespace Embafac.Pcp.Entidades
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private EmbafacContext _db;

        public EmbafacContext Get()
        {
            return _db ?? (_db = new EmbafacContext(ConfigurationManager.ConnectionStrings["conn"].ConnectionString));
        }

        protected override void DisposeCore()
        {
            if (_db != null)
                _db.Dispose();
        }
    }

    /// <summary>
    /// The Disposable class is a managed disposable resource that can be explicitly called within other classes.
    /// </summary>
    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                DisposeCore();
            }

            _isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}
