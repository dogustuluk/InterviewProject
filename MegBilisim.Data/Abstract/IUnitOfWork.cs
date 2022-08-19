using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ICompanyRepository Companies { get;}
        IDuesRepository Dues { get;}
        IElectricRepository Electrics { get;}
        IRoleRepository Roles { get;}
        ISubscribeRepository Subscribies { get;}
        IUserRepository Users { get;}
        IWaterRepository Waters { get;}
        Task<int> SaveAsync(); //int>effected row count

    }
}
