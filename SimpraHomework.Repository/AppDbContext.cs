using Microsoft.EntityFrameworkCore;
using Simpra_Homework_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Staff> Staffs { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is Base entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            entityReference.CreatedAt = DateTime.Now;
                            break;
                        case EntityState.Modified:
                            Entry(entityReference).Property(x => x.CreatedAt).IsModified = false;
                            break;
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
