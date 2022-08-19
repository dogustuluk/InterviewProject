using MegBilisim.Data.Abstract;
using MegBilisim.Entities.Concrete;
using MegBilisim.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Data.Concrete.EntityFramework.Repositories
{
    public class EfSubscribeRepository : EfEntityRepository<Subscribe>, ISubscribeRepository
    {
        public EfSubscribeRepository(DbContext context) : base(context)
        {
            //Ek Özellikler
        }
    }
}
