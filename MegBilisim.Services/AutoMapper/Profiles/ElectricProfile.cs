using AutoMapper;
using MegBilisim.Entities.Concrete;
using MegBilisim.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Services.AutoMapper.Profiles
{
    public class ElectricProfile:Profile
    {
        public ElectricProfile()
        {
            CreateMap<ElectricAddDto, Electric>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ElectricUpdateDto, Electric>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
