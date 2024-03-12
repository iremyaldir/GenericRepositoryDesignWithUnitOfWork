using GenericRepositoryDesignWithUnitOfWork.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        //IDisposable is inherited so that the IUnitOfWork transaction is automatically disposed of when it is completed.
        IHorseRepository HorseRepository { get; }
        IJockeyRepository JockeyRepository { get; }
        int Complete();
    }
}
