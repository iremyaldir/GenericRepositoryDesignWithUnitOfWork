using GenericRepositoryDesignWithUnitOfWork.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(): base("AppDbContext")
        {

        }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Jockey> Jockeys { get; set; }
    }
}
