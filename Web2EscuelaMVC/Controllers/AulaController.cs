using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web2EscuelaMVC.Data;
using Web2EscuelaMVC.Models;

namespace Web2EscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private EscuelaDBContext context = new EscuelaDBContext();

        // GET: Aula
        [HttpGet]
        public ActionResult Index()
        {
            List<Aula> list = context.Aulas.ToList();

            return View("Index",list);
        }


        // GET: Aula/Create
        [HttpGet]
        public ActionResult Create()
        {
            Aula aula = new Aula();
            return View("Register",aula);
        }

        // POST: Aula/Create
        [HttpPost]
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            
                return View("Register", aula);
            
        }

        // GET: Aula/Details/id
        [HttpGet]
        public ActionResult Details(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null) return HttpNotFound();
            return View("Detalle", aula);
        }


        // GET: Aula/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null) return HttpNotFound();
             return View("Edit", aula);
        }

        // POST: Aula/Edit
        [HttpPost]
        public ActionResult Edit(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aula).State = EntityState.Modified;
                context.SaveChanges();
                return View("Index",aula);
            }
            return View("Edit");
        }

        // GET: Aula/Delete/id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null) return HttpNotFound();
            return View("Delete", aula);
        }


        // POST: Aula/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Aula aula = context.Aulas.Find(id);

            if (aula != null)
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }
    }
    }
