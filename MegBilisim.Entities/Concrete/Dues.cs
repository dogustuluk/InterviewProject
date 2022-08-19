using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Concrete
{
    public class Dues:EntityInvoiceBase,IEntity
    {
        public ICollection<Subscribe> Subscribes { get; set; }
    }
}
