using GenericRepositoryDesignWithUnitOfWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.Repositories.Abstracts
{
    public interface IJockeyRepository: IRepository<Jockey>
    {
        IList<Jockey> GetJockeysWithHorses();
    }
}
