using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Shared.Entities.Abstract
{
    public class EntityInvoiceBase
    {
        public virtual int Id { get; set; }
        public virtual string SubscriberNo { get; set; }
        public virtual bool CounterStatus { get; set; } = true;
        public virtual DateTime PaymentDate { get; set; }
        public virtual decimal PaymentTotal { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual string ModifiedByName { get; set; } = "Admin";
        public virtual bool IsDeleted { get; set; } = false;
        public virtual string Note { get; set; }

    }
}
