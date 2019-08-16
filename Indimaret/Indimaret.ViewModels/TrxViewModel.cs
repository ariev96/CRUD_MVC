using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.ViewModels
{
    public class TrxViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(8)]
        public String NoFaktur { get; set; }

        public DateTime? TglTransaksi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string NamaKaryawan { get; set; }
        public long? TotalHarga { get; set; }
        public long? SisaHarga { get; set; }

        public List<TrxDetail> trxDetail { get; set; }
    }

    public class TrxDetail
    {
        [Column(TypeName = "varchar")]
        [StringLength(8)]
        public string KodeBarang { get; set; }

        public long? JumlahBarang { get; set; }
    }
}
