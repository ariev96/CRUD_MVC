using Indimaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Repositories
{
    public class BarangRepo
    {
        public List<BarangModel> GetAll()
        {
            List<BarangModel> result = new List<BarangModel>();
            using (DataContext context = new DataContext())
            {
                List<BarangModel> paiminModel = (from brng in context.barangModel
                                                 where brng.IsDelete == false
                                                 select brng).ToList();
                return paiminModel;
            }
            //return result;
        }

        public bool Save(BarangModel paijo)
        {
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    dataContext.barangModel.Add(paijo);
                    dataContext.SaveChanges();

                };
                return true;
            }
            catch (Exception)
            {

                //throw;
                return false;
            }

            //return true;
        }

        public bool SaveEdit(BarangModel terserah)
        {
            try
            {
                using (DataContext datacontext = new DataContext())
                {
                    //datacontext.barangModel.
                    datacontext.Entry(terserah).State = System.Data.Entity.EntityState.Modified;
                    datacontext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                //Console.WriteLine(e);
                return false;
                //throw;
            }            
        }

        //public bool SaveDelete(BarangModel terserah)
        //{
        //    try
        //    {

        //        using (DataContext datacontext = new DataContext())
        //        {
        //            //datacontext.barangModel.
        //            datacontext.Entry(terserah).State = System.Data.Entity.EntityState.Modified;
        //            datacontext.SaveChanges();
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        /*throw*/;
        //    }
           
        //}
    }
}
