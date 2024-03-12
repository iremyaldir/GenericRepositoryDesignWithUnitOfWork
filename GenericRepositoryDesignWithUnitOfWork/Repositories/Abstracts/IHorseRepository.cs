using GenericRepositoryDesignWithUnitOfWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.Repositories.Abstracts
{
    public interface IHorseRepository: IRepository<Horse>
    {
        IList<Horse> GetTopHorses(int count);
        IList<Horse> GetHorsesWithJockeys();
    }
}
