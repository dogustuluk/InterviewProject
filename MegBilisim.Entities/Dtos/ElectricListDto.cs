using MegBilisim.Entities.Concrete;
using MegBilisim.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Dtos
{
    public class ElectricListDto : DtoGetBase
    {
        public IList<Electric> Electrics { get; set; }
    }
}
