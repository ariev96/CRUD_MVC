using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Models
{
    public class DataContext : DbContext
    {
        //buat construktor
        //method dengan nama class yang sama
        //inisializer, data awalan supaya tidak kosong

        public DataContext() : base("name=IndimaretConn")
        {
            Database.SetInitializer(new IndimaretInitializer());
            //Database.SetInitializer<DataContext>(null);
        }
          public virtual DbSet<BarangModel> barangModel { get; set; }
          public virtual DbSet<TrxMasterModel> trxMasterModel { get; set; }
          public virtual DbSet<TrxDetailModel> trxDetailModel { get; set; }

        //supaya nama tabel tidak plural
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
    
    }
}
