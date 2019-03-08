using System;

namespace KingsOfWar.Spec.Context
{
    partial class Visitor : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void AssertDisposed()
        {
            if (_disposed) throw new ObjectDisposedException(ToString());
        }

        private void Dispose(bool dispose)
        {
            if (_disposed) return;

            if (dispose)
            {
                DisposeManaged();
            }

            _disposed = true;
        }

        partial void DisposeManaged();

        ~Visitor()
        {
            Dispose(false);
        }
    }
}
