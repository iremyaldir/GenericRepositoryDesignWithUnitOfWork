using GenericRepositoryDesignWithUnitOfWork.Domain;
using GenericRepositoryDesignWithUnitOfWork.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.Repositories.Concretes
{
    public class JockeyRepository : Repository<Jockey>, IJockeyRepository
    {
        public JockeyRepository(AppDbContext context):base(context)
        {
        
        }
        public IList<Jockey> GetJockeysWithHorses()
        {
           return AppDbContext.Jockeys.Include("Horse").ToList();
        }
        public AppDbContext AppDbContext { get { return _context as AppDbContext;  } }
    }
}
