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
    public interface IElectricService
    {
        Task<IDataResult<ElectricDto>> Get(int electricId);
        Task<IDataResult<ElectricListDto>> GetAll();
        Task<IDataResult<ElectricListDto>> GetAllByNonDeleted();

        Task<IDataResult<ElectricDto>> Add(ElectricAddDto electricAddDto, string createdByName);
        Task<IResult> Update(ElectricUpdateDto electricUpdateDto, string createdByName);
        Task<IResult> Delete(int electricId);
        Task<IResult> HardDelete(int electricId);
    }
}
