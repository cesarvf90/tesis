using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CobranzaWeb.Models;

namespace CobranzaWeb.Controllers
{
    public class GestoresController : Controller
    {
        //
        // GET: /Gestores/

        public ActionResult Index()
        {
            using (var db = new cobranzasEntities2())
            {
                return View(db.Gestors.ToList());
            }

            //return View();
        }

        //
        // GET: /Gestores/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Gestores/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Gestores/Create

        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        public ActionResult Create(Gestor gestor)
        {
            try
            {
                using (var db = new cobranzasEntities2())
                {
                    db.Gestors.Add(gestor);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Gestores/Edit/5
 
        public ActionResult Edit(int id)
        {
            using (var db = new cobranzasEntities2())
            {
                return View(db.Gestors.Find(id));
            }
        }

        //
        // POST: /Gestores/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Gestor gestor)
        {
            try
            {
                using (var db = new cobranzasEntities2())
                {
                    db.Entry(gestor).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gestores/Delete/5
 
        public ActionResult Delete(int id)
        {
            using (var db = new cobranzasEntities2())
            {
                return View(db.Gestors.Find(id));
            }
        }

        //
        // POST: /Gestores/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Gestor gestor)
        {
            try
            {
                using (var db = new cobranzasEntities2())
                {
                    db.Entry(gestor).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
