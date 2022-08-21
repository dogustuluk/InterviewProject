using AutoMapper;
using MegBilisim.Data.Abstract;
using MegBilisim.Entities.Concrete;
using MegBilisim.Entities.Dtos;
using MegBilisim.Services.Abstract;
using MegBilisim.Shared.Utilities.Results.Abstract;
using MegBilisim.Shared.Utilities.Results.ComplexTypes;
using MegBilisim.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Services.Concrete
{
    public class ElectricManager : IElectricService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ElectricManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<ElectricDto>> Add(ElectricAddDto electricAddDto, string createdByName)
        {
            var electricInvoice = _mapper.Map<Electric>(electricAddDto);
            electricInvoice.CreatedByName = createdByName;
            electricInvoice.ModifiedByName = createdByName;
            var addedInvoice = await _unitOfWork.Electrics.AddAsync(electricInvoice);
            await _unitOfWork.SaveAsync();
            return new DataResult<ElectricDto>(ResultStatus.Success, $"sayaç seri numarası:{electricAddDto.CounterSerialNo} olan abonenin elektrik faturası eklendi.", new ElectricDto
            {
                Electric = addedInvoice,
                ResultStatus = ResultStatus.Success
            });
        }

        public Task<IResult> Delete(int electricId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ElectricDto>> Get(int electricId)
        {
            var electricInvoice = await _unitOfWork.Electrics.GetAsync(e => e.Id == electricId, e => e.Subscribes);
            if (electricInvoice != null)
            {
                return new DataResult<ElectricDto>(ResultStatus.Success, new ElectricDto
                {
                    Electric = electricInvoice,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ElectricDto>(ResultStatus.Error, "işlem başarısız", null);
        }

        public async Task<IDataResult<ElectricListDto>> GetAll()
        {
            var electricInvoices = await _unitOfWork.Electrics.GetAllAsync(null, e => e.Subscribes);
            if (electricInvoices.Count > -1)
            {
                return new DataResult<ElectricListDto>(ResultStatus.Success, new ElectricListDto
                {
                    Electrics = electricInvoices,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ElectricListDto>(ResultStatus.Error, "işlem başarısız", null);
        }

        public async Task<IDataResult<ElectricListDto>> GetAllByNonDeleted()
        {
            var electricInvoices = await _unitOfWork.Electrics.GetAllAsync(e => !e.IsDeleted, e => e.Subscribes);
            if (electricInvoices.Count >-1)
            {
                return new DataResult<ElectricListDto>(ResultStatus.Success, new ElectricListDto
                {
                    Electrics = electricInvoices,
                    ResultStatus =ResultStatus.Success
                });
            }
            return new DataResult<ElectricListDto>(ResultStatus.Error, "işlem başarısız", null);
        }

        public Task<IResult> HardDelete(int electricId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ElectricUpdateDto electricUpdateDto, string createdByName)
        {
            throw new NotImplementedException();
        }
    }
}
