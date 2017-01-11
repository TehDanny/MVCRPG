using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRPG.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
                return View(Models.GlobalVariables.Characters);
        }

        // GET: Character/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(string name)
        {
            try
            {
                // TODO: Add insert logic here

                Models.Character model = new Models.Character(name);
                Models.GlobalVariables.Characters.Add(model);

                //return View("Index", model);                              // single object
                return View("Index", Models.GlobalVariables.Characters);    // list
            }
            catch
            {
                return View();
            }
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.Character model)
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

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Models.Character model)
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
