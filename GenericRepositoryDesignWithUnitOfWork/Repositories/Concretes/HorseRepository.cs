using GenericRepositoryDesignWithUnitOfWork.Domain;
using GenericRepositoryDesignWithUnitOfWork.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.Repositories.Concretes
{
    public class HorseRepository: Repository<Horse>, IHorseRepository 
    {
        public HorseRepository(AppDbContext context): base(context)
        {
        }
        public IList<Horse> GetHorsesWithJockeys()
        {
            return AppDbContext.Horses.Include("Jockeys").ToList();
        }

        public IList<Horse> GetTopHorses(int count)
        {
            return AppDbContext.Horses.Take(count).ToList();
        }
        public AppDbContext AppDbContext { get { return _context as AppDbContext; } }
    }
}
