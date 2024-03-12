using GenericRepositoryDesignWithUnitOfWork;
using GenericRepositoryDesignWithUnitOfWork.Domain;
using GenericRepositoryDesignWithUnitOfWork.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDesignRepositoryWithUnitOfWork
{
    public class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork unitOfWork = new UnitOfWork(new AppDbContext());

            unitOfWork.HorseRepository.Add(new Horse() { Name = "Bold Pilot", IsActive = true, CreatedTime = DateTime.Now });
            unitOfWork.HorseRepository.Add(new Horse() { Name = "A Beautiful Mind", IsActive = true, CreatedTime = DateTime.Now });
            unitOfWork.HorseRepository.Add(new Horse() { Name = "Abay Hanım", IsActive = true, CreatedTime = DateTime.Now });
            unitOfWork.HorseRepository.Add(new Horse() { Name = "Heart Bride", IsActive = true, CreatedTime = DateTime.Now });
            unitOfWork.HorseRepository.Add(new Horse() { Name = "Lucky Lexi", IsActive = true, CreatedTime = DateTime.Now });

            unitOfWork.HorseRepository.GetTopHorses(3);

            unitOfWork.Complete();


        }
    }
}
