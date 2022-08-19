using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Shared.Entities.Abstract
{
    public abstract class EntityUserBase
    {
        public virtual int Id { get; set; }
        public virtual string Email { get; set; }
        public virtual byte[] PasswordHash { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual string ModifiedByName { get; set; } = "Admin";
        public virtual bool IsDeleted { get; set; } = false;

    }
}
