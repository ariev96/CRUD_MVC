using Indimaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indimaret.Repositories;
using Indimaret.ViewModels;

namespace Indimaret.Web.Controllers
{
    public class TransaksiController : Controller
    {
        // GET: Transaksi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(TrxMasterModel trxMasterModel)
        {
            TrxMasterRepo trxMasterRepo = new TrxMasterRepo();
            if (trxMasterRepo.Save(trxMasterModel))
            {
                return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
            //return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult SaveTransaksi(TrxViewModel trxViewModel)
        {
            TrxMasterRepo trxMasterRepo = new TrxMasterRepo();
            if (trxMasterRepo.SaveTransaksi(trxViewModel))
            {
                return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
            //return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
        }
    }
}