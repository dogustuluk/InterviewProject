using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Concrete
{
    public class Electric:EntityInvoiceBase,IEntity
    {
        public string CounterSerialNo { get; set; }
        public string ConsumerGroup { get; set; }
    }
}
