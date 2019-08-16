using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Models
{
    public class IndimaretInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
           List <BarangModel> barangModel = new List<BarangModel>();
            barangModel.Add(new BarangModel {KodeBarang = "KB001", NamaBarang="Panadol",AsalPabrik="Bogor",JumlahBarang=25,HargaBarang=5500, IsDelete=false,CreatedBy="1",CreatedDate= new DateTime(2019,8,8),UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB002", NamaBarang = "Bodrex", AsalPabrik = "Jakarta", JumlahBarang = 30, HargaBarang = 7000, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB003", NamaBarang = "Neozep", AsalPabrik = "Malang", JumlahBarang = 20, HargaBarang = 5000, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB004", NamaBarang = "Mixagrip", AsalPabrik = "Tangerang", JumlahBarang = 45, HargaBarang = 6500, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB005", NamaBarang = "Antimo", AsalPabrik = "Depok", JumlahBarang = 50, HargaBarang = 10000, IsDelete = true, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB006", NamaBarang = "Woods", AsalPabrik = "Bekasi", JumlahBarang = 35, HargaBarang = 9000, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB007", NamaBarang = "Antangin", AsalPabrik = "Bogor", JumlahBarang = 25, HargaBarang = 5500, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB008", NamaBarang = "TolakAngin", AsalPabrik = "Tegal", JumlahBarang = 60, HargaBarang = 9500, IsDelete = true, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB009", NamaBarang = "Decadril", AsalPabrik = "Bandung", JumlahBarang = 70, HargaBarang = 5700, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB0010", NamaBarang = "OBH", AsalPabrik = "Garut", JumlahBarang = 65, HargaBarang = 3500, IsDelete = true, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });
            barangModel.Add(new BarangModel { KodeBarang = "KB0011", NamaBarang = "Kombantrin", AsalPabrik = "Padang", JumlahBarang = 15, HargaBarang = 4000, IsDelete = false, CreatedBy = "1", CreatedDate = new DateTime(2019, 8, 8), UpdatedBy = "1", UpdatedDate = new DateTime(2019, 8, 8) });

            base.Seed(context);
            foreach (BarangModel item in barangModel)
            {
                context.barangModel.Add(item);
            }
        }
    }
}
