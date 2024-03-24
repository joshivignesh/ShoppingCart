﻿using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data;

namespace ShoppingCart.UnitOfWork
{
    public class UnitOfwork
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed = false;

        public UnitOfwork(ApplicationDbContext context)
        {
            _context = context;
        }
        public DbContext Context => _context;

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
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
