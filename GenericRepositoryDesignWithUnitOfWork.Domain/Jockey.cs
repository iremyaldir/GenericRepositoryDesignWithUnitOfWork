using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.Domain
{
    public class Jockey: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int HorseId { get; set; }
        public Horse Horse { get; set;}

    }
}
