using MVCkursach.DAO;
using MVCkursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkursach.Controllers
{
    public class RequestController : Controller
    {
        RequestDAO requestDAO = new RequestDAO();
        private PasportBaseEntities entities = new PasportBaseEntities();

        //
        // GET: /Request/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Request/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Request/Create
[Authorize(Roles = "User")]
        public ActionResult Create()
        {
            var id1 = WebMatrix.WebData.WebSecurity.GetUserId(User.Identity.Name);
            int id = id1;
            Requests request = new Requests();
            request.State = "uncheck";
            request.Doc = null;
            request.UserId_ = id;
            return View("Create", request);
        }

        //
        // POST: /Request/Create

        [HttpPost]
        public ActionResult Create(Requests request)
        {
            try
            {
                if (requestDAO.addRequest(request))
                {
                    return RedirectToAction("Create", "Pasport");
                }
                else
                    return View("Create");
            }
            catch
            {
                return View("Create");
            }
        }

        //
        // GET: /Request/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Request/Edit/5

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
        // GET: /Request/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Request/Delete/5

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
