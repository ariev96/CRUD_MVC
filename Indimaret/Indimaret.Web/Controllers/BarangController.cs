using Indimaret.Models;
using Indimaret.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indimaret.Web.Controllers
{
    public class BarangController : Controller
    {
        // GET: Barang
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListBarang()
        {
            return PartialView("_ListBarang");
        }

        public ActionResult AddBarang()
        {
            return PartialView("_AddBarang");
        }

        public ActionResult EditBarang()
        {
            return PartialView("_EditBarang");
        }

        public ActionResult DeleteBarang()
        {
            return PartialView("_DeleteBarang");
        }

        public ActionResult SaveBarang(BarangModel paimin)
        {
            Session["ID"] = "1";
            //menggunakan return JSON
            BarangRepo barangRepo = new BarangRepo();
            paimin.CreatedBy = this.Session["ID"].ToString();
            paimin.CreatedDate = DateTime.Now;
            if (barangRepo.Save(paimin))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult SaveEditBarang(BarangModel terserah)
        {
            Session["ID"] = "1";

            BarangRepo barangRepo = new BarangRepo();
            terserah.CreatedBy = this.Session["ID"].ToString();
            terserah.CreatedDate = DateTime.Now;
            terserah.UpdatedDate = DateTime.Now;
            //barangRepo.SaveEdit(terserah);
            if (barangRepo.SaveEdit(terserah))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }

            //return View();
        }

        //public ActionResult SaveDeleteBarang(BarangModel terserah)
        //{
        //    Session["ID"] = "1";

        //    BarangRepo barangRepo = new BarangRepo();
        //    terserah.CreatedBy = this.Session["ID"].ToString();
        //    terserah.CreatedDate = DateTime.Now;
        //    terserah.UpdatedDate = DateTime.Now;
        //    if (barangRepo.SaveEdit(terserah))
        //    {
        //        return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
        //    }

        //    return View();
        //}

        public ActionResult GetAll()
        {
            BarangRepo barangRepo = new BarangRepo();
            List<BarangModel> barangModel = barangRepo.GetAll();

            return Json(barangModel,JsonRequestBehavior.AllowGet);
        }
    }
}