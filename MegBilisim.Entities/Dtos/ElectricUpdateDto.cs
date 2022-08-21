using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Entities.Dtos
{
    public class ElectricUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Abone No")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]

        public string SubscriberNo { get; set; }
        [DisplayName("Son Ödeme Tarihi")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        public DateTime PaymentDate { get; set; }
        [DisplayName("Ödenecek Tutar")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        public decimal PaymentTotal { get; set; }
        [DisplayName("Not")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        public string Note { get; set; }
        [DisplayName("Sayaç Seri Numarası")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        public string CounterSerialNo { get; set; }
        [DisplayName("Tüketici Grubu")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        public string ConsumerGroup { get; set; }
    }
}
