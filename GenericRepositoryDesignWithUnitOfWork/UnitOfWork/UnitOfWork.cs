using GenericRepositoryDesignWithUnitOfWork.Repositories.Abstracts;
using GenericRepositoryDesignWithUnitOfWork.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext appDbContext;
        public UnitOfWork(AppDbContext context)
        {
            this.appDbContext = context;
            HorseRepository = new HorseRepository(appDbContext);
            JockeyRepository = new JockeyRepository(appDbContext);
        }
        public IHorseRepository HorseRepository { get; private set; }

        public IJockeyRepository JockeyRepository { get; private set; }

        public int Complete()
        {
            return appDbContext.SaveChanges();
        }

        public void Dispose()
        {
            appDbContext.Dispose();
        }
    }
}
