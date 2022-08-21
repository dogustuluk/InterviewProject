using MegBilisim.Entities.Concrete;
using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Dtos
{
    public class ElectricDto: DtoGetBase
    {
        public Electric Electric { get; set; }
    }
}
