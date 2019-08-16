using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Indimaret.Models
{
    //Membuat Database langsung dari data
    [Table("MstBarang")]
    public class BarangModel
    {
        //bikin auto increment
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required(AllowEmptyStrings = true)]
        [Column(TypeName = "varchar")]
        [StringLength(8)]
        public string KodeBarang { get; set; }

        [Required(AllowEmptyStrings = true)]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string NamaBarang { get; set; }

        [Required(AllowEmptyStrings = true)]
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string AsalPabrik { get; set; }
        public long? JumlahBarang { get; set; }
        public int? HargaBarang { get; set; }
        public bool? IsDelete { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string CreatedBy { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}