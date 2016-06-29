using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;

namespace Stock.Repository
{
    public abstract class DefaultDisposable
    {
        protected readonly StockDataContext _context;

        private bool _disposed;
        private readonly object _disposeLock = new object();

        protected DefaultDisposable()
        {
            _context = new StockDataContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            lock (_disposeLock)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        _context.Dispose();
                    }

                    _disposed = true;
                }
            }
        }
    }
}
