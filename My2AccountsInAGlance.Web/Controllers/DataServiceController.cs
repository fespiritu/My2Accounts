using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using My2AccountsInAGlance.Repository;
using Microsoft.Practices.Unity;

namespace My2AccountsInAGlance.Web.Controllers
{
    public class DataServiceController : Controller
    {
        IAccountRepository _AccountRepository;
        ISecurityRepository _SecurityRepository;
        IMarketsAndNewsRepository _MarketsAndNewsRepository;

        public DataServiceController() : this(null,null,null)
        {

        }
        public DataServiceController(IAccountRepository acctRepo, ISecurityRepository secRepo, IMarketsAndNewsRepository marketRepo)
        {
            _AccountRepository = acctRepo;
            _SecurityRepository = secRepo;
            _MarketsAndNewsRepository = marketRepo;

        }
        //
        // GET: /DataService/
        
        public ActionResult GetAccount(string acctNumber)
        {
            var acct = _AccountRepository.GetAccount(acctNumber);

            return Json(acct,JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetQuote(string symbol)
        {
            var sec = _SecurityRepository.GetSecurity(symbol);
            return Json(sec, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetMarketIndexes(){
            var indexes = _MarketsAndNewsRepository.GetMarketNews();
            return Json(indexes, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetTickerQuotes()
        {
            var marketQuotes = _MarketsAndNewsRepository.GetMarketTickerQuotes();
            var securityQuotes = _SecurityRepository.GetSecurityTickerQuotes();
            marketQuotes.AddRange(securityQuotes);

            var news = _MarketsAndNewsRepository.GetMarketNews();

            return Json(new { Market = marketQuotes, News = news }, JsonRequestBehavior.AllowGet);
        }


        #region CRUD
        //
        // GET: /DataService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DataService/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DataService/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DataService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DataService/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DataService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DataService/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion CRUD

  
    }
}
