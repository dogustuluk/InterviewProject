using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Concrete
{
    public class Water:EntityInvoiceBase,IEntity
    {
        public string CounterNo { get; set; }
        public string ReaderCode { get; set; }
        public string FirstIndex { get; set; }
        public string LastIndex { get; set; }
        public DateTime FirstReadingDate { get; set; }
        public DateTime LastReadingDate { get; set; }
        public ICollection<Subscribe> Subscribes { get; set; }

    }
}
