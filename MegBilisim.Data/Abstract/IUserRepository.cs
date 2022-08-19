﻿using MegBilisim.Entities.Concrete;
using MegBilisim.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Data.Abstract
{
    public interface IUserRepository:IEntityRepository<User>
    {
    }
}
