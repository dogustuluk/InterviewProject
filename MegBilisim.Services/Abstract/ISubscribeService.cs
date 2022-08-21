using MegBilisim.Entities.Concrete;
using MegBilisim.Entities.Dtos;
using MegBilisim.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Services.Abstract
{
    public interface ISubscribeService
    {
        Task<IDataResult<Subscribe>> Get(int subscribeId);
        Task<IDataResult<IList<Subscribe>>> GetAll();
        Task<IResult> Add(SubscribeAddDto subscribeAddDto, string createdByName);
        Task<IResult> Update(SubscribeUpdateDto subscribeUpdateDto, string createdByName);
        Task<IResult> Delete(int subscribeId);
        Task<IResult> HardDelete(int subscribeId);
    }
    
}
