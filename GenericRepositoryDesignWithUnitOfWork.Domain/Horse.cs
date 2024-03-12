using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryDesignWithUnitOfWork.Domain
{
    public class Horse: BaseEntity
    {
        public Horse() 
        {
            Jockeys = new List<Jockey>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Jockey> Jockeys { get; set; } 
    }
}
