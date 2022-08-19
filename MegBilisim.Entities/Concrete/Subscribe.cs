using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Concrete
{
    public class Subscribe:IEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int ElectricId { get; set; }
        public ICollection<Electric> Electric { get; set; }
        public int WaterId { get; set; }
        public ICollection<Water> Water { get; set; }
        public int DuesId { get; set; }
        public ICollection<Dues> Dues { get; set; }
    }
}
