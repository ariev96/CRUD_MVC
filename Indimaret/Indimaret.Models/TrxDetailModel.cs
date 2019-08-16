using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Models
{
    [Table("TrxDetail")]
    public class TrxDetailModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(8)]
        public string NoFaktur { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(8)]
        public string KodeBarang { get; set; }

        public long? JumlahBarang { get; set; }
    }
}
