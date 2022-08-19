using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Concrete
{
    public class Company:EntityUserBase,IEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int SubscriberId { get; set; }
        public ICollection<Subscribe> Subscriptions { get; set; }
    }
}
