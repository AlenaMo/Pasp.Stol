using MVCkursach.DAO;
using MVCkursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkursach.Controllers
{
       
    public class VidController : Controller
    {
        VidDAO vidDAO = new VidDAO();
        PasportBaseEntities entities = new PasportBaseEntities();

        // GET: /Vid/
[Authorize(Roles = "User")]
        public ActionResult Index()
        {
            ViewData["VidDoc"] = vidDAO.getAllDoc();
            return View(vidDAO.getAllDoc());
        }

        //
        // GET: /Vid/Details/5

        public ActionResult Details(string docname)
        {
            var documentDetails = (from c in entities.VidDocs
                                    where c.DocName == docname.ToString()
                                    select c).First();
            return View(documentDetails);
        }

        //
        // GET: /Vid/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vid/Create

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
        // GET: /Vid/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vid/Edit/5

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
        // GET: /Vid/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vid/Delete/5

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
    }
}
