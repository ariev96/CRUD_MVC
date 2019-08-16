using Indimaret.Models;
using Indimaret.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Repositories
{
    public class TrxMasterRepo
    {
        public bool Save(TrxMasterModel trxMasterModel)
        {
            using (DataContext context = new DataContext())
            {
                try
                {
                    context.trxMasterModel.Add(trxMasterModel);
                    context.SaveChanges();

                    return true;

                }
                catch (Exception)
                {
                    return false;
                    //throw;
                }
            }

            //return true;
        }

        public bool SaveTransaksi(TrxViewModel trxViewModel)
        {
            try
            {
                TrxMasterModel trxMasterModel = new TrxMasterModel();
                trxMasterModel.NoFaktur = trxViewModel.NoFaktur;
                trxMasterModel.TglTransaksi = trxViewModel.TglTransaksi;
                trxMasterModel.NamaKaryawan = trxViewModel.NamaKaryawan;
                trxMasterModel.TotalHarga = trxViewModel.TotalHarga;
                trxMasterModel.SisaHarga = trxViewModel.SisaHarga;
                using (DataContext context = new DataContext())
                {
                    context.trxMasterModel.Add(trxMasterModel);
                    context.SaveChanges();

                }

                //section untuk save detail
                TrxDetailModel trxDetailModel = new TrxDetailModel();
                foreach (var item in trxViewModel.trxDetail)
                {
                    trxDetailModel.NoFaktur = trxViewModel.NoFaktur;
                    trxDetailModel.KodeBarang = item.KodeBarang;
                    trxDetailModel.JumlahBarang = item.JumlahBarang;


                    //untuk penyimpanan
                    //menggunakan data context
                    using (DataContext ctx = new DataContext()) {
                        ctx.trxDetailModel.Add(trxDetailModel);
                        ctx.SaveChanges();
                    }
                }
              

                return true;

            }
            catch (Exception)
            {
                return false;
                //throw;
            }
           

            //return true;
        }
    }
}
