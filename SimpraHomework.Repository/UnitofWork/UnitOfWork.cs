using Microsoft.EntityFrameworkCore;
using Simpra_Homework_Core.UnitofWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Repository.UnitofWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly AppDbContext _context;
        private bool disposed;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
        private async Task CleanAsync(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    await _context.DisposeAsync();
                }
            }

            disposed = true;
            GC.SuppressFinalize(this);
        }

        public async Task DisposeAsync()
        {
            await CleanAsync(true);
        }

    }
}
