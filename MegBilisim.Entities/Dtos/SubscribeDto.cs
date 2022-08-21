using MegBilisim.Entities.Concrete;
using MegBilisim.Shared.Entities.Abstract;
using MegBilisim.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Dtos
{
    public class SubscribeDto : DtoGetBase
    {
        public Subscribe Subscribe { get; set; }
      //  public override ResultStatus ResultStatus { get; set; } = ResultStatus.Success;
    }
}
